using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using CodigoDeBarras.BLL;

namespace CodigoDeBarras
{
    public partial class frmEstoqueApurado : Form
    {
        //Estoque estoque;
        EstoqueApurado estoqueApurado;
        EstoqueApuradoBLL estoqueApuradoBLL;
        List<EstoqueApurado> lstEstoque = new List<EstoqueApurado>();
        List<EstoqueApurado> lstEstoqueApurado = new List<EstoqueApurado>();
        
        public frmEstoqueApurado()
        {
            InitializeComponent();
            EstoqueApuradoBLL estoqueApuradoBLL = new EstoqueApuradoBLL();
            dgvEstoqueApurado.DataSource = estoqueApuradoBLL.ObterListaEstoqueApurado();
        }

        #region "Eventos"

        private void btnInsere_Click(object sender, EventArgs e)
        {
            InsereCodigoBarras();

            txtCodigoBarras.Text = "";
            txtQtde.Text = "";

        }

        private void frmEstoqueApurado_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'sistemaLojaDataSet.EstoqueApurado'. Você pode movê-la ou removê-la conforme necessário.
            this.estoqueApuradoTableAdapter.Fill(this.sistemaLojaDataSet.EstoqueApurado);
            //ConfirmarExclusaoEstoqueApurado();
        }

        private void txtCodigoBarras_Leave(object sender, EventArgs e)
        {
            //MessageBox.Show(txtCodigoBarras.Text);
            EstoqueBLL estoqueBLL = new EstoqueBLL();
            Estoque estoque = new Estoque();

            string codigoBarras = txtCodigoBarras.Text;

            if (codigoBarras.Length > 12)
            {
                //--------------------------------------------------------
                txtCodigoBarras.Text = txtCodigoBarras.Text.Substring(0,12);
                codigoBarras = txtCodigoBarras.Text;
                //--------------------------------------------------------
            }

            //471933130328

            estoque = estoqueBLL.ObterItemEstoquePorCodigoBarras(codigoBarras);
            if (estoque != null)
            {
                lblNomeProdutoReal.Text = estoque.NomeProduto;
                lblqtdereal.Text = estoque.EstoqueDisp.ToString();
                AlterarCorLabel(Color.Navy);
            }
            else {
                lblNomeProdutoReal.Text = "Item não encontrado!";
                lblqtdereal.Text = "";
                AlterarCorLabel(Color.Red);
            }
        }

        private void btnConferir_Click(object sender, EventArgs e)
        {
            frmEstoqueConferir novofrmEstoqueConferir = new frmEstoqueConferir();
            novofrmEstoqueConferir.Show();
            //Application.Run(new frmEstoqueConferir(1));
        }

        private void txtCodigoBarras_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnLimparBanco_Click(object sender, EventArgs e)
        {
            ConfirmarExclusaoEstoqueApurado();
        }

        private void dgvEstoqueApurado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Deseja excluir este item do Estoque Apurado, este procedimento não poderá ser revertido, confirma a exclusão deste item?", "Atenção!",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2))
            {
                int idEstoqueApurado = Convert.ToInt32(dgvEstoqueApurado["idEstoqueApurado", e.RowIndex].Value);
                estoqueApurado = new EstoqueApurado();
                estoqueApuradoBLL = new EstoqueApuradoBLL();
                estoqueApurado = estoqueApuradoBLL.ObterListaEstoqueId(idEstoqueApurado);

                //excluir todos os itens da tabela EstoqueApurado e mandar pra a tabela de log com a data atual
                estoqueApuradoBLL = new EstoqueApuradoBLL();
                estoqueApuradoBLL.ExcluirEstoqueApuradoId(estoqueApurado);

                dgvEstoqueApurado.DataSource = estoqueApuradoBLL.ObterListaEstoqueApurado().ToList();
            }
        }

        #endregion

        #region "Metodos"

        public void AlterarCorLabel(Color color)
        {
            lblNomeProdutoReal.ForeColor = color;
        }

        public void InsereCodigoBarras()
        {

            //gravar em banco de dados
            //primeiro fazer o upload do banco de estoque em excel
            //depois incluir os códigos de barras + qtde
            estoqueApuradoBLL = new EstoqueApuradoBLL();
            estoqueApurado = new EstoqueApurado();

            if (txtCodigoBarras.Text == "")
            {
                MessageBox.Show("Informe o código de Barras!", "", MessageBoxButtons.OK);
            }
            else
            {
                //estoqueApurado.CodBarrasApurado = txtCodigoBarras.Text;
                if (txtCodigoBarras.Text.Length > 12)
                {
                    //--------------------------------------------------------
                    estoqueApurado.CodBarrasApurado = txtCodigoBarras.Text;
                    string teste = txtCodigoBarras.Text.Substring(1, 12);

                    //--------------------------------------------------------
                }
                else
                {
                    estoqueApurado.CodBarrasApurado = txtCodigoBarras.Text;
                }
            }

            if (txtQtde.Text == "")
            {
                MessageBox.Show("Informe a Quantidade!", "", MessageBoxButtons.OK);
                //return false;
            }
            else
            {
                estoqueApurado.EstoqueDispApurado = Convert.ToInt32(txtQtde.Text);
            }

            lstEstoqueApurado.Add(estoqueApurado);


            estoqueApuradoBLL.IncluirCodigoBarras(estoqueApurado);

            txtCodigoBarras.Focus();


            dgvEstoqueApurado.DataSource = estoqueApuradoBLL.ObterListaEstoqueApurado();
            //dgvEstoqueReal.DataSource = lstEstoqueApurado.ToList();


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

        #endregion









        

        #region "Em Standy By"
        //public bool VerificarCodigoBarras()
        //{
        //    if (txtCodigoBarras.Text != "")
        //    {
        //    }
        //    //String.Join("", System.Text.RegularExpressions.Regex.Split(stringAqui, @"[^\d]"))
        //    return false;
        //}
        #endregion
    }
}
