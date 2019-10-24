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
    public partial class frmCustoPorSubGrupo : Form
    {
        EstoqueBLL estoqueBLL;
        List<CustoPorSubGrupo> lstCustoPorSubGrupo;
        public frmCustoPorSubGrupo()
        {
            InitializeComponent();
        }

        private void frmCustoPorSubGrupo_Load(object sender, EventArgs e)
        {
            estoqueBLL = new EstoqueBLL();
            lstCustoPorSubGrupo = new List<CustoPorSubGrupo>();
            lstCustoPorSubGrupo = estoqueBLL.ObterListaCustoPorSubGrupo("").ToList();

            CarregaGrafico(lstCustoPorSubGrupo);

            CarregaListView(lstCustoPorSubGrupo);

            CarregaListGrupo(lstCustoPorSubGrupo);
        }

        private void CarregaListGrupo(List<CustoPorSubGrupo> lstCustoPorSubGrupo)
        {
            var grupos = lstCustoPorSubGrupo.GroupBy(p => p.Grupo).Select(x => x).ToList();

            foreach (var item in grupos)
            {
                cbGrupo.Items.Add(item.Key);
            }
        }

        public void CarregaListView(List<CustoPorSubGrupo> lstCustoPorSubGrupo)
        {
            Decimal TotalEstoque = 0;

            foreach (CustoPorSubGrupo p in lstCustoPorSubGrupo)
            {
                ListViewItem item = new ListViewItem(p.Grupo.ToString());
                item.SubItems.Add(p.SubGrupo.ToString());
                item.SubItems.Add(Convert.ToDecimal(p.CustoTotal).ToString());
                lsvCustoPorGrupo.Items.Add(item);
                TotalEstoque += Convert.ToDecimal(p.CustoTotal);
            }

            lblTotalEstoque.Text = TotalEstoque.ToString("C");
        }

        public void CarregaGrafico(List<CustoPorSubGrupo> lstCustoPorSubGrupo)
        {
            this.chaCustoPorGrupo.Palette = ChartColorPalette.BrightPastel;
            this.chaCustoPorGrupo.Titles.Add("Custo x Grupo");

            //FAZER UM FILTRO NO GRÁFICO, COLOCAR UM CAMPO DROPDOWNLIST COM OS GRUPOS E EXIBIR O 
            //GRAFICO OS SUBGRUPOS A PARTIR DO GRUPO ESCOLHIDO

            //for (int i = 0; i < lstCustoPorSubGrupo.Count; i++)
            //{
            //    Series series = this.chaCustoPorGrupo.Series.Add(lstCustoPorSubGrupo[i].Grupo);
            //    series.Points.Add(lstCustoPorSubGrupo[i].CustoTotal != null ? Convert.ToDouble(lstCustoPorSubGrupo[i].CustoTotal) : 0);
            //}
        }

        private void cbGrupo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string grupo = cbGrupo.SelectedItem.ToString();
            string sss = cbGrupo.SelectedIndex.ToString();
            CarregaFormulario(grupo);
        }

        private void CarregaFormulario(string grupo)
        {
            estoqueBLL = new EstoqueBLL();
            lstCustoPorSubGrupo = new List<CustoPorSubGrupo>();
            lstCustoPorSubGrupo = estoqueBLL.ObterListaCustoPorSubGrupo(grupo).ToList();

            CarregaGrafico(lstCustoPorSubGrupo);

            CarregaListView(lstCustoPorSubGrupo);

            CarregaListGrupo(lstCustoPorSubGrupo);
        }
    }
}
