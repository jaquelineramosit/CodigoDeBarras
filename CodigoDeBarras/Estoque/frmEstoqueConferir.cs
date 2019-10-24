using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CodigoDeBarras.BLL;

namespace CodigoDeBarras
{
    public partial class frmEstoqueConferir : Form
    {
        [DllImport("user32.dll")]
        private static extern int GetWindowThreadProcessId(int hWnd, out int lpdwProcessId);

        Estoque estoque;
        EstoqueBLL estoqueBLL;
        EstoqueDivergente estoqueDivergente;
        EstoqueDivergenteBLL estoqueDivergenteBLL;
        List<EstoqueDivergente> lstEstoqueDivergente = new List<EstoqueDivergente>();


        public frmEstoqueConferir()
        {
            InitializeComponent();
        }

        public frmEstoqueConferir(int estado)
        {
            if (estado == 1)
            {
                //chama método conferir
                ConferirEstoque();
            }
        }

        private void frmEstoqueConferir_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'sistemaLojaDataSet1.EstoqueDivergente'. Você pode movê-la ou removê-la conforme necessário.
            this.estoqueDivergenteTableAdapter.Fill(this.sistemaLojaDataSet1.EstoqueDivergente);
            PopularLabelQtdeRegistro(this.sistemaLojaDataSet1.EstoqueDivergente.Count);

        }

        private void btnConferir_Click(object sender, EventArgs e)
        {
            ConferirEstoque();
        }

        #region

        public void ConferirEstoque() {

            estoqueDivergenteBLL = new EstoqueDivergenteBLL();
            lstEstoqueDivergente = new List<EstoqueDivergente>();
            lstEstoqueDivergente = estoqueDivergenteBLL.SalvarEstoqueDivergente();

            dgvConferir.DataSource = lstEstoqueDivergente;
            PopularLabelQtdeRegistro(lstEstoqueDivergente.Count);
        }

        public void PopularLabelQtdeRegistro(int qtdeRegistro)
        {
            lblQtdeRegConferir.Text = qtdeRegistro.ToString();
        }
        #endregion

        private void btnExportarExcel_Click(object sender, EventArgs e)
        {
            ExportarArquivoExcel();
        }

        public void ExportarArquivoExcel()
        {
            estoqueDivergenteBLL = new EstoqueDivergenteBLL();

            Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
            var process = GetExcelProcess(excelApp);
            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                string localArquivo;
                saveFileDialog.Filter = "Excel Files(.xlsx)|*.xlsx|Excel Files(.xls)|*.xls";
                saveFileDialog.Title = "Nome do Arquivo";
                saveFileDialog.FileName = "EstoqueDivergente.xlsx";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    localArquivo = saveFileDialog.FileName;

                    Microsoft.Office.Interop.Excel.Workbook workbook = excelApp.Workbooks.Add();

                    //aqui pega a lista de itens com divergencia
                    //1. De quantidade de itens
                    //2. Itens que tem na tabela estoque x estoqueApurado

                    lstEstoqueDivergente = estoqueDivergenteBLL.ListaEstoqueDivergente();
                    
                    if (lstEstoqueDivergente.Count > 0)
                    {

                        //Preenche apenas o cabeçalho da planilha
                        PropertyInfo[] pi;
                        int k = 1;
                        pi = lstEstoqueDivergente[0].GetType().GetProperties();
                        foreach (var p in pi)
                        {
                            if (p.PropertyType.Name != "ICollection`1")
                            {
                                excelApp.Cells[1, k] = p.Name;
                                k++;
                            }
                        }
                        pi = null;

                        //UI.progressBar progressBar = new UI.progressBar();
                        //progressBar.Show();
                        //progressBar.barraDeProgresso.Maximum = lstEnderecoFormatado.Count;

                        EstoqueDivergente estoqueDivergente;

                        for (var i = 0; i < lstEstoqueDivergente.Count; i++)
                        {
                            estoqueDivergente = new EstoqueDivergente();

                            estoqueDivergente = lstEstoqueDivergente[i];
                            pi = estoqueDivergente.GetType().GetProperties();
                            int j = 1;
                            foreach (PropertyInfo p in pi)
                            {
                                if (p.PropertyType.Name != "ICollection`1")
                                {
                                    string valor = "";
                                    if (p.GetValue(estoqueDivergente, null) != null)
                                    {
                                        valor = p.GetValue(estoqueDivergente, null).ToString();
                                        excelApp.Cells[i + 2, j] = valor;
                                    }
                                    j++;
                                }
                            }
                            //progressBar.barraDeProgresso.Value = i;
                        }

                        //progressBar.Close();


                        excelApp.Columns.AutoFit();

                        excelApp.ActiveWorkbook.SaveAs(localArquivo);

                        workbook.Close(0);
                        excelApp.Quit();

                        workbook = null;
                        excelApp = null;
                        process.Kill();

                        MessageBox.Show("Excel Gerado com Sucesso!");
                    }
                    
                }
                else MessageBox.Show("Informe o nome do arquivo excel para iniciar!", "Atenção");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao gerar o arquivo excel. Erro: " + ex.Message);
                process.Kill();
            }
        }
        //pega o id do processo criado. método necessário para dar kill nos apps excel
        Process GetExcelProcess(Microsoft.Office.Interop.Excel.Application excelApp)
        {
            int id;
            GetWindowThreadProcessId(excelApp.Hwnd, out id);
            return Process.GetProcessById(id);
        }

        private static string RemoveAcentos(string valor)
        {
            byte[] bytes = Encoding.GetEncoding("iso-8859-8").GetBytes(valor);
            return Encoding.UTF8.GetString(bytes);
        }
    }
}
