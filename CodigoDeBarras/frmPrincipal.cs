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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void importarEstoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Application.Run(new frmEstoqueSistema());
            frmEstoqueSistema novofrmEstoqueSistema = new frmEstoqueSistema();
            novofrmEstoqueSistema.Show();
        }

        private void estoqueApuradoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Application.Run(new frmEstoqueApurado());
            frmEstoqueApuradoSimples novofrmEstoqueApuradoSimples = new frmEstoqueApuradoSimples();
            novofrmEstoqueApuradoSimples.Show();
            
        }

        private void conferirEstoqueToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //Application.Run(new frmEstoqueConferir());
            frmEstoqueConferir novofrmEstoqueConferir = new frmEstoqueConferir();
            novofrmEstoqueConferir.Show();
        }

        private void gerarEtiquetasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGerarEtiqueta novofrmGerarEtiqueta = new frmGerarEtiqueta();
            novofrmGerarEtiqueta.Show();
        }

        private void custoXGrupoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCustoPorGrupo novofrmCustoPorGrupo = new frmCustoPorGrupo();
            novofrmCustoPorGrupo.Show();
        }

        private void custoXSubGrupoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCustoPorSubGrupo novofrmCustoPorSubGrupo = new frmCustoPorSubGrupo();
            novofrmCustoPorSubGrupo.Show();
        }
    }
}
