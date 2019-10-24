namespace CodigoDeBarras
{
    partial class frmGerarEtiqueta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGerarEtiqueta));
            this.dgvEtiquetas = new System.Windows.Forms.DataGridView();
            this.idCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoBarras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grupo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumeroFab = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstoqueDisp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Venda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fornecedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblqtdereal = new System.Windows.Forms.Label();
            this.lblNomeProdutoReal = new System.Windows.Forms.Label();
            this.lblcodBarras = new System.Windows.Forms.Label();
            this.txtCodigoBarras = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtQtdeCodBarras = new System.Windows.Forms.TextBox();
            this.btnImprimeEtiquetas = new System.Windows.Forms.Button();
            this.txtTeste = new System.Windows.Forms.TextBox();
            this.btnExcluirEtiquetas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEtiquetas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEtiquetas
            // 
            this.dgvEtiquetas.AllowUserToAddRows = false;
            this.dgvEtiquetas.AllowUserToDeleteRows = false;
            this.dgvEtiquetas.AllowUserToOrderColumns = true;
            this.dgvEtiquetas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEtiquetas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCodigo,
            this.CodigoBarras,
            this.NomeProduto,
            this.Grupo,
            this.NumeroFab,
            this.EstoqueDisp,
            this.Venda,
            this.Fornecedor});
            this.dgvEtiquetas.Location = new System.Drawing.Point(13, 119);
            this.dgvEtiquetas.Margin = new System.Windows.Forms.Padding(4);
            this.dgvEtiquetas.Name = "dgvEtiquetas";
            this.dgvEtiquetas.ReadOnly = true;
            this.dgvEtiquetas.Size = new System.Drawing.Size(1391, 498);
            this.dgvEtiquetas.TabIndex = 16;
            // 
            // idCodigo
            // 
            this.idCodigo.Frozen = true;
            this.idCodigo.HeaderText = "idCodigo";
            this.idCodigo.Name = "idCodigo";
            this.idCodigo.ReadOnly = true;
            // 
            // CodigoBarras
            // 
            this.CodigoBarras.Frozen = true;
            this.CodigoBarras.HeaderText = "Cod. Barras";
            this.CodigoBarras.Name = "CodigoBarras";
            this.CodigoBarras.ReadOnly = true;
            // 
            // NomeProduto
            // 
            this.NomeProduto.Frozen = true;
            this.NomeProduto.HeaderText = "Nome Produto";
            this.NomeProduto.Name = "NomeProduto";
            this.NomeProduto.ReadOnly = true;
            // 
            // Grupo
            // 
            this.Grupo.Frozen = true;
            this.Grupo.HeaderText = "Grupo";
            this.Grupo.Name = "Grupo";
            this.Grupo.ReadOnly = true;
            // 
            // NumeroFab
            // 
            this.NumeroFab.Frozen = true;
            this.NumeroFab.HeaderText = "Nº Fabricante";
            this.NumeroFab.Name = "NumeroFab";
            this.NumeroFab.ReadOnly = true;
            // 
            // EstoqueDisp
            // 
            this.EstoqueDisp.Frozen = true;
            this.EstoqueDisp.HeaderText = "Qtde";
            this.EstoqueDisp.Name = "EstoqueDisp";
            this.EstoqueDisp.ReadOnly = true;
            // 
            // Venda
            // 
            this.Venda.Frozen = true;
            this.Venda.HeaderText = "Valor Venda";
            this.Venda.Name = "Venda";
            this.Venda.ReadOnly = true;
            // 
            // Fornecedor
            // 
            this.Fornecedor.Frozen = true;
            this.Fornecedor.HeaderText = "Fornecedor";
            this.Fornecedor.Name = "Fornecedor";
            this.Fornecedor.ReadOnly = true;
            // 
            // lblqtdereal
            // 
            this.lblqtdereal.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblqtdereal.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblqtdereal.ForeColor = System.Drawing.Color.Navy;
            this.lblqtdereal.Location = new System.Drawing.Point(468, 76);
            this.lblqtdereal.Name = "lblqtdereal";
            this.lblqtdereal.Size = new System.Drawing.Size(144, 26);
            this.lblqtdereal.TabIndex = 15;
            // 
            // lblNomeProdutoReal
            // 
            this.lblNomeProdutoReal.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblNomeProdutoReal.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeProdutoReal.ForeColor = System.Drawing.Color.Navy;
            this.lblNomeProdutoReal.Location = new System.Drawing.Point(13, 76);
            this.lblNomeProdutoReal.Name = "lblNomeProdutoReal";
            this.lblNomeProdutoReal.Size = new System.Drawing.Size(427, 26);
            this.lblNomeProdutoReal.TabIndex = 14;
            // 
            // lblcodBarras
            // 
            this.lblcodBarras.AutoSize = true;
            this.lblcodBarras.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcodBarras.Location = new System.Drawing.Point(13, 14);
            this.lblcodBarras.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblcodBarras.Name = "lblcodBarras";
            this.lblcodBarras.Size = new System.Drawing.Size(99, 18);
            this.lblcodBarras.TabIndex = 13;
            this.lblcodBarras.Text = "Cód. Barras";
            // 
            // txtCodigoBarras
            // 
            this.txtCodigoBarras.Location = new System.Drawing.Point(13, 36);
            this.txtCodigoBarras.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigoBarras.MaxLength = 13;
            this.txtCodigoBarras.Name = "txtCodigoBarras";
            this.txtCodigoBarras.Size = new System.Drawing.Size(283, 22);
            this.txtCodigoBarras.TabIndex = 12;
            this.txtCodigoBarras.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigoBarras_KeyPress);
            this.txtCodigoBarras.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCodigoBarras_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(328, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 18);
            this.label1.TabIndex = 18;
            this.label1.Text = "Quantidade";
            // 
            // txtQtdeCodBarras
            // 
            this.txtQtdeCodBarras.Enabled = false;
            this.txtQtdeCodBarras.Location = new System.Drawing.Point(331, 36);
            this.txtQtdeCodBarras.Margin = new System.Windows.Forms.Padding(4);
            this.txtQtdeCodBarras.MaxLength = 13;
            this.txtQtdeCodBarras.Name = "txtQtdeCodBarras";
            this.txtQtdeCodBarras.Size = new System.Drawing.Size(109, 22);
            this.txtQtdeCodBarras.TabIndex = 17;
            this.txtQtdeCodBarras.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtQtdeCodBarras_KeyUp);
            // 
            // btnImprimeEtiquetas
            // 
            this.btnImprimeEtiquetas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimeEtiquetas.Location = new System.Drawing.Point(607, 623);
            this.btnImprimeEtiquetas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnImprimeEtiquetas.Name = "btnImprimeEtiquetas";
            this.btnImprimeEtiquetas.Size = new System.Drawing.Size(228, 55);
            this.btnImprimeEtiquetas.TabIndex = 25;
            this.btnImprimeEtiquetas.Text = "Imprime Etiquetas";
            this.btnImprimeEtiquetas.Click += new System.EventHandler(this.btnImprimeEtiquetas_Click);
            // 
            // txtTeste
            // 
            this.txtTeste.Enabled = false;
            this.txtTeste.Location = new System.Drawing.Point(1456, 144);
            this.txtTeste.Margin = new System.Windows.Forms.Padding(4);
            this.txtTeste.MaxLength = 13;
            this.txtTeste.Multiline = true;
            this.txtTeste.Name = "txtTeste";
            this.txtTeste.Size = new System.Drawing.Size(245, 400);
            this.txtTeste.TabIndex = 26;
            // 
            // btnExcluirEtiquetas
            // 
            this.btnExcluirEtiquetas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnExcluirEtiquetas.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluirEtiquetas.Image")));
            this.btnExcluirEtiquetas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluirEtiquetas.Location = new System.Drawing.Point(16, 628);
            this.btnExcluirEtiquetas.Name = "btnExcluirEtiquetas";
            this.btnExcluirEtiquetas.Size = new System.Drawing.Size(225, 50);
            this.btnExcluirEtiquetas.TabIndex = 27;
            this.btnExcluirEtiquetas.Text = "Excluir Etiquetas";
            this.btnExcluirEtiquetas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcluirEtiquetas.UseVisualStyleBackColor = true;
            this.btnExcluirEtiquetas.Click += new System.EventHandler(this.btnExcluirEtiquetas_Click);
            // 
            // frmGerarEtiqueta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1740, 709);
            this.Controls.Add(this.btnExcluirEtiquetas);
            this.Controls.Add(this.txtTeste);
            this.Controls.Add(this.btnImprimeEtiquetas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtQtdeCodBarras);
            this.Controls.Add(this.dgvEtiquetas);
            this.Controls.Add(this.lblqtdereal);
            this.Controls.Add(this.lblNomeProdutoReal);
            this.Controls.Add(this.lblcodBarras);
            this.Controls.Add(this.txtCodigoBarras);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmGerarEtiqueta";
            this.Text = "frmGerarEtiqueta";
            this.Load += new System.EventHandler(this.frmGerarEtiqueta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEtiquetas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEtiquetas;
        private System.Windows.Forms.Label lblqtdereal;
        private System.Windows.Forms.Label lblNomeProdutoReal;
        private System.Windows.Forms.Label lblcodBarras;
        private System.Windows.Forms.TextBox txtCodigoBarras;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtQtdeCodBarras;
        private System.Windows.Forms.Button btnImprimeEtiquetas;
        private System.Windows.Forms.TextBox txtTeste;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoBarras;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grupo;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroFab;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstoqueDisp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Venda;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fornecedor;
        private System.Windows.Forms.Button btnExcluirEtiquetas;
    }
}