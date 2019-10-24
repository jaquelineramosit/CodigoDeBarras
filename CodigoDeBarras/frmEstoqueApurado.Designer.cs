namespace CodigoDeBarras
{
    partial class frmEstoqueApurado
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
            this.txtCodigoBarras = new System.Windows.Forms.TextBox();
            this.txtQtde = new System.Windows.Forms.TextBox();
            this.btnInsere = new System.Windows.Forms.Button();
            this.dgvEstoqueApurado = new System.Windows.Forms.DataGridView();
            this.idEstoqueApurado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estoqueDispApurado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codBarrasApurado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataUltModif = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estoqueApuradoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sistemaLojaDataSet = new CodigoDeBarras.SistemaLojaDataSet();
            this.lblcodBarras = new System.Windows.Forms.Label();
            this.lblQtde = new System.Windows.Forms.Label();
            this.lblNomeProdutoReal = new System.Windows.Forms.Label();
            this.lblqtdereal = new System.Windows.Forms.Label();
            this.btnConferir = new System.Windows.Forms.Button();
            this.btnLimparBanco = new System.Windows.Forms.Button();
            this.estoqueApuradoTableAdapter = new CodigoDeBarras.SistemaLojaDataSetTableAdapters.EstoqueApuradoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstoqueApurado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estoqueApuradoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaLojaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCodigoBarras
            // 
            this.txtCodigoBarras.Location = new System.Drawing.Point(16, 52);
            this.txtCodigoBarras.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigoBarras.MaxLength = 13;
            this.txtCodigoBarras.Name = "txtCodigoBarras";
            this.txtCodigoBarras.Size = new System.Drawing.Size(257, 22);
            this.txtCodigoBarras.TabIndex = 0;
            this.txtCodigoBarras.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigoBarras_KeyPress);
            this.txtCodigoBarras.Leave += new System.EventHandler(this.txtCodigoBarras_Leave);
            // 
            // txtQtde
            // 
            this.txtQtde.Location = new System.Drawing.Point(295, 52);
            this.txtQtde.Margin = new System.Windows.Forms.Padding(4);
            this.txtQtde.Name = "txtQtde";
            this.txtQtde.Size = new System.Drawing.Size(144, 22);
            this.txtQtde.TabIndex = 1;
            // 
            // btnInsere
            // 
            this.btnInsere.Location = new System.Drawing.Point(467, 43);
            this.btnInsere.Margin = new System.Windows.Forms.Padding(4);
            this.btnInsere.Name = "btnInsere";
            this.btnInsere.Size = new System.Drawing.Size(144, 41);
            this.btnInsere.TabIndex = 2;
            this.btnInsere.Text = "Insere";
            this.btnInsere.UseVisualStyleBackColor = true;
            this.btnInsere.Click += new System.EventHandler(this.btnInsere_Click);
            // 
            // dgvEstoqueApurado
            // 
            this.dgvEstoqueApurado.AllowUserToAddRows = false;
            this.dgvEstoqueApurado.AllowUserToDeleteRows = false;
            this.dgvEstoqueApurado.AllowUserToOrderColumns = true;
            this.dgvEstoqueApurado.AutoGenerateColumns = false;
            this.dgvEstoqueApurado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstoqueApurado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idEstoqueApurado,
            this.estoqueDispApurado,
            this.codBarrasApurado,
            this.dataUltModif});
            this.dgvEstoqueApurado.DataSource = this.estoqueApuradoBindingSource;
            this.dgvEstoqueApurado.Location = new System.Drawing.Point(16, 157);
            this.dgvEstoqueApurado.Margin = new System.Windows.Forms.Padding(4);
            this.dgvEstoqueApurado.Name = "dgvEstoqueApurado";
            this.dgvEstoqueApurado.ReadOnly = true;
            this.dgvEstoqueApurado.Size = new System.Drawing.Size(1019, 400);
            this.dgvEstoqueApurado.TabIndex = 3;
            this.dgvEstoqueApurado.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEstoqueApurado_CellDoubleClick);
            // 
            // idEstoqueApurado
            // 
            this.idEstoqueApurado.DataPropertyName = "IdEstoqueApurado";
            this.idEstoqueApurado.HeaderText = "IdEstoqueApurado";
            this.idEstoqueApurado.Name = "idEstoqueApurado";
            this.idEstoqueApurado.ReadOnly = true;
            // 
            // estoqueDispApurado
            // 
            this.estoqueDispApurado.DataPropertyName = "EstoqueDispApurado";
            this.estoqueDispApurado.HeaderText = "EstoqueDispApurado";
            this.estoqueDispApurado.Name = "estoqueDispApurado";
            this.estoqueDispApurado.ReadOnly = true;
            // 
            // codBarrasApurado
            // 
            this.codBarrasApurado.DataPropertyName = "CodBarrasApurado";
            this.codBarrasApurado.HeaderText = "CodBarrasApurado";
            this.codBarrasApurado.Name = "codBarrasApurado";
            this.codBarrasApurado.ReadOnly = true;
            // 
            // dataUltModif
            // 
            this.dataUltModif.DataPropertyName = "DataUltModif";
            this.dataUltModif.HeaderText = "DataUltModif";
            this.dataUltModif.Name = "dataUltModif";
            this.dataUltModif.ReadOnly = true;
            // 
            // estoqueApuradoBindingSource
            // 
            this.estoqueApuradoBindingSource.DataMember = "EstoqueApurado";
            this.estoqueApuradoBindingSource.DataSource = this.sistemaLojaDataSet;
            // 
            // sistemaLojaDataSet
            // 
            this.sistemaLojaDataSet.DataSetName = "SistemaLojaDataSet";
            this.sistemaLojaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblcodBarras
            // 
            this.lblcodBarras.AutoSize = true;
            this.lblcodBarras.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcodBarras.Location = new System.Drawing.Point(12, 30);
            this.lblcodBarras.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblcodBarras.Name = "lblcodBarras";
            this.lblcodBarras.Size = new System.Drawing.Size(99, 18);
            this.lblcodBarras.TabIndex = 4;
            this.lblcodBarras.Text = "Cód. Barras";
            // 
            // lblQtde
            // 
            this.lblQtde.AutoSize = true;
            this.lblQtde.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtde.Location = new System.Drawing.Point(291, 30);
            this.lblQtde.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQtde.Name = "lblQtde";
            this.lblQtde.Size = new System.Drawing.Size(44, 18);
            this.lblQtde.TabIndex = 5;
            this.lblQtde.Text = "Qtde";
            // 
            // lblNomeProdutoReal
            // 
            this.lblNomeProdutoReal.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblNomeProdutoReal.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeProdutoReal.ForeColor = System.Drawing.Color.Navy;
            this.lblNomeProdutoReal.Location = new System.Drawing.Point(13, 92);
            this.lblNomeProdutoReal.Name = "lblNomeProdutoReal";
            this.lblNomeProdutoReal.Size = new System.Drawing.Size(426, 26);
            this.lblNomeProdutoReal.TabIndex = 7;
            // 
            // lblqtdereal
            // 
            this.lblqtdereal.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblqtdereal.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblqtdereal.ForeColor = System.Drawing.Color.Navy;
            this.lblqtdereal.Location = new System.Drawing.Point(467, 92);
            this.lblqtdereal.Name = "lblqtdereal";
            this.lblqtdereal.Size = new System.Drawing.Size(144, 26);
            this.lblqtdereal.TabIndex = 8;
            // 
            // btnConferir
            // 
            this.btnConferir.Location = new System.Drawing.Point(923, 40);
            this.btnConferir.Margin = new System.Windows.Forms.Padding(4);
            this.btnConferir.Name = "btnConferir";
            this.btnConferir.Size = new System.Drawing.Size(112, 46);
            this.btnConferir.TabIndex = 14;
            this.btnConferir.Text = "Conferir";
            this.btnConferir.UseVisualStyleBackColor = true;
            this.btnConferir.Click += new System.EventHandler(this.btnConferir_Click);
            // 
            // btnLimparBanco
            // 
            this.btnLimparBanco.Location = new System.Drawing.Point(16, 565);
            this.btnLimparBanco.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimparBanco.Name = "btnLimparBanco";
            this.btnLimparBanco.Size = new System.Drawing.Size(264, 46);
            this.btnLimparBanco.TabIndex = 15;
            this.btnLimparBanco.Text = "Limpar Dados Estoque Apurado";
            this.btnLimparBanco.UseVisualStyleBackColor = true;
            this.btnLimparBanco.Click += new System.EventHandler(this.btnLimparBanco_Click);
            // 
            // estoqueApuradoTableAdapter
            // 
            this.estoqueApuradoTableAdapter.ClearBeforeFill = true;
            // 
            // frmEstoqueApurado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1073, 621);
            this.Controls.Add(this.btnLimparBanco);
            this.Controls.Add(this.btnConferir);
            this.Controls.Add(this.lblqtdereal);
            this.Controls.Add(this.lblNomeProdutoReal);
            this.Controls.Add(this.lblQtde);
            this.Controls.Add(this.lblcodBarras);
            this.Controls.Add(this.dgvEstoqueApurado);
            this.Controls.Add(this.btnInsere);
            this.Controls.Add(this.txtQtde);
            this.Controls.Add(this.txtCodigoBarras);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmEstoqueApurado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ".: Estoque Apurado :.";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmEstoqueApurado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstoqueApurado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estoqueApuradoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaLojaDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCodigoBarras;
        private System.Windows.Forms.TextBox txtQtde;
        private System.Windows.Forms.Button btnInsere;
        private System.Windows.Forms.DataGridView dgvEstoqueApurado;
        private System.Windows.Forms.Label lblcodBarras;
        private System.Windows.Forms.Label lblQtde;
        private System.Windows.Forms.Label lblNomeProdutoReal;
        private System.Windows.Forms.Label lblqtdereal;
        private System.Windows.Forms.Button btnConferir;
        private System.Windows.Forms.Button btnLimparBanco;
        private SistemaLojaDataSet sistemaLojaDataSet;
        private System.Windows.Forms.BindingSource estoqueApuradoBindingSource;
        private SistemaLojaDataSetTableAdapters.EstoqueApuradoTableAdapter estoqueApuradoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEstoqueApurado;
        private System.Windows.Forms.DataGridViewTextBoxColumn estoqueDispApurado;
        private System.Windows.Forms.DataGridViewTextBoxColumn codBarrasApurado;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataUltModif;
    }
}