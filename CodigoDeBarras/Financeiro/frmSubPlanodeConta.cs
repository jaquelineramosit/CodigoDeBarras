using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodigoDeBarras.Financeiro
{
    public partial class frmSubPlanodeConta : Form
    {
        TipoConta tipoConta;
        Conta conta;
        public frmSubPlanodeConta()
        {
            InitializeComponent();
        }

        private void frmSubPlanodeConta_Load(object sender, EventArgs e)
        {

        }

        public void PopularCombo()
        {
            tipoConta = new TipoConta();
            conta = new Conta();
        }
    }
}
