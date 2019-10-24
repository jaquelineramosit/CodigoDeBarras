using CodigoDeBarras.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodigoDeBarras
{
    public partial class frmGerarEtiqueta : Form
    {
        static List<EstoqueImpressaoEtiqueta> lstEstoqueImpressaoEtiqueta;
        EstoqueImpressaoEtiqueta estoqueImpressaoEtiqueta;
        EstoqueImpressaoEtiquetaBLL estoqueImpressaoEtiquetaBLL;

        public frmGerarEtiqueta()
        {
            InitializeComponent();
        }

        private void frmGerarEtiqueta_Load(object sender, EventArgs e)
        {
            estoqueImpressaoEtiquetaBLL = new EstoqueImpressaoEtiquetaBLL();
            lstEstoqueImpressaoEtiqueta = new List<EstoqueImpressaoEtiqueta>();
            lstEstoqueImpressaoEtiqueta = estoqueImpressaoEtiquetaBLL.ObterListaEstoqueImpressaoEtiqueta();

            foreach (var item in lstEstoqueImpressaoEtiqueta)
            {
                PreencheDataGridView(item);
            }
        }

        private void txtCodigoBarras_KeyUp(object sender, KeyEventArgs e)
        {
            /// <summary>
            /// Autor: Jaqueline Silva
            /// Data: 30/03/2019
            /// Objetivo: Verifica se o código de barras informado é válido ou não.
            ///         Caso seja válido cria um item na lista de EstoqueImpressaoEtiqueta.
            ///         Caso não seja encontrado, exibe uma mensagem de erro e não deixa realizar a inclusão.
            /// </summary>

            if (e.KeyCode == Keys.Enter)
            {
                lstEstoqueImpressaoEtiqueta = new List<EstoqueImpressaoEtiqueta>();
                Estoque estoque = new Estoque();
                EstoqueBLL estoqueBLL = new EstoqueBLL();
                estoqueImpressaoEtiqueta = new EstoqueImpressaoEtiqueta();

                //Obtem as informações do Estoque a partir de um código de barras cadastrado.
                estoque.CodBarras = txtCodigoBarras.Text.Replace(" ", "");
                estoque = estoqueBLL.ObterItemEstoquePorCodigoBarras(estoque.CodBarras);
                if (estoque != null)
                {
                    lblNomeProdutoReal.Text = estoque.NomeProduto;
                    lblqtdereal.Text = estoque.EstoqueDisp.ToString();
                    txtQtdeCodBarras.Enabled = true;
                    txtQtdeCodBarras.Focus();
                    estoqueImpressaoEtiqueta = PopulaClasseEtiqueta(estoque);

                    if (estoqueImpressaoEtiqueta != null)
                    {
                        lstEstoqueImpressaoEtiqueta.Add(estoqueImpressaoEtiqueta);
                    }
                    else {
                        ConfiguraItemNaoEncontrado();
                    }
                    
                    AlterarCorLabel(Color.Navy);
                }
                else {
                    ConfiguraItemNaoEncontrado();
                }
            }
        }

        private void txtQtdeCodBarras_KeyUp(object sender, KeyEventArgs e)
        {
            /// <summary>
            /// Autor: Jaqueline Silva
            /// Data: 30/03/2019
            /// Objetivo: Insere um item na tabela EstoqueImpressaoEtiqueta.
            /// </summary>
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    estoqueImpressaoEtiquetaBLL = new EstoqueImpressaoEtiquetaBLL();
                    int numeroLinha = lstEstoqueImpressaoEtiqueta.Count;

                    lstEstoqueImpressaoEtiqueta[numeroLinha - 1].EstoqueDisp = Convert.ToInt32(txtQtdeCodBarras.Text);

                    estoqueImpressaoEtiquetaBLL.IncluirImpressoaEtiqueta(lstEstoqueImpressaoEtiqueta[numeroLinha - 1]);

                    PreencheDataGridView(lstEstoqueImpressaoEtiqueta[numeroLinha - 1]);

                    txtCodigoBarras.Text = "";
                    txtQtdeCodBarras.Text = "";
                    txtCodigoBarras.Focus();
                    lblNomeProdutoReal.Text = "";
                    lblqtdereal.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro ao salvar a etiqueta. Erro: " + ex.Message);
                }
            }
        }

        private void btnExcluirEtiquetas_Click(object sender, EventArgs e)
        {
            ConfirmarExclusaoEstoqueApurado();
        }

        private void txtCodigoBarras_KeyPress(object sender, KeyPressEventArgs e)
        {
            /// <summary>
            /// Autor: Jaqueline Silva
            /// Data: 30/03/2019
            /// Objetivo: Bloqueia a inserção de caracteres diferentes de números.
            /// </summary>
            
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void PreencheDataGridView(EstoqueImpressaoEtiqueta estoqueImpressaoEtiqueta)
        {
            dgvEtiquetas.Rows.Add(
                        estoqueImpressaoEtiqueta.idCodigo,
                        estoqueImpressaoEtiqueta.CodigoBarras,
                        estoqueImpressaoEtiqueta.NomeProduto,
                        estoqueImpressaoEtiqueta.Grupo,
                        estoqueImpressaoEtiqueta.NumeroFab,
                        estoqueImpressaoEtiqueta.EstoqueDisp,
                        estoqueImpressaoEtiqueta.Venda,
                        estoqueImpressaoEtiqueta.Fornecedor
                        );
        }

        private void AlterarCorLabel(Color color)
        {
            lblNomeProdutoReal.ForeColor = color;
        }

        private void ConfiguraItemNaoEncontrado()
        {
            txtQtdeCodBarras.Enabled = false;
            txtCodigoBarras.Focus();
            lblNomeProdutoReal.Text = "Item não encontrado!";
            AlterarCorLabel(Color.Red);
        }

        private EstoqueImpressaoEtiqueta PopulaClasseEtiqueta(Estoque estoque)
        {
            try
            {
                estoqueImpressaoEtiqueta = new EstoqueImpressaoEtiqueta();
                estoqueImpressaoEtiqueta.idCodigo = estoque.IdCodigo;
                estoqueImpressaoEtiqueta.CodigoBarras = estoque.CodBarras;
                estoqueImpressaoEtiqueta.NomeProduto = estoque.NomeProduto;
                estoqueImpressaoEtiqueta.Grupo = estoque.Grupo;
                estoqueImpressaoEtiqueta.NumeroFab = estoque.NumeroFab;
                estoqueImpressaoEtiqueta.EstoqueDisp = estoque.EstoqueDisp;
                estoqueImpressaoEtiqueta.Venda = estoque.Venda;
                estoqueImpressaoEtiqueta.Fornecedor = estoque.Fornecedor;
                return estoqueImpressaoEtiqueta;
            }
            catch (Exception)
            {
                return null;
            }

        }

        private void ConfirmarExclusaoEstoqueApurado()
        {
            if (DialogResult.Yes == MessageBox.Show("Deseja escluir todas as etiquetas incluídas na lista abaixo?", "Atenção!",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
            {
                //
                if (DialogResult.Yes == MessageBox.Show("Esse processo vai deletar todas as etiquetas, e não poderá ser revertido, confirma a exclusão?", "Atenção!",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2))
                {
                    //excluir todos os itens da tabela EstoqueApurado e mandar pra a tabela de log com a data atual
                    estoqueImpressaoEtiquetaBLL = new EstoqueImpressaoEtiquetaBLL();
                    estoqueImpressaoEtiquetaBLL.ExcluirImpressaoEtiqueta();
                    dgvEtiquetas.DataSource = estoqueImpressaoEtiquetaBLL.ObterListaEstoqueImpressaoEtiqueta();

                    MessageBox.Show("Etiquetas excluídas com sucesso!");
                }
            }
        }

        private void btnImprimeEtiquetas_Click(object sender, EventArgs e)
        {
            PopupImpressao novoPopup = new PopupImpressao();
            novoPopup.Show();
        }
    }
}
