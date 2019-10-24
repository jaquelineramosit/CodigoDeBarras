namespace CodigoDeBarras
{
    partial class frmEstoqueConferir
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
            this.gbConferirEstoque = new System.Windows.Forms.GroupBox();
            this.btnExportarExcel = new System.Windows.Forms.Button();
            this.lblQtdeRegConferir = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConferir = new System.Windows.Forms.Button();
            this.dgvConferir = new System.Windows.Forms.DataGridView();
            this.idEstoqueDivergenteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idEstoqueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codBarrasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeProdutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroFabDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estoqueDispDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estoqueDispApuradoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataInclusaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estoqueDivergenteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sistemaLojaDataSet1 = new CodigoDeBarras.SistemaLojaDataSet1();
            this.sistemaLojaDataSet = new CodigoDeBarras.SistemaLojaDataSet();
            this.sistemaLojaDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.estoqueDivergenteTableAdapter = new CodigoDeBarras.SistemaLojaDataSet1TableAdapters.EstoqueDivergenteTableAdapter();
            this.gbConferirEstoque.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConferir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estoqueDivergenteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaLojaDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaLojaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaLojaDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gbConferirEstoque
            // 
            this.gbConferirEstoque.Controls.Add(this.btnExportarExcel);
            this.gbConferirEstoque.Controls.Add(this.lblQtdeRegConferir);
            this.gbConferirEstoque.Controls.Add(this.label1);
            this.gbConferirEstoque.Controls.Add(this.btnConferir);
            this.gbConferirEstoque.Controls.Add(this.dgvConferir);
            this.gbConferirEstoque.Location = new System.Drawing.Point(13, 38);
            this.gbConferirEstoque.Margin = new System.Windows.Forms.Padding(4);
            this.gbConferirEstoque.Name = "gbConferirEstoque";
            this.gbConferirEstoque.Padding = new System.Windows.Forms.Padding(4);
            this.gbConferirEstoque.Size = new System.Drawing.Size(1174, 484);
            this.gbConferirEstoque.TabIndex = 14;
            this.gbConferirEstoque.TabStop = false;
            this.gbConferirEstoque.Text = "Conferir Estoque";
            // 
            // btnExportarExcel
            // 
            this.btnExportarExcel.Location = new System.Drawing.Point(952, 26);
            this.btnExportarExcel.Margin = new System.Windows.Forms.Padding(4);
            this.btnExportarExcel.Name = "btnExportarExcel";
            this.btnExportarExcel.Size = new System.Drawing.Size(214, 46);
            this.btnExportarExcel.TabIndex = 13;
            this.btnExportarExcel.Text = "Exportar Excel";
            this.btnExportarExcel.UseVisualStyleBackColor = true;
            this.btnExportarExcel.Click += new System.EventHandler(this.btnExportarExcel_Click);
            // 
            // lblQtdeRegConferir
            // 
            this.lblQtdeRegConferir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtdeRegConferir.Location = new System.Drawing.Point(1069, 446);
            this.lblQtdeRegConferir.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQtdeRegConferir.Name = "lblQtdeRegConferir";
            this.lblQtdeRegConferir.Size = new System.Drawing.Size(97, 23);
            this.lblQtdeRegConferir.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(949, 446);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 23);
            this.label1.TabIndex = 12;
            this.label1.Text = "Qtde Registros:";
            // 
            // btnConferir
            // 
            this.btnConferir.Location = new System.Drawing.Point(13, 26);
            this.btnConferir.Margin = new System.Windows.Forms.Padding(4);
            this.btnConferir.Name = "btnConferir";
            this.btnConferir.Size = new System.Drawing.Size(176, 46);
            this.btnConferir.TabIndex = 12;
            this.btnConferir.Text = "Conferir";
            this.btnConferir.UseVisualStyleBackColor = true;
            this.btnConferir.Click += new System.EventHandler(this.btnConferir_Click);
            // 
            // dgvConferir
            // 
            this.dgvConferir.AllowUserToAddRows = false;
            this.dgvConferir.AllowUserToDeleteRows = false;
            this.dgvConferir.AllowUserToOrderColumns = true;
            this.dgvConferir.AutoGenerateColumns = false;
            this.dgvConferir.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idEstoqueDivergenteDataGridViewTextBoxColumn,
            this.idEstoqueDataGridViewTextBoxColumn,
            this.codBarrasDataGridViewTextBoxColumn,
            this.nomeProdutoDataGridViewTextBoxColumn,
            this.numeroFabDataGridViewTextBoxColumn,
            this.estoqueDispDataGridViewTextBoxColumn,
            this.estoqueDispApuradoDataGridViewTextBoxColumn,
            this.dataInclusaoDataGridViewTextBoxColumn});
            this.dgvConferir.DataSource = this.estoqueDivergenteBindingSource;
            this.dgvConferir.Location = new System.Drawing.Point(13, 91);
            this.dgvConferir.Margin = new System.Windows.Forms.Padding(4);
            this.dgvConferir.Name = "dgvConferir";
            this.dgvConferir.ReadOnly = true;
            this.dgvConferir.Size = new System.Drawing.Size(1153, 342);
            this.dgvConferir.TabIndex = 12;
            // 
            // idEstoqueDivergenteDataGridViewTextBoxColumn
            // 
            this.idEstoqueDivergenteDataGridViewTextBoxColumn.DataPropertyName = "IdEstoqueDivergente";
            this.idEstoqueDivergenteDataGridViewTextBoxColumn.HeaderText = "IdEstoqueDivergente";
            this.idEstoqueDivergenteDataGridViewTextBoxColumn.Name = "idEstoqueDivergenteDataGridViewTextBoxColumn";
            this.idEstoqueDivergenteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idEstoqueDataGridViewTextBoxColumn
            // 
            this.idEstoqueDataGridViewTextBoxColumn.DataPropertyName = "IdEstoque";
            this.idEstoqueDataGridViewTextBoxColumn.HeaderText = "IdEstoque";
            this.idEstoqueDataGridViewTextBoxColumn.Name = "idEstoqueDataGridViewTextBoxColumn";
            this.idEstoqueDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // codBarrasDataGridViewTextBoxColumn
            // 
            this.codBarrasDataGridViewTextBoxColumn.DataPropertyName = "CodBarras";
            this.codBarrasDataGridViewTextBoxColumn.HeaderText = "CodBarras";
            this.codBarrasDataGridViewTextBoxColumn.Name = "codBarrasDataGridViewTextBoxColumn";
            this.codBarrasDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeProdutoDataGridViewTextBoxColumn
            // 
            this.nomeProdutoDataGridViewTextBoxColumn.DataPropertyName = "NomeProduto";
            this.nomeProdutoDataGridViewTextBoxColumn.HeaderText = "NomeProduto";
            this.nomeProdutoDataGridViewTextBoxColumn.Name = "nomeProdutoDataGridViewTextBoxColumn";
            this.nomeProdutoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numeroFabDataGridViewTextBoxColumn
            // 
            this.numeroFabDataGridViewTextBoxColumn.DataPropertyName = "NumeroFab";
            this.numeroFabDataGridViewTextBoxColumn.HeaderText = "NumeroFab";
            this.numeroFabDataGridViewTextBoxColumn.Name = "numeroFabDataGridViewTextBoxColumn";
            this.numeroFabDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // estoqueDispDataGridViewTextBoxColumn
            // 
            this.estoqueDispDataGridViewTextBoxColumn.DataPropertyName = "EstoqueDisp";
            this.estoqueDispDataGridViewTextBoxColumn.HeaderText = "EstoqueDisp";
            this.estoqueDispDataGridViewTextBoxColumn.Name = "estoqueDispDataGridViewTextBoxColumn";
            this.estoqueDispDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // estoqueDispApuradoDataGridViewTextBoxColumn
            // 
            this.estoqueDispApuradoDataGridViewTextBoxColumn.DataPropertyName = "EstoqueDispApurado";
            this.estoqueDispApuradoDataGridViewTextBoxColumn.HeaderText = "EstoqueDispApurado";
            this.estoqueDispApuradoDataGridViewTextBoxColumn.Name = "estoqueDispApuradoDataGridViewTextBoxColumn";
            this.estoqueDispApuradoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataInclusaoDataGridViewTextBoxColumn
            // 
            this.dataInclusaoDataGridViewTextBoxColumn.DataPropertyName = "DataInclusao";
            this.dataInclusaoDataGridViewTextBoxColumn.HeaderText = "DataInclusao";
            this.dataInclusaoDataGridViewTextBoxColumn.Name = "dataInclusaoDataGridViewTextBoxColumn";
            this.dataInclusaoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // estoqueDivergenteBindingSource
            // 
            this.estoqueDivergenteBindingSource.DataMember = "EstoqueDivergente";
            this.estoqueDivergenteBindingSource.DataSource = this.sistemaLojaDataSet1;
            // 
            // sistemaLojaDataSet1
            // 
            this.sistemaLojaDataSet1.DataSetName = "SistemaLojaDataSet1";
            this.sistemaLojaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sistemaLojaDataSet
            // 
            this.sistemaLojaDataSet.DataSetName = "SistemaLojaDataSet";
            this.sistemaLojaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sistemaLojaDataSetBindingSource
            // 
            this.sistemaLojaDataSetBindingSource.DataSource = this.sistemaLojaDataSet;
            this.sistemaLojaDataSetBindingSource.Position = 0;
            // 
            // estoqueDivergenteTableAdapter
            // 
            this.estoqueDivergenteTableAdapter.ClearBeforeFill = true;
            // 
            // frmEstoqueConferir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 543);
            this.Controls.Add(this.gbConferirEstoque);
            this.Name = "frmEstoqueConferir";
            this.Text = "frmEstoqueConferir";
            this.Load += new System.EventHandler(this.frmEstoqueConferir_Load);
            this.gbConferirEstoque.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConferir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estoqueDivergenteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaLojaDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaLojaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaLojaDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbConferirEstoque;
        private System.Windows.Forms.Label lblQtdeRegConferir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConferir;
        private System.Windows.Forms.DataGridView dgvConferir;
        private System.Windows.Forms.BindingSource sistemaLojaDataSetBindingSource;
        private SistemaLojaDataSet sistemaLojaDataSet;
        private SistemaLojaDataSet1 sistemaLojaDataSet1;
        private System.Windows.Forms.BindingSource estoqueDivergenteBindingSource;
        private SistemaLojaDataSet1TableAdapters.EstoqueDivergenteTableAdapter estoqueDivergenteTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEstoqueDivergenteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEstoqueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codBarrasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeProdutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroFabDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estoqueDispDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estoqueDispApuradoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataInclusaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnExportarExcel;
    }
}