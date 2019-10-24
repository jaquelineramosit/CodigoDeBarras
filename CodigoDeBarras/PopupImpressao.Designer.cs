namespace CodigoDeBarras
{
    partial class PopupImpressao
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
            this.gbImprimirEtiquetas = new System.Windows.Forms.GroupBox();
            this.tbLargura = new System.Windows.Forms.TextBox();
            this.lbLargura = new System.Windows.Forms.Label();
            this.tbAltura = new System.Windows.Forms.TextBox();
            this.lbAltura = new System.Windows.Forms.Label();
            this.cbQtdeEtiquetas = new System.Windows.Forms.ComboBox();
            this.lblQtdeEtiquetas = new System.Windows.Forms.Label();
            this.btnImprimeEtiquetas = new System.Windows.Forms.Button();
            this.cboListaImpresssora = new System.Windows.Forms.ComboBox();
            this.lblimpressora = new System.Windows.Forms.Label();
            this.picBarcode = new System.Windows.Forms.PictureBox();
            this.gbImprimirEtiquetas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBarcode)).BeginInit();
            this.SuspendLayout();
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
            this.gbImprimirEtiquetas.Location = new System.Drawing.Point(29, 88);
            this.gbImprimirEtiquetas.Name = "gbImprimirEtiquetas";
            this.gbImprimirEtiquetas.Size = new System.Drawing.Size(416, 157);
            this.gbImprimirEtiquetas.TabIndex = 32;
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
            // lblQtdeEtiquetas
            // 
            this.lblQtdeEtiquetas.AutoSize = true;
            this.lblQtdeEtiquetas.Location = new System.Drawing.Point(10, 22);
            this.lblQtdeEtiquetas.Name = "lblQtdeEtiquetas";
            this.lblQtdeEtiquetas.Size = new System.Drawing.Size(80, 13);
            this.lblQtdeEtiquetas.TabIndex = 27;
            this.lblQtdeEtiquetas.Text = "Qtde Etiquetas:";
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
            // cboListaImpresssora
            // 
            this.cboListaImpresssora.FormattingEnabled = true;
            this.cboListaImpresssora.Location = new System.Drawing.Point(29, 45);
            this.cboListaImpresssora.Margin = new System.Windows.Forms.Padding(2);
            this.cboListaImpresssora.Name = "cboListaImpresssora";
            this.cboListaImpresssora.Size = new System.Drawing.Size(417, 21);
            this.cboListaImpresssora.TabIndex = 31;
            this.cboListaImpresssora.SelectedIndexChanged += new System.EventHandler(this.cboListaImpresssora_SelectedIndexChanged);
            // 
            // lblimpressora
            // 
            this.lblimpressora.Location = new System.Drawing.Point(29, 27);
            this.lblimpressora.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblimpressora.Name = "lblimpressora";
            this.lblimpressora.Size = new System.Drawing.Size(128, 21);
            this.lblimpressora.TabIndex = 29;
            this.lblimpressora.Text = "Selecione a Impressora";
            // 
            // picBarcode
            // 
            this.picBarcode.Location = new System.Drawing.Point(9, 254);
            this.picBarcode.Margin = new System.Windows.Forms.Padding(2);
            this.picBarcode.Name = "picBarcode";
            this.picBarcode.Size = new System.Drawing.Size(476, 20);
            this.picBarcode.TabIndex = 33;
            this.picBarcode.TabStop = false;
            // 
            // PopupImpressao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 284);
            this.Controls.Add(this.picBarcode);
            this.Controls.Add(this.gbImprimirEtiquetas);
            this.Controls.Add(this.cboListaImpresssora);
            this.Controls.Add(this.lblimpressora);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PopupImpressao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "PopupImpressao";
            this.gbImprimirEtiquetas.ResumeLayout(false);
            this.gbImprimirEtiquetas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBarcode)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbImprimirEtiquetas;
        private System.Windows.Forms.TextBox tbLargura;
        private System.Windows.Forms.Label lbLargura;
        private System.Windows.Forms.TextBox tbAltura;
        private System.Windows.Forms.Label lbAltura;
        private System.Windows.Forms.ComboBox cbQtdeEtiquetas;
        private System.Windows.Forms.Label lblQtdeEtiquetas;
        private System.Windows.Forms.Button btnImprimeEtiquetas;
        private System.Windows.Forms.ComboBox cboListaImpresssora;
        private System.Windows.Forms.Label lblimpressora;
        private System.Windows.Forms.PictureBox picBarcode;
    }
}