using CodigoDeBarras.BLL;
using CodigoDeBarras.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace CodigoDeBarras
{
    public partial class frmCustoPorGrupo : Form
    {
        EstoqueBLL estoqueBLL;
        public frmCustoPorGrupo()
        {
            InitializeComponent();
        }

        private void frmGrupoPorCusto_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'sistemaLojaDataSet3.SelecGrupoPorCusto'. Você pode movê-la ou removê-la conforme necessário.
            this.selecGrupoPorCustoTableAdapter.Fill(this.sistemaLojaDataSet3.SelecGrupoPorCusto);

            estoqueBLL = new EstoqueBLL();
            List<CustoPorGrupo> lstCustoPorGrupo = new List<CustoPorGrupo>();
            lstCustoPorGrupo = estoqueBLL.ObterListaCustoPorGrupo().ToList();

            CarregaGrafico(lstCustoPorGrupo);

            CarregaListView(lstCustoPorGrupo);

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        public void CarregaListView(List<CustoPorGrupo> lstCustoPorGrupo)
        {
            Decimal TotalEstoque = 0;

            foreach (CustoPorGrupo p in lstCustoPorGrupo)
            {
                ListViewItem item = new ListViewItem(p.Grupo.ToString());
                item.SubItems.Add(Convert.ToDecimal(p.CustoTotal).ToString());
                lsvCustoPorGrupo.Items.Add(item);
                TotalEstoque += Convert.ToDecimal(p.CustoTotal);
            }

            lblTotalEstoque.Text = TotalEstoque.ToString("C");
        }

        public void CarregaGrafico(List<CustoPorGrupo> lstCustoPorGrupo)
        {
            this.chaCustoPorGrupo.Palette = ChartColorPalette.BrightPastel;
            this.chaCustoPorGrupo.Titles.Add("Custo x Grupo");

            for (int i = 0; i<lstCustoPorGrupo.Count; i++)
            {
                Series series = this.chaCustoPorGrupo.Series.Add(lstCustoPorGrupo[i].Grupo);
                series.Points.Add(lstCustoPorGrupo[i].CustoTotal != null ? Convert.ToDouble(lstCustoPorGrupo[i].CustoTotal) : 0);
            }
        }
    }
}
