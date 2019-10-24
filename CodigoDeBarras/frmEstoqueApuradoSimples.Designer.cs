namespace CodigoDeBarras
{
    partial class frmEstoqueApuradoSimples
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
            this.lblcodBarras = new System.Windows.Forms.Label();
            this.txtCodigoBarras = new System.Windows.Forms.TextBox();
            this.lblqtdereal = new System.Windows.Forms.Label();
            this.lblNomeProdutoReal = new System.Windows.Forms.Label();
            this.dgvEstoqueApurado = new System.Windows.Forms.DataGridView();
            this.btnLimparBanco = new System.Windows.Forms.Button();
            this.sistemaLojaDataSet3 = new CodigoDeBarras.SistemaLojaDataSet3();
            this.estoqueApuradoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.estoqueApuradoTableAdapter = new CodigoDeBarras.SistemaLojaDataSet3TableAdapters.EstoqueApuradoTableAdapter();
            this.IdEstoqueApurado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodBarras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodValido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstoqueApurado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaLojaDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estoqueApuradoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblcodBarras
            // 
            this.lblcodBarras.AutoSize = true;
            this.lblcodBarras.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcodBarras.Location = new System.Drawing.Point(13, 36);
            this.lblcodBarras.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblcodBarras.Name = "lblcodBarras";
            this.lblcodBarras.Size = new System.Drawing.Size(99, 18);
            this.lblcodBarras.TabIndex = 6;
            this.lblcodBarras.Text = "Cód. Barras";
            // 
            // txtCodigoBarras
            // 
            this.txtCodigoBarras.Location = new System.Drawing.Point(13, 58);
            this.txtCodigoBarras.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigoBarras.MaxLength = 13;
            this.txtCodigoBarras.Name = "txtCodigoBarras";
            this.txtCodigoBarras.Size = new System.Drawing.Size(257, 22);
            this.txtCodigoBarras.TabIndex = 5;
            this.txtCodigoBarras.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCodigoBarras_KeyUp);
            // 
            // lblqtdereal
            // 
            this.lblqtdereal.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblqtdereal.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblqtdereal.ForeColor = System.Drawing.Color.Navy;
            this.lblqtdereal.Location = new System.Drawing.Point(468, 94);
            this.lblqtdereal.Name = "lblqtdereal";
            this.lblqtdereal.Size = new System.Drawing.Size(144, 26);
            this.lblqtdereal.TabIndex = 10;
            // 
            // lblNomeProdutoReal
            // 
            this.lblNomeProdutoReal.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblNomeProdutoReal.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeProdutoReal.ForeColor = System.Drawing.Color.Navy;
            this.lblNomeProdutoReal.Location = new System.Drawing.Point(14, 94);
            this.lblNomeProdutoReal.Name = "lblNomeProdutoReal";
            this.lblNomeProdutoReal.Size = new System.Drawing.Size(426, 26);
            this.lblNomeProdutoReal.TabIndex = 9;
            // 
            // dgvEstoqueApurado
            // 
            this.dgvEstoqueApurado.AllowUserToAddRows = false;
            this.dgvEstoqueApurado.AllowUserToDeleteRows = false;
            this.dgvEstoqueApurado.AllowUserToOrderColumns = true;
            this.dgvEstoqueApurado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstoqueApurado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdEstoqueApurado,
            this.CodBarras,
            this.NomeProduto,
            this.CodValido});
            this.dgvEstoqueApurado.Location = new System.Drawing.Point(13, 145);
            this.dgvEstoqueApurado.Margin = new System.Windows.Forms.Padding(4);
            this.dgvEstoqueApurado.Name = "dgvEstoqueApurado";
            this.dgvEstoqueApurado.ReadOnly = true;
            this.dgvEstoqueApurado.Size = new System.Drawing.Size(907, 400);
            this.dgvEstoqueApurado.TabIndex = 11;
            // 
            // btnLimparBanco
            // 
            this.btnLimparBanco.Location = new System.Drawing.Point(13, 567);
            this.btnLimparBanco.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimparBanco.Name = "btnLimparBanco";
            this.btnLimparBanco.Size = new System.Drawing.Size(264, 46);
            this.btnLimparBanco.TabIndex = 16;
            this.btnLimparBanco.Text = "Limpar Dados Estoque Apurado";
            this.btnLimparBanco.UseVisualStyleBackColor = true;
            this.btnLimparBanco.Click += new System.EventHandler(this.btnLimparBanco_Click);
            // 
            // sistemaLojaDataSet3
            // 
            this.sistemaLojaDataSet3.DataSetName = "SistemaLojaDataSet3";
            this.sistemaLojaDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // estoqueApuradoBindingSource
            // 
            this.estoqueApuradoBindingSource.DataMember = "EstoqueApurado";
            this.estoqueApuradoBindingSource.DataSource = this.sistemaLojaDataSet3;
            // 
            // estoqueApuradoTableAdapter
            // 
            this.estoqueApuradoTableAdapter.ClearBeforeFill = true;
            // 
            // IdEstoqueApurado
            // 
            this.IdEstoqueApurado.Frozen = true;
            this.IdEstoqueApurado.HeaderText = "Id";
            this.IdEstoqueApurado.Name = "IdEstoqueApurado";
            this.IdEstoqueApurado.ReadOnly = true;
            // 
            // CodBarras
            // 
            this.CodBarras.Frozen = true;
            this.CodBarras.HeaderText = "Cód. Barras";
            this.CodBarras.Name = "CodBarras";
            this.CodBarras.ReadOnly = true;
            this.CodBarras.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // NomeProduto
            // 
            this.NomeProduto.Frozen = true;
            this.NomeProduto.HeaderText = "Nome Produto";
            this.NomeProduto.Name = "NomeProduto";
            this.NomeProduto.ReadOnly = true;
            this.NomeProduto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // CodValido
            // 
            this.CodValido.Frozen = true;
            this.CodValido.HeaderText = "Cód. Encontrado";
            this.CodValido.Name = "CodValido";
            this.CodValido.ReadOnly = true;
            this.CodValido.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // frmEstoqueApuradoSimples
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 726);
            this.Controls.Add(this.btnLimparBanco);
            this.Controls.Add(this.dgvEstoqueApurado);
            this.Controls.Add(this.lblqtdereal);
            this.Controls.Add(this.lblNomeProdutoReal);
            this.Controls.Add(this.lblcodBarras);
            this.Controls.Add(this.txtCodigoBarras);
            this.Name = "frmEstoqueApuradoSimples";
            this.Text = "frmEstoqueApuradoSimples";
            this.Load += new System.EventHandler(this.frmEstoqueApuradoSimples_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstoqueApurado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaLojaDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estoqueApuradoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblcodBarras;
        private System.Windows.Forms.TextBox txtCodigoBarras;
        private System.Windows.Forms.Label lblqtdereal;
        private System.Windows.Forms.Label lblNomeProdutoReal;
        private System.Windows.Forms.DataGridView dgvEstoqueApurado;
        private System.Windows.Forms.Button btnLimparBanco;
        private SistemaLojaDataSet3 sistemaLojaDataSet3;
        private System.Windows.Forms.BindingSource estoqueApuradoBindingSource;
        private SistemaLojaDataSet3TableAdapters.EstoqueApuradoTableAdapter estoqueApuradoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdEstoqueApurado;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodBarras;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodValido;
    }
}