namespace CodigoDeBarras
{
    partial class frmImprimirEtiqueta
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.cboListaImpresssora = new System.Windows.Forms.ComboBox();
            this.dgvEstoque = new System.Windows.Forms.DataGridView();
            this.btnImprimeEtiquetas = new System.Windows.Forms.Button();
            this.btnImportarArquivo = new System.Windows.Forms.Button();
            this.lblimpressora = new System.Windows.Forms.Label();
            this.lblQtdeEtiquetas = new System.Windows.Forms.Label();
            this.gbImprimirEtiquetas = new System.Windows.Forms.GroupBox();
            this.tbLargura = new System.Windows.Forms.TextBox();
            this.lbLargura = new System.Windows.Forms.Label();
            this.tbAltura = new System.Windows.Forms.TextBox();
            this.lbAltura = new System.Windows.Forms.Label();
            this.cbQtdeEtiquetas = new System.Windows.Forms.ComboBox();
            this.picBarcode = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstoque)).BeginInit();
            this.gbImprimirEtiquetas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBarcode)).BeginInit();
            this.SuspendLayout();
            // 
            // cboListaImpresssora
            // 
            this.cboListaImpresssora.FormattingEnabled = true;
            this.cboListaImpresssora.Location = new System.Drawing.Point(9, 31);
            this.cboListaImpresssora.Margin = new System.Windows.Forms.Padding(2);
            this.cboListaImpresssora.Name = "cboListaImpresssora";
            this.cboListaImpresssora.Size = new System.Drawing.Size(325, 21);
            this.cboListaImpresssora.TabIndex = 26;
            this.cboListaImpresssora.SelectedIndexChanged += new System.EventHandler(this.cboListaImpresssora_SelectedIndexChanged);
            // 
            // dgvEstoque
            // 
            this.dgvEstoque.AllowUserToAddRows = false;
            this.dgvEstoque.AllowUserToDeleteRows = false;
            this.dgvEstoque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstoque.Location = new System.Drawing.Point(9, 248);
            this.dgvEstoque.Margin = new System.Windows.Forms.Padding(2);
            this.dgvEstoque.Name = "dgvEstoque";
            this.dgvEstoque.RowTemplate.Height = 24;
            this.dgvEstoque.Size = new System.Drawing.Size(1014, 360);
            this.dgvEstoque.TabIndex = 25;
            // 
            // btnImprimeEtiquetas
            // 
            this.btnImprimeEtiquetas.Enabled = false;
            this.btnImprimeEtiquetas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimeEtiquetas.Location = new System.Drawing.Point(146, 80);
            this.btnImprimeEtiquetas.Margin = new System.Windows.Forms.Padding(2);
            this.btnImprimeEtiquetas.Name = "btnImprimeEtiquetas";
            this.btnImprimeEtiquetas.Size = new System.Drawing.Size(123, 45);
            this.btnImprimeEtiquetas.TabIndex = 24;
            this.btnImprimeEtiquetas.Text = "Imprime Etiquetas";
            this.btnImprimeEtiquetas.Click += new System.EventHandler(this.btnImprimeEtiquetas_Click);
            // 
            // btnImportarArquivo
            // 
            this.btnImportarArquivo.Enabled = false;
            this.btnImportarArquivo.Location = new System.Drawing.Point(347, 31);
            this.btnImportarArquivo.Margin = new System.Windows.Forms.Padding(2);
            this.btnImportarArquivo.Name = "btnImportarArquivo";
            this.btnImportarArquivo.Size = new System.Drawing.Size(110, 21);
            this.btnImportarArquivo.TabIndex = 23;
            this.btnImportarArquivo.Text = "Importar Arquivo Estoque";
            this.btnImportarArquivo.Click += new System.EventHandler(this.btnImportarArquivo_Click);
            // 
            // lblimpressora
            // 
            this.lblimpressora.Location = new System.Drawing.Point(9, 13);
            this.lblimpressora.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblimpressora.Name = "lblimpressora";
            this.lblimpressora.Size = new System.Drawing.Size(128, 21);
            this.lblimpressora.TabIndex = 22;
            this.lblimpressora.Text = "Selecione a Impressora";
            // 
            // lblQtdeEtiquetas
            // 
            this.lblQtdeEtiquetas.AutoSize = true;
            this.lblQtdeEtiquetas.Location = new System.Drawing.Point(10, 22);
            this.lblQtdeEtiquetas.Name = "lblQtdeEtiquetas";
            this.lblQtdeEtiquetas.Size = new System.Drawing.Size(80, 13);
            this.lblQtdeEtiquetas.TabIndex = 27;
            this.lblQtdeEtiquetas.Text = "Qtde Etiquetas:";
            // 
            // gbImprimirEtiquetas
            // 
            this.gbImprimirEtiquetas.Controls.Add(this.tbLargura);
            this.gbImprimirEtiquetas.Controls.Add(this.lbLargura);
            this.gbImprimirEtiquetas.Controls.Add(this.tbAltura);
            this.gbImprimirEtiquetas.Controls.Add(this.lbAltura);
            this.gbImprimirEtiquetas.Controls.Add(this.cbQtdeEtiquetas);
            this.gbImprimirEtiquetas.Controls.Add(this.lblQtdeEtiquetas);
            this.gbImprimirEtiquetas.Controls.Add(this.btnImprimeEtiquetas);
            this.gbImprimirEtiquetas.Location = new System.Drawing.Point(9, 74);
            this.gbImprimirEtiquetas.Name = "gbImprimirEtiquetas";
            this.gbImprimirEtiquetas.Size = new System.Drawing.Size(416, 157);
            this.gbImprimirEtiquetas.TabIndex = 28;
            this.gbImprimirEtiquetas.TabStop = false;
            this.gbImprimirEtiquetas.Text = "Imprimir Etiquetas";
            // 
            // tbLargura
            // 
            this.tbLargura.Location = new System.Drawing.Point(288, 39);
            this.tbLargura.Name = "tbLargura";
            this.tbLargura.Size = new System.Drawing.Size(99, 20);
            this.tbLargura.TabIndex = 33;
            // 
            // lbLargura
            // 
            this.lbLargura.AutoSize = true;
            this.lbLargura.Location = new System.Drawing.Point(285, 22);
            this.lbLargura.Name = "lbLargura";
            this.lbLargura.Size = new System.Drawing.Size(46, 13);
            this.lbLargura.TabIndex = 32;
            this.lbLargura.Text = "Largura:";
            // 
            // tbAltura
            // 
            this.tbAltura.Location = new System.Drawing.Point(146, 39);
            this.tbAltura.Name = "tbAltura";
            this.tbAltura.Size = new System.Drawing.Size(99, 20);
            this.tbAltura.TabIndex = 31;
            // 
            // lbAltura
            // 
            this.lbAltura.AutoSize = true;
            this.lbAltura.Location = new System.Drawing.Point(143, 22);
            this.lbAltura.Name = "lbAltura";
            this.lbAltura.Size = new System.Drawing.Size(37, 13);
            this.lbAltura.TabIndex = 30;
            this.lbAltura.Text = "Altura:";
            // 
            // cbQtdeEtiquetas
            // 
            this.cbQtdeEtiquetas.FormattingEnabled = true;
            this.cbQtdeEtiquetas.Location = new System.Drawing.Point(13, 38);
            this.cbQtdeEtiquetas.Name = "cbQtdeEtiquetas";
            this.cbQtdeEtiquetas.Size = new System.Drawing.Size(91, 21);
            this.cbQtdeEtiquetas.TabIndex = 29;
            // 
            // picBarcode
            // 
            this.picBarcode.Location = new System.Drawing.Point(9, 630);
            this.picBarcode.Margin = new System.Windows.Forms.Padding(2);
            this.picBarcode.Name = "picBarcode";
            this.picBarcode.Size = new System.Drawing.Size(953, 20);
            this.picBarcode.TabIndex = 21;
            this.picBarcode.TabStop = false;
            // 
            // frmImprimirEtiqueta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 664);
            this.Controls.Add(this.gbImprimirEtiquetas);
            this.Controls.Add(this.cboListaImpresssora);
            this.Controls.Add(this.dgvEstoque);
            this.Controls.Add(this.btnImportarArquivo);
            this.Controls.Add(this.lblimpressora);
            this.Controls.Add(this.picBarcode);
            this.Name = "frmImprimirEtiqueta";
            this.Text = "Imprimir Etiquetas EAN13";
            this.Load += new System.EventHandler(this.frmImprimirEtiqueta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstoque)).EndInit();
            this.gbImprimirEtiquetas.ResumeLayout(false);
            this.gbImprimirEtiquetas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBarcode)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cboListaImpresssora;
        private System.Windows.Forms.DataGridView dgvEstoque;
        private System.Windows.Forms.Button btnImprimeEtiquetas;
        private System.Windows.Forms.Button btnImportarArquivo;
        private System.Windows.Forms.Label lblimpressora;
        private System.Windows.Forms.Label lblQtdeEtiquetas;
        private System.Windows.Forms.GroupBox gbImprimirEtiquetas;
        private System.Windows.Forms.TextBox tbLargura;
        private System.Windows.Forms.Label lbLargura;
        private System.Windows.Forms.TextBox tbAltura;
        private System.Windows.Forms.Label lbAltura;
        private System.Windows.Forms.ComboBox cbQtdeEtiquetas;
        private System.Windows.Forms.PictureBox picBarcode;
    }
}

