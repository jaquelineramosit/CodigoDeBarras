using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CodigoDeBarras.BLL;

namespace CodigoDeBarras
{
    public partial class frmEstoqueApuradoSimples : Form
    {
        EstoqueApurado estoqueApurado;
        EstoqueApuradoBLL estoqueApuradoBLL;
        Estoque estoque;
        EstoqueBLL estoqueBLL;
        int nrlinha;

        public frmEstoqueApuradoSimples()
        {
            InitializeComponent();
        }

        private void frmEstoqueApuradoSimples_Load(object sender, EventArgs e)
        {
            CarregaGridEstoqueApurado();

        }

        private void CarregaGridEstoqueApurado()
        {
            


            dgvEstoqueApurado.Rows.Add(nrlinha.ToString(), estoqueApurado.CodBarrasApurado, produto, produto.ToString() != "" ? "Cód. Valido" : "Não Encontrado");
        }

        private void txtCodigoBarras_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SalvarCodigoDeBarras(this.Text);
            }
        }

        public void SalvarCodigoDeBarras(string text)
        {
            try
            {
                string produto = "";
                estoque = new Estoque();
                estoqueBLL = new EstoqueBLL();
                estoqueApurado = new EstoqueApurado();
                estoqueApuradoBLL = new EstoqueApuradoBLL();
                estoqueApurado.CodBarrasApurado = txtCodigoBarras.Text.Substring(0,12);

                estoqueApuradoBLL.IncluirCodigoBarras(estoqueApurado);
                estoque = estoqueBLL.ObterItemEstoquePorCodigoBarras(estoqueApurado.CodBarrasApurado);
                nrlinha = dgvEstoqueApurado.Rows.Count + 1;

                if (estoque != null)
                {
                    produto = estoque.NomeProduto;
                }

                dgvEstoqueApurado.Rows.Add(nrlinha.ToString(), estoqueApurado.CodBarrasApurado, produto, produto.ToString() != "" ? "Cód. Valido" : "Não Encontrado");
                dgvEstoqueApurado.Sort(dgvEstoqueApurado.Columns[0], System.ComponentModel.ListSortDirection.Descending);

                txtCodigoBarras.Text = "";
                txtCodigoBarras.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ocorreu um erro: " + ex.Message);
            }

            
        }

        private void ConfirmarExclusaoEstoqueApurado()
        {
            if (DialogResult.Yes == MessageBox.Show("Deseja reiniciar a conferencia do estoque apurado?", "Atenção!",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
            {
                //
                if (DialogResult.Yes == MessageBox.Show("Esse processo vai deletar todas os itens já cadastrados no estoque apurado, e não poderá ser revertido, confirma a exclusão?", "Atenção!",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2))
                {
                    //excluir todos os itens da tabela EstoqueApurado e mandar pra a tabela de log com a data atual
                    estoqueApuradoBLL = new EstoqueApuradoBLL();
                    estoqueApuradoBLL.ExcluirEstoqueApurado();
                    dgvEstoqueApurado.DataSource = estoqueApuradoBLL.ObterListaEstoqueApurado();
                }
            }
        }

        private void btnLimparBanco_Click(object sender, EventArgs e)
        {
            ConfirmarExclusaoEstoqueApurado();
        }
    }
}
