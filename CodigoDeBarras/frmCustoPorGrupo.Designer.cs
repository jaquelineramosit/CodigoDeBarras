namespace CodigoDeBarras
{
    partial class frmCustoPorGrupo
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.selecGrupoPorCustoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sistemaLojaDataSet3 = new CodigoDeBarras.SistemaLojaDataSet3();
            this.selecGrupoPorCustoTableAdapter = new CodigoDeBarras.SistemaLojaDataSet3TableAdapters.SelecGrupoPorCustoTableAdapter();
            this.chaCustoPorGrupo = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lsvCustoPorGrupo = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotalEstoque = new System.Windows.Forms.Label();
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
            chartArea2.Name = "ChartArea1";
            this.chaCustoPorGrupo.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chaCustoPorGrupo.Legends.Add(legend2);
            this.chaCustoPorGrupo.Location = new System.Drawing.Point(438, 38);
            this.chaCustoPorGrupo.Name = "chaCustoPorGrupo";
            this.chaCustoPorGrupo.Size = new System.Drawing.Size(1319, 489);
            this.chaCustoPorGrupo.TabIndex = 3;
            this.chaCustoPorGrupo.Text = "chart1";
            this.chaCustoPorGrupo.Click += new System.EventHandler(this.chart1_Click);
            // 
            // lsvCustoPorGrupo
            // 
            this.lsvCustoPorGrupo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4});
            this.lsvCustoPorGrupo.GridLines = true;
            this.lsvCustoPorGrupo.Location = new System.Drawing.Point(12, 38);
            this.lsvCustoPorGrupo.Name = "lsvCustoPorGrupo";
            this.lsvCustoPorGrupo.Size = new System.Drawing.Size(410, 600);
            this.lsvCustoPorGrupo.TabIndex = 5;
            this.lsvCustoPorGrupo.UseCompatibleStateImageBehavior = false;
            this.lsvCustoPorGrupo.View = System.Windows.Forms.View.Details;
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
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 650);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 27);
            this.label1.TabIndex = 6;
            this.label1.Text = "Total Estoque: ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotalEstoque
            // 
            this.lblTotalEstoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalEstoque.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblTotalEstoque.Location = new System.Drawing.Point(163, 650);
            this.lblTotalEstoque.Name = "lblTotalEstoque";
            this.lblTotalEstoque.Size = new System.Drawing.Size(259, 27);
            this.lblTotalEstoque.TabIndex = 7;
            this.lblTotalEstoque.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmCustoPorGrupo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1769, 737);
            this.Controls.Add(this.lblTotalEstoque);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lsvCustoPorGrupo);
            this.Controls.Add(this.chaCustoPorGrupo);
            this.Name = "frmCustoPorGrupo";
            this.Text = "Custo x Grupo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmGrupoPorCusto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.selecGrupoPorCustoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaLojaDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chaCustoPorGrupo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private SistemaLojaDataSet3 sistemaLojaDataSet3;
        private System.Windows.Forms.BindingSource selecGrupoPorCustoBindingSource;
        private SistemaLojaDataSet3TableAdapters.SelecGrupoPorCustoTableAdapter selecGrupoPorCustoTableAdapter;
        private System.Windows.Forms.DataVisualization.Charting.Chart chaCustoPorGrupo;
        private System.Windows.Forms.ListView lsvCustoPorGrupo;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotalEstoque;
    }
}