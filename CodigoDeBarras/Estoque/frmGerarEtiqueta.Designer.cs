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
            this.btnExcluirEtiquetas = new System.Windows.Forms.Button();
            this.btxExcluirSelec = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumFabricante = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtQtdeNumFab = new System.Windows.Forms.TextBox();
            this.lblQtdeEtiquetas = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEtiquetas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEtiquetas
            // 
            this.dgvEtiquetas.AllowUserToAddRows = false;
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
            this.dgvEtiquetas.Location = new System.Drawing.Point(7, 156);
            this.dgvEtiquetas.Name = "dgvEtiquetas";
            this.dgvEtiquetas.Size = new System.Drawing.Size(1043, 405);
            this.dgvEtiquetas.TabIndex = 16;
            // 
            // idCodigo
            // 
            this.idCodigo.Frozen = true;
            this.idCodigo.HeaderText = "idCodigo";
            this.idCodigo.Name = "idCodigo";
            // 
            // CodigoBarras
            // 
            this.CodigoBarras.Frozen = true;
            this.CodigoBarras.HeaderText = "Cod. Barras";
            this.CodigoBarras.Name = "CodigoBarras";
            // 
            // NomeProduto
            // 
            this.NomeProduto.Frozen = true;
            this.NomeProduto.HeaderText = "Nome Produto";
            this.NomeProduto.Name = "NomeProduto";
            // 
            // Grupo
            // 
            this.Grupo.Frozen = true;
            this.Grupo.HeaderText = "Grupo";
            this.Grupo.Name = "Grupo";
            // 
            // NumeroFab
            // 
            this.NumeroFab.Frozen = true;
            this.NumeroFab.HeaderText = "Nº Fabricante";
            this.NumeroFab.Name = "NumeroFab";
            // 
            // EstoqueDisp
            // 
            this.EstoqueDisp.Frozen = true;
            this.EstoqueDisp.HeaderText = "Qtde";
            this.EstoqueDisp.Name = "EstoqueDisp";
            // 
            // Venda
            // 
            this.Venda.Frozen = true;
            this.Venda.HeaderText = "Valor Venda";
            this.Venda.Name = "Venda";
            // 
            // Fornecedor
            // 
            this.Fornecedor.Frozen = true;
            this.Fornecedor.HeaderText = "Fornecedor";
            this.Fornecedor.Name = "Fornecedor";
            // 
            // lblqtdereal
            // 
            this.lblqtdereal.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblqtdereal.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblqtdereal.ForeColor = System.Drawing.Color.Navy;
            this.lblqtdereal.Location = new System.Drawing.Point(348, 123);
            this.lblqtdereal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblqtdereal.Name = "lblqtdereal";
            this.lblqtdereal.Size = new System.Drawing.Size(108, 21);
            this.lblqtdereal.TabIndex = 15;
            // 
            // lblNomeProdutoReal
            // 
            this.lblNomeProdutoReal.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblNomeProdutoReal.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeProdutoReal.ForeColor = System.Drawing.Color.Navy;
            this.lblNomeProdutoReal.Location = new System.Drawing.Point(7, 123);
            this.lblNomeProdutoReal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNomeProdutoReal.Name = "lblNomeProdutoReal";
            this.lblNomeProdutoReal.Size = new System.Drawing.Size(320, 21);
            this.lblNomeProdutoReal.TabIndex = 14;
            // 
            // lblcodBarras
            // 
            this.lblcodBarras.AutoSize = true;
            this.lblcodBarras.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcodBarras.Location = new System.Drawing.Point(10, 11);
            this.lblcodBarras.Name = "lblcodBarras";
            this.lblcodBarras.Size = new System.Drawing.Size(82, 15);
            this.lblcodBarras.TabIndex = 13;
            this.lblcodBarras.Text = "Cód. Barras";
            // 
            // txtCodigoBarras
            // 
            this.txtCodigoBarras.Location = new System.Drawing.Point(10, 29);
            this.txtCodigoBarras.MaxLength = 13;
            this.txtCodigoBarras.Name = "txtCodigoBarras";
            this.txtCodigoBarras.Size = new System.Drawing.Size(213, 20);
            this.txtCodigoBarras.TabIndex = 12;
            this.txtCodigoBarras.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigoBarras_KeyPress);
            this.txtCodigoBarras.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCodigoBarras_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(242, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 15);
            this.label1.TabIndex = 18;
            this.label1.Text = "Quantidade";
            // 
            // txtQtdeCodBarras
            // 
            this.txtQtdeCodBarras.Enabled = false;
            this.txtQtdeCodBarras.Location = new System.Drawing.Point(244, 29);
            this.txtQtdeCodBarras.MaxLength = 13;
            this.txtQtdeCodBarras.Name = "txtQtdeCodBarras";
            this.txtQtdeCodBarras.Size = new System.Drawing.Size(83, 20);
            this.txtQtdeCodBarras.TabIndex = 17;
            this.txtQtdeCodBarras.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtQtdeCodBarras_KeyUp);
            // 
            // btnImprimeEtiquetas
            // 
            this.btnImprimeEtiquetas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimeEtiquetas.Location = new System.Drawing.Point(879, 11);
            this.btnImprimeEtiquetas.Margin = new System.Windows.Forms.Padding(2);
            this.btnImprimeEtiquetas.Name = "btnImprimeEtiquetas";
            this.btnImprimeEtiquetas.Size = new System.Drawing.Size(171, 45);
            this.btnImprimeEtiquetas.TabIndex = 25;
            this.btnImprimeEtiquetas.Text = "Imprime Etiquetas";
            this.btnImprimeEtiquetas.Click += new System.EventHandler(this.btnImprimeEtiquetas_Click);
            // 
            // btnExcluirEtiquetas
            // 
            this.btnExcluirEtiquetas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnExcluirEtiquetas.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluirEtiquetas.Image")));
            this.btnExcluirEtiquetas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluirEtiquetas.Location = new System.Drawing.Point(206, 571);
            this.btnExcluirEtiquetas.Margin = new System.Windows.Forms.Padding(2);
            this.btnExcluirEtiquetas.Name = "btnExcluirEtiquetas";
            this.btnExcluirEtiquetas.Size = new System.Drawing.Size(139, 41);
            this.btnExcluirEtiquetas.TabIndex = 27;
            this.btnExcluirEtiquetas.Text = "Excluir Todas";
            this.btnExcluirEtiquetas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcluirEtiquetas.UseVisualStyleBackColor = true;
            this.btnExcluirEtiquetas.Click += new System.EventHandler(this.btnExcluirEtiquetas_Click);
            // 
            // btxExcluirSelec
            // 
            this.btxExcluirSelec.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.btxExcluirSelec.Image = ((System.Drawing.Image)(resources.GetObject("btxExcluirSelec.Image")));
            this.btxExcluirSelec.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btxExcluirSelec.Location = new System.Drawing.Point(7, 571);
            this.btxExcluirSelec.Margin = new System.Windows.Forms.Padding(2);
            this.btxExcluirSelec.Name = "btxExcluirSelec";
            this.btxExcluirSelec.Size = new System.Drawing.Size(195, 41);
            this.btxExcluirSelec.TabIndex = 28;
            this.btxExcluirSelec.Text = "Excluir Selecionadas";
            this.btxExcluirSelec.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btxExcluirSelec.UseVisualStyleBackColor = true;
            this.btxExcluirSelec.Click += new System.EventHandler(this.btxExcluirSelec_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 15);
            this.label2.TabIndex = 30;
            this.label2.Text = "Num. Fabricante";
            // 
            // txtNumFabricante
            // 
            this.txtNumFabricante.Location = new System.Drawing.Point(10, 82);
            this.txtNumFabricante.MaxLength = 50;
            this.txtNumFabricante.Name = "txtNumFabricante";
            this.txtNumFabricante.Size = new System.Drawing.Size(213, 20);
            this.txtNumFabricante.TabIndex = 29;
            this.txtNumFabricante.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtNumFabricante_KeyUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(241, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 15);
            this.label3.TabIndex = 32;
            this.label3.Text = "Quantidade";
            // 
            // txtQtdeNumFab
            // 
            this.txtQtdeNumFab.Enabled = false;
            this.txtQtdeNumFab.Location = new System.Drawing.Point(243, 82);
            this.txtQtdeNumFab.MaxLength = 13;
            this.txtQtdeNumFab.Name = "txtQtdeNumFab";
            this.txtQtdeNumFab.Size = new System.Drawing.Size(83, 20);
            this.txtQtdeNumFab.TabIndex = 31;
            this.txtQtdeNumFab.TextChanged += new System.EventHandler(this.TxtQtdeNumFab_TextChanged);
            this.txtQtdeNumFab.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtQtdeNumFab_KeyUp);
            // 
            // lblQtdeEtiquetas
            // 
            this.lblQtdeEtiquetas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtdeEtiquetas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblQtdeEtiquetas.Location = new System.Drawing.Point(927, 571);
            this.lblQtdeEtiquetas.Name = "lblQtdeEtiquetas";
            this.lblQtdeEtiquetas.Size = new System.Drawing.Size(122, 24);
            this.lblQtdeEtiquetas.TabIndex = 33;
            // 
            // frmGerarEtiqueta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 639);
            this.Controls.Add(this.lblQtdeEtiquetas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtQtdeNumFab);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNumFabricante);
            this.Controls.Add(this.btxExcluirSelec);
            this.Controls.Add(this.btnExcluirEtiquetas);
            this.Controls.Add(this.btnImprimeEtiquetas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtQtdeCodBarras);
            this.Controls.Add(this.dgvEtiquetas);
            this.Controls.Add(this.lblqtdereal);
            this.Controls.Add(this.lblNomeProdutoReal);
            this.Controls.Add(this.lblcodBarras);
            this.Controls.Add(this.txtCodigoBarras);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.Button btnExcluirEtiquetas;
        private System.Windows.Forms.Button btxExcluirSelec;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoBarras;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grupo;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroFab;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstoqueDisp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Venda;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fornecedor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNumFabricante;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtQtdeNumFab;
        private System.Windows.Forms.Label lblQtdeEtiquetas;
    }
}