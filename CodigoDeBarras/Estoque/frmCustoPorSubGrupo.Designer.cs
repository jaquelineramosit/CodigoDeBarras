namespace CodigoDeBarras
{
    partial class frmCustoPorSubGrupo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCustoPorSubGrupo));
            this.selecGrupoPorCustoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sistemaLojaDataSet3 = new CodigoDeBarras.SistemaLojaDataSet3();
            this.selecGrupoPorCustoTableAdapter = new CodigoDeBarras.SistemaLojaDataSet3TableAdapters.SelecGrupoPorCustoTableAdapter();
            this.chaCustoPorGrupo = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblTotalEstoque = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lsvCustoPorGrupo = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblcodBarras = new System.Windows.Forms.Label();
            this.cbGrupo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.selecGrupoPorCustoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaLojaDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chaCustoPorGrupo)).BeginInit();
            this.SuspendLayout();
            // 
            // selecGrupoPorCustoBindingSource
            // 
            this.selecGrupoPorCustoBindingSource.DataMember = "SelecGrupoPorCusto";
            this.selecGrupoPorCustoBindingSource.DataSource = this.sistemaLojaDataSet3;
            // 
            // sistemaLojaDataSet3
            // 
            this.sistemaLojaDataSet3.DataSetName = "SistemaLojaDataSet3";
            this.sistemaLojaDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // selecGrupoPorCustoTableAdapter
            // 
            this.selecGrupoPorCustoTableAdapter.ClearBeforeFill = true;
            // 
            // chaCustoPorGrupo
            // 
            chartArea1.Name = "ChartArea1";
            this.chaCustoPorGrupo.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chaCustoPorGrupo.Legends.Add(legend1);
            this.chaCustoPorGrupo.Location = new System.Drawing.Point(433, 84);
            this.chaCustoPorGrupo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chaCustoPorGrupo.Name = "chaCustoPorGrupo";
            this.chaCustoPorGrupo.Size = new System.Drawing.Size(874, 397);
            this.chaCustoPorGrupo.TabIndex = 8;
            this.chaCustoPorGrupo.Text = "chart1";
            // 
            // lblTotalEstoque
            // 
            this.lblTotalEstoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalEstoque.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblTotalEstoque.Location = new System.Drawing.Point(122, 510);
            this.lblTotalEstoque.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalEstoque.Name = "lblTotalEstoque";
            this.lblTotalEstoque.Size = new System.Drawing.Size(194, 22);
            this.lblTotalEstoque.TabIndex = 11;
            this.lblTotalEstoque.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 510);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 22);
            this.label1.TabIndex = 10;
            this.label1.Text = "Total Estoque: ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Grupo";
            this.columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Custo Total";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader4.Width = 100;
            // 
            // lsvCustoPorGrupo
            // 
            this.lsvCustoPorGrupo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader1,
            this.columnHeader4});
            this.lsvCustoPorGrupo.GridLines = true;
            this.lsvCustoPorGrupo.Location = new System.Drawing.Point(9, 84);
            this.lsvCustoPorGrupo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lsvCustoPorGrupo.Name = "lsvCustoPorGrupo";
            this.lsvCustoPorGrupo.Size = new System.Drawing.Size(414, 435);
            this.lsvCustoPorGrupo.TabIndex = 9;
            this.lsvCustoPorGrupo.UseCompatibleStateImageBehavior = false;
            this.lsvCustoPorGrupo.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Sub Grupo";
            this.columnHeader1.Width = 200;
            // 
            // lblcodBarras
            // 
            this.lblcodBarras.AutoSize = true;
            this.lblcodBarras.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcodBarras.Location = new System.Drawing.Point(10, 28);
            this.lblcodBarras.Name = "lblcodBarras";
            this.lblcodBarras.Size = new System.Drawing.Size(50, 15);
            this.lblcodBarras.TabIndex = 12;
            this.lblcodBarras.Text = "Grupo:";
            // 
            // cbGrupo
            // 
            this.cbGrupo.FormattingEnabled = true;
            this.cbGrupo.Location = new System.Drawing.Point(60, 23);
            this.cbGrupo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbGrupo.Name = "cbGrupo";
            this.cbGrupo.Size = new System.Drawing.Size(350, 21);
            this.cbGrupo.TabIndex = 14;
            this.cbGrupo.SelectedIndexChanged += new System.EventHandler(this.cbGrupo_SelectedIndexChanged);
            // 
            // frmCustoPorSubGrupo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1327, 599);
            this.Controls.Add(this.cbGrupo);
            this.Controls.Add(this.lblcodBarras);
            this.Controls.Add(this.lsvCustoPorGrupo);
            this.Controls.Add(this.chaCustoPorGrupo);
            this.Controls.Add(this.lblTotalEstoque);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmCustoPorSubGrupo";
            this.Text = "frmCustoPorSubGrupo";
            this.Load += new System.EventHandler(this.frmCustoPorSubGrupo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.selecGrupoPorCustoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaLojaDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chaCustoPorGrupo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource selecGrupoPorCustoBindingSource;
        private SistemaLojaDataSet3 sistemaLojaDataSet3;
        private SistemaLojaDataSet3TableAdapters.SelecGrupoPorCustoTableAdapter selecGrupoPorCustoTableAdapter;
        private System.Windows.Forms.DataVisualization.Charting.Chart chaCustoPorGrupo;
        private System.Windows.Forms.Label lblTotalEstoque;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ListView lsvCustoPorGrupo;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Label lblcodBarras;
        private System.Windows.Forms.ComboBox cbGrupo;
    }
}