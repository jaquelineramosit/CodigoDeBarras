using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CodigoDeBarras.BLL;

namespace CodigoDeBarras
{
    public partial class frmEstoqueSistema : Form
    {
        //Estoque cEstoque;
        List<Estoque> lstEstoque = new List<Estoque>();

        public frmEstoqueSistema()
        {
            InitializeComponent();
            EstoqueBLL estoqueBLL = new EstoqueBLL();

            dgvEstoqueReal.DataSource = estoqueBLL.ObterListaEstoque();
        }

        private void btnImportar_Click(object sender, EventArgs e)
        {
            lblMensagem.Text = "Inicializando a importação do arquivo";
            System.Threading.Thread.Sleep(1000);
            ImportarArquivoExcel();
        }

        public void ImportarArquivoExcel()
        {
            string nomeArquivo = txtImportarArquivo.Text;
            if (nomeArquivo != "")
            {
                EstoqueBLL cEstoqueBLL = new EstoqueBLL();
                lstEstoque = cEstoqueBLL.ObterListaExcelEstoqueReal(nomeArquivo);
                dgvEstoqueReal.DataSource = lstEstoque;
                lblUltAtualizacao.Text = DateTime.Now.ToString();
                lblQtdeReg.Text = lstEstoque != null ? lstEstoque.Count.ToString() : "";

                MessageBox.Show("Arquivo Importado com Sucesso!");
            }
        }

        private void btnSelArquivo_Click(object sender, EventArgs e)
        {
            string arquivo = "";

            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "Excel Files(.xlsx)|*.xlsx|Excel Files(.xls)|*.xls";
            openFileDialog.Title = "Selecione um arquivo";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                arquivo = openFileDialog.FileName;
                txtImportarArquivo.Text = arquivo;
                //EstoqueBLL cEstoqueBLL = new EstoqueBLL();

                //lstEstoque = cEstoqueBLL.ObterListaExcelEstoqueReal(arquivo);

                //dgvEstoqueReal.DataSource = lstEstoque;
            }
            else MessageBox.Show("Selecione um arquivo excel para iniciar!", "Atenção");
        }

        private void btnConferir_Click(object sender, EventArgs e)
        {
            //Application.Run(new frmEstoqueConferir(1));
            frmEstoqueConferir novofrmEstoqueConferir = new frmEstoqueConferir(1);
            novofrmEstoqueConferir.Show();
        }
    }
}
