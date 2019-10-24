using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using CodigoDeBarras.BLL;

namespace CodigoDeBarras
{
    public partial class PopupImpressao : Form
    {
        Ean13 ean13;
        public int iQtdeEtiqRestante = 0;
        public int iQtdeItensRestantes = 0;

        public PopupImpressao()
        {
            InitializeComponent();
            CarregarListaDeImpressoras();
            CarregarListaQtdeEtiquetas();
        }

        private void CarregarListaDeImpressoras()
        {
            cboListaImpresssora.Items.Clear();

            foreach (var printer in System.Drawing.Printing.PrinterSettings.InstalledPrinters)
            {
                cboListaImpresssora.Items.Add(printer);
            }

        }

        private void CarregarListaQtdeEtiquetas()
        {
            cbQtdeEtiquetas.Items.Clear();

            for (int i = 3; i <= 36; i += 3)
            {
                cbQtdeEtiquetas.Items.Add(i);
            }
        }
        
        private void BtnImprimeEtiquetas(object sender, System.Drawing.Printing.PrintPageEventArgs ev)
        {
            EstoqueImpressaoEtiqueta estoqueImpressaoEtiqueta;
            List<EstoqueImpressaoEtiqueta> lstEstoqueImpressaoEtiqueta = new List<EstoqueImpressaoEtiqueta>();
            List<EstoqueImpressaoEtiqueta> lstnovaListaEstoqueEtiqueta = new List<EstoqueImpressaoEtiqueta>();
            EstoqueImpressaoEtiquetaBLL estoqueImpressaoEtiquetaBLL = new EstoqueImpressaoEtiquetaBLL();
            
            lstEstoqueImpressaoEtiqueta = estoqueImpressaoEtiquetaBLL.ObterListaEstoqueImpressaoEtiqueta();

            //monta a lista novamente multiplicando as quantidades de produtos para cada item no banco
            foreach (var item in lstEstoqueImpressaoEtiqueta)
            {
                for (int i = 0; i < item.EstoqueDisp; i++)
                {
                    lstnovaListaEstoqueEtiqueta.Add(item);
                }
            }

            iQtdeEtiqRestante = lstnovaListaEstoqueEtiqueta.Count;
           
            if (lstnovaListaEstoqueEtiqueta != null)
            {
                System.Drawing.Graphics g = this.picBarcode.CreateGraphics();

                g.FillRectangle(new System.Drawing.SolidBrush(System.Drawing.SystemColors.Control),
                    new Rectangle(0, 0, picBarcode.Width, picBarcode.Height));


                var printDocument = sender as System.Drawing.Printing.PrintDocument;
                if (printDocument != null)
                {
                    int xInicio = 4, linha = 0;
                    float yInicio = (float)Convert.ToDecimal(6.4);

                    for (int i = 0; i < iQtdeEtiqRestante; i++)
                    {
                        estoqueImpressaoEtiqueta = lstnovaListaEstoqueEtiqueta[i];

                        if (linha == 12) linha = 0;
                        if (i > 0) xInicio += 71; //SETA UM ESPAÇO ENTRE AS ETIQUETAS NO VALOR DE 71
                        if (i % 3 == 0 && i > 0)
                        {
                            yInicio = yInicio + (float)Convert.ToDecimal(23.8); //QUEBRA A LINHA EM MULTIPLOS DE 3
                            xInicio = 4;

                            linha += 1;
                        }

                        CriarEan13(estoqueImpressaoEtiqueta);
                        ean13.Linha = linha;
                        ean13.Scale = (float)Convert.ToDecimal(0.8);
                        ean13.ImprimirEtiquetaCompleta(ev.Graphics, estoqueImpressaoEtiqueta, xInicio, yInicio, new System.Drawing.Point(0, 0));

                        //txtChecksumDigit.Text = ean13.ChecksumDigit;

                        if (i == 35)
                        {
                            lstnovaListaEstoqueEtiqueta.RemoveRange(0, 36);
                            iQtdeEtiqRestante = lstnovaListaEstoqueEtiqueta.Count;
                            ev.HasMorePages = true;
                            break;
                        }
                    }
                    ev.Graphics.Dispose();
                }
            }
            else {
                MessageBox.Show("Não há dados para impressão de etiquetas! É necessário cadastrar etiquetas antes de imprimir.");
            }
        }

        private void btnImprimeEtiquetas_Click(object sender, EventArgs e)
        {
            using (System.Drawing.Printing.PrintDocument pd = new System.Drawing.Printing.PrintDocument())
            {
                pd.PrintPage += BtnImprimeEtiquetas;
                pd.PrinterSettings.PrinterName = cboListaImpresssora.SelectedItem.ToString();

                pd.Print();

                MessageBox.Show("Impressão realizada com sucesso!");
            }
        }

        private void CriarEan13(EstoqueImpressaoEtiqueta estoqueImpressaoEtiqueta)
        {
            string strCodEan = "";
            strCodEan = estoqueImpressaoEtiqueta.CodigoBarras;
            ean13 = new Ean13();
            
            for (int j = 0; j < (13 - strCodEan.Length); j++)
            {
                strCodEan = "1" + strCodEan;
            }


            ean13.CountryCode = strCodEan.Substring(1, 2);

            ean13.ManufacturerCode = strCodEan.Substring(3, 5);
            ean13.ProductCode = strCodEan.Substring(8, 5);

            //ean13.ChecksumDigit = strCodEan.Substring(12, 1);
        }

        private void cboListaImpresssora_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            if (cboListaImpresssora.SelectedItem.ToString() == "")
            {
                btnImprimeEtiquetas.Enabled = false;
            }
            else
            {
                btnImprimeEtiquetas.Enabled = true;
            }
        }

    }
}
