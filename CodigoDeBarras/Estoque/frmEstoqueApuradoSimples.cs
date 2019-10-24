using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CodigoDeBarras.BLL;
using CodigoDeBarras.Entity;

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
            List<EstoqueApuradoEntity> lstEstoqueApuradoEntity = new List<EstoqueApuradoEntity>();
            estoqueApuradoBLL = new EstoqueApuradoBLL();
            lstEstoqueApuradoEntity = estoqueApuradoBLL.ObterListaEstoqueApuradoSelec();

            if (lstEstoqueApuradoEntity.Count != 0)
            {
                foreach (var item in lstEstoqueApuradoEntity)
                {
                    dgvEstoqueApurado.Rows.Add(item.Id, item.CodBarrasApurado, item.NomeProduto, item.codEncontrado);
                }
            }
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
                EstoqueApuradoEntity estoqueApuradoEntity = new EstoqueApuradoEntity();
                estoque = new Estoque();
                estoqueBLL = new EstoqueBLL();
                estoqueApurado = new EstoqueApurado();
                estoqueApuradoBLL = new EstoqueApuradoBLL();
                estoqueApurado.CodBarrasApurado = txtCodigoBarras.Text.Trim().Length < 12 ? txtCodigoBarras.Text : txtCodigoBarras.Text.Substring(0,12);
                estoqueApurado.EstoqueDispApurado = 1;

                estoqueApurado = estoqueApuradoBLL.IncluirCodigoBarras(estoqueApurado);
                
                CarregaGridEstoqueApuradoPorId(estoqueApurado.IdEstoqueApurado);

                txtCodigoBarras.Text = "";
                txtCodigoBarras.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ocorreu um erro: " + ex.Message);
            }

            
        }

        private void CarregaGridEstoqueApuradoPorId(int idEstoqueApurado)
        {
            EstoqueApuradoEntity estoqueApuradoEntity = new EstoqueApuradoEntity();
            estoqueApuradoEntity = estoqueApuradoBLL.ObterListaEstoqueApuradoPorId(estoqueApurado.IdEstoqueApurado);
            dgvEstoqueApurado.Rows.Add(estoqueApuradoEntity.Id, estoqueApuradoEntity.CodBarrasApurado, estoqueApuradoEntity.NomeProduto, estoqueApuradoEntity.codEncontrado);
            dgvEstoqueApurado.Sort(dgvEstoqueApurado.Columns[0], System.ComponentModel.ListSortDirection.Descending);
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
                    MessageBox.Show("Dados excluídos com sucesso!");
                    dgvEstoqueApurado.Rows.Clear();
                    CarregaGridEstoqueApurado();
                }
            }
        }

        private void btnLimparBanco_Click(object sender, EventArgs e)
        {
            ConfirmarExclusaoEstoqueApurado();
        }
    }
}
