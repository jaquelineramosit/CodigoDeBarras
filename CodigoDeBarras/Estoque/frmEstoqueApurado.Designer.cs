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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEstoqueApurado));
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
            this.txtCodigoBarras.Location = new System.Drawing.Point(12, 42);
            this.txtCodigoBarras.MaxLength = 13;
            this.txtCodigoBarras.Name = "txtCodigoBarras";
            this.txtCodigoBarras.Size = new System.Drawing.Size(194, 20);
            this.txtCodigoBarras.TabIndex = 0;
            this.txtCodigoBarras.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigoBarras_KeyPress);
            this.txtCodigoBarras.Leave += new System.EventHandler(this.txtCodigoBarras_Leave);
            // 
            // txtQtde
            // 
            this.txtQtde.Location = new System.Drawing.Point(221, 42);
            this.txtQtde.Name = "txtQtde";
            this.txtQtde.Size = new System.Drawing.Size(109, 20);
            this.txtQtde.TabIndex = 1;
            // 
            // btnInsere
            // 
            this.btnInsere.Location = new System.Drawing.Point(350, 35);
            this.btnInsere.Name = "btnInsere";
            this.btnInsere.Size = new System.Drawing.Size(108, 33);
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
            this.dgvEstoqueApurado.Location = new System.Drawing.Point(12, 128);
            this.dgvEstoqueApurado.Name = "dgvEstoqueApurado";
            this.dgvEstoqueApurado.ReadOnly = true;
            this.dgvEstoqueApurado.Size = new System.Drawing.Size(764, 325);
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
            this.lblcodBarras.Location = new System.Drawing.Point(9, 24);
            this.lblcodBarras.Name = "lblcodBarras";
            this.lblcodBarras.Size = new System.Drawing.Size(82, 15);
            this.lblcodBarras.TabIndex = 4;
            this.lblcodBarras.Text = "Cód. Barras";
            // 
            // lblQtde
            // 
            this.lblQtde.AutoSize = true;
            this.lblQtde.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtde.Location = new System.Drawing.Point(218, 24);
            this.lblQtde.Name = "lblQtde";
            this.lblQtde.Size = new System.Drawing.Size(37, 15);
            this.lblQtde.TabIndex = 5;
            this.lblQtde.Text = "Qtde";
            // 
            // lblNomeProdutoReal
            // 
            this.lblNomeProdutoReal.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblNomeProdutoReal.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeProdutoReal.ForeColor = System.Drawing.Color.Navy;
            this.lblNomeProdutoReal.Location = new System.Drawing.Point(10, 75);
            this.lblNomeProdutoReal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNomeProdutoReal.Name = "lblNomeProdutoReal";
            this.lblNomeProdutoReal.Size = new System.Drawing.Size(320, 21);
            this.lblNomeProdutoReal.TabIndex = 7;
            // 
            // lblqtdereal
            // 
            this.lblqtdereal.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblqtdereal.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblqtdereal.ForeColor = System.Drawing.Color.Navy;
            this.lblqtdereal.Location = new System.Drawing.Point(350, 75);
            this.lblqtdereal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblqtdereal.Name = "lblqtdereal";
            this.lblqtdereal.Size = new System.Drawing.Size(108, 21);
            this.lblqtdereal.TabIndex = 8;
            // 
            // btnConferir
            // 
            this.btnConferir.Location = new System.Drawing.Point(692, 32);
            this.btnConferir.Name = "btnConferir";
            this.btnConferir.Size = new System.Drawing.Size(84, 37);
            this.btnConferir.TabIndex = 14;
            this.btnConferir.Text = "Conferir";
            this.btnConferir.UseVisualStyleBackColor = true;
            this.btnConferir.Click += new System.EventHandler(this.btnConferir_Click);
            // 
            // btnLimparBanco
            // 
            this.btnLimparBanco.Location = new System.Drawing.Point(12, 459);
            this.btnLimparBanco.Name = "btnLimparBanco";
            this.btnLimparBanco.Size = new System.Drawing.Size(198, 37);
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(805, 505);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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