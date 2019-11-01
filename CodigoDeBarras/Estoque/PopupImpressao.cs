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
        EstoqueImpressaoEtiqueta estoqueImpressaoEtiqueta;
        
        List<EstoqueImpressaoEtiqueta> lstnovaListaEstoqueEtiqueta;


        public PopupImpressao()
        {
            InitializeComponent();
            CarregarListaDeImpressoras();
            CarregarListaQtdeEtiquetas();
            CarregarListaDeEtiquetas();
        }

        private void CarregarListaDeEtiquetas()
        {
            estoqueImpressaoEtiqueta = new EstoqueImpressaoEtiqueta();
            List<EstoqueImpressaoEtiqueta> lstEstoqueImpressaoEtiqueta = new List<EstoqueImpressaoEtiqueta>();
            EstoqueImpressaoEtiquetaBLL estoqueImpressaoEtiquetaBLL = new EstoqueImpressaoEtiquetaBLL();

            lstEstoqueImpressaoEtiqueta = estoqueImpressaoEtiquetaBLL.ObterListaEstoqueImpressaoEtiqueta();
            lstnovaListaEstoqueEtiqueta = new List<EstoqueImpressaoEtiqueta>();

            //monta a lista novamente multiplicando as quantidades de produtos para cada item no banco
            foreach (var item in lstEstoqueImpressaoEtiqueta)
            {
                for (int i = 0; i < item.EstoqueDisp; i++)
                {
                    lstnovaListaEstoqueEtiqueta.Add(item);
                }
            }

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
            iQtdeEtiqRestante = lstnovaListaEstoqueEtiqueta.Count;
           
            if (lstnovaListaEstoqueEtiqueta != null)
            {
                System.Drawing.Graphics g = this.picBarcode.CreateGraphics();

                g.FillRectangle(new System.Drawing.SolidBrush(System.Drawing.SystemColors.Control),
                    new Rectangle(0, 0, picBarcode.Width, picBarcode.Height));


                var printDocument = sender as System.Drawing.Printing.PrintDocument;
                if (printDocument != null)
                {
                    double xEspacoDireiraIni = 7,
                            xEspacoEsquerdaIni = 7,
                            yEspacaoDireitaIni = 8.5,
                            yEspacoEsquerdaIni = 8.5,
                            recuoHTexto = 2,
                            recuoVTexto = 2,
                            xInicio = xEspacoDireiraIni + recuoHTexto,
                            yInicio = yEspacaoDireitaIni + recuoVTexto,
                            larguraEtiqueta = 63.5,
                            alturaEtiqueta = 26.4;
                            
                    int linha = 0;
                    
                    for (int i = 0; i < iQtdeEtiqRestante; i++)
                    {
                        estoqueImpressaoEtiqueta = lstnovaListaEstoqueEtiqueta[i];

                        if (linha == 11) linha = 0;
                        if (i > 0) xInicio += recuoHTexto + 2.5 + larguraEtiqueta;
                        if (i % 3 == 0 && i > 0)
                        {
                            yInicio = yInicio + (float)Convert.ToDecimal(alturaEtiqueta); //QUEBRA A LINHA EM MULTIPLOS DE 3
                            xInicio = xEspacoDireiraIni + recuoHTexto;
                            linha += 1;
                        }

                        CriarEan13(estoqueImpressaoEtiqueta);
                        ean13.Linha = linha;
                        ean13.Scale = (float)Convert.ToDecimal(0.8);
                        ean13.ImprimirEtiquetaCompleta(ev.Graphics, estoqueImpressaoEtiqueta, xInicio, yInicio, new System.Drawing.Point(0, 0));
                        
                        //txtChecksumDigit.Text = ean13.ChecksumDigit;

                        if (i == 32)
                        {
                            lstnovaListaEstoqueEtiqueta.RemoveRange(0, 33);
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
                strCodEan = "2" + strCodEan;
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

        private void cbQtdeEtiquetas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void picBarcode_Click(object sender, EventArgs e)
        {

        }
    }
}
