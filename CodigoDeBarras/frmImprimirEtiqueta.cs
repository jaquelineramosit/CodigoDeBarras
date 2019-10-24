using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using CodigoDeBarras.BLL;

namespace CodigoDeBarras
{
    public partial class frmImprimirEtiqueta : Form
    {
        private Ean13 ean13 = null;
        public List<EstoqueImpressaoEtiqueta> lstEstoqueImpressaoEtiqueta = new List<EstoqueImpressaoEtiqueta>();
        public int iQtdeEtiqRestante = 0;

        public frmImprimirEtiqueta()
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

            for (int i = 3; i <= 36; i+=3)
            {
                cbQtdeEtiquetas.Items.Add(i);
            }
        }

        private void cboListaImpresssora_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboListaImpresssora.SelectedItem.ToString() == "")
            {
                btnImportarArquivo.Enabled = false;
                btnImprimeEtiquetas.Enabled = false;
            }
            else {
                btnImportarArquivo.Enabled = true;
            }
        }

        private void CriarEan13(EstoqueImpressaoEtiqueta estoqueImpressaoEtiqueta)
        {

            string strCodEan = "";
            strCodEan = estoqueImpressaoEtiqueta.CodigoBarras;
            ean13 = new Ean13();

            ean13.CountryCode = strCodEan.Substring(1, 2);

            ean13.ManufacturerCode = strCodEan.Substring(3, 5);
            ean13.ProductCode = strCodEan.Substring(8, 5);

            //ean13.ChecksumDigit = strCodEan.Substring(12, 1);

        }

        private void btnImportarArquivo_Click(object sender, EventArgs e)
        {
            string arquivo = "";

            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "Excel Files(.xlsx)|*.xlsx|Excel Files(.xls)|*.xls";
            openFileDialog.Title = "Selecione um arquivo";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                arquivo = openFileDialog.FileName;

                //alterar esse método para a classe EstoqueImpressaoEtiqueta
                EstoqueBLL cEstoqueBLL = new EstoqueBLL();
                

                lstEstoqueImpressaoEtiqueta = cEstoqueBLL.ObterListaExcel(arquivo);

                dgvEstoque.DataSource = lstEstoqueImpressaoEtiqueta;

                iQtdeEtiqRestante = lstEstoqueImpressaoEtiqueta.Count;

                btnImprimeEtiquetas.Enabled = true;
            }
            else MessageBox.Show("Selecione um arquivo excel para iniciar!", "Atenção");
        }


        private void BtnImprimeEtiquetas(object sender, System.Drawing.Printing.PrintPageEventArgs ev)
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
                    EstoqueImpressaoEtiqueta estoqueImpressaoEtiqueta = lstEstoqueImpressaoEtiqueta[i];
                   
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
                        lstEstoqueImpressaoEtiqueta.RemoveRange(0, 36);
                        iQtdeEtiqRestante = lstEstoqueImpressaoEtiqueta.Count;
                        ev.HasMorePages = true;
                        break;
                    }
                    
                }
                ev.Graphics.Dispose();
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

        private void frmImprimirEtiqueta_Load(object sender, EventArgs e)
        {
            //cboListaImpresssora.SelectedItem[""];
        }
    }
}
