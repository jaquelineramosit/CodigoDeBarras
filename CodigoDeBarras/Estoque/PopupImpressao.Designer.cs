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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PopupImpressao));
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelEspacamento = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbImprimirEtiquetas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBarcode)).BeginInit();
            this.SuspendLayout();
            // 
            // gbImprimirEtiquetas
            // 
            this.gbImprimirEtiquetas.Controls.Add(this.comboBox1);
            this.gbImprimirEtiquetas.Controls.Add(this.label1);
            this.gbImprimirEtiquetas.Controls.Add(this.textBox1);
            this.gbImprimirEtiquetas.Controls.Add(this.labelEspacamento);
            this.gbImprimirEtiquetas.Controls.Add(this.tbLargura);
            this.gbImprimirEtiquetas.Controls.Add(this.lbLargura);
            this.gbImprimirEtiquetas.Controls.Add(this.tbAltura);
            this.gbImprimirEtiquetas.Controls.Add(this.lbAltura);
            this.gbImprimirEtiquetas.Controls.Add(this.cbQtdeEtiquetas);
            this.gbImprimirEtiquetas.Controls.Add(this.lblQtdeEtiquetas);
            this.gbImprimirEtiquetas.Controls.Add(this.btnImprimeEtiquetas);
            this.gbImprimirEtiquetas.Location = new System.Drawing.Point(39, 104);
            this.gbImprimirEtiquetas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbImprimirEtiquetas.Name = "gbImprimirEtiquetas";
            this.gbImprimirEtiquetas.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbImprimirEtiquetas.Size = new System.Drawing.Size(671, 332);
            this.gbImprimirEtiquetas.TabIndex = 32;
            this.gbImprimirEtiquetas.TabStop = false;
            this.gbImprimirEtiquetas.Text = "Imprimir Etiquetas";
            // 
            // tbLargura
            // 
            this.tbLargura.Location = new System.Drawing.Point(342, 138);
            this.tbLargura.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbLargura.Name = "tbLargura";
            this.tbLargura.Size = new System.Drawing.Size(131, 22);
            this.tbLargura.TabIndex = 33;
            // 
            // lbLargura
            // 
            this.lbLargura.AutoSize = true;
            this.lbLargura.Location = new System.Drawing.Point(338, 117);
            this.lbLargura.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbLargura.Name = "lbLargura";
            this.lbLargura.Size = new System.Drawing.Size(62, 17);
            this.lbLargura.TabIndex = 32;
            this.lbLargura.Text = "Largura:";
            // 
            // tbAltura
            // 
            this.tbAltura.Location = new System.Drawing.Point(176, 138);
            this.tbAltura.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbAltura.Name = "tbAltura";
            this.tbAltura.Size = new System.Drawing.Size(131, 22);
            this.tbAltura.TabIndex = 31;
            // 
            // lbAltura
            // 
            this.lbAltura.AutoSize = true;
            this.lbAltura.Location = new System.Drawing.Point(172, 117);
            this.lbAltura.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbAltura.Name = "lbAltura";
            this.lbAltura.Size = new System.Drawing.Size(49, 17);
            this.lbAltura.TabIndex = 30;
            this.lbAltura.Text = "Altura:";
            // 
            // cbQtdeEtiquetas
            // 
            this.cbQtdeEtiquetas.FormattingEnabled = true;
            this.cbQtdeEtiquetas.Items.AddRange(new object[] {
            "20",
            "30",
            "33",
            "36"});
            this.cbQtdeEtiquetas.Location = new System.Drawing.Point(17, 136);
            this.cbQtdeEtiquetas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbQtdeEtiquetas.Name = "cbQtdeEtiquetas";
            this.cbQtdeEtiquetas.Size = new System.Drawing.Size(120, 24);
            this.cbQtdeEtiquetas.TabIndex = 29;
            this.cbQtdeEtiquetas.SelectedIndexChanged += new System.EventHandler(this.cbQtdeEtiquetas_SelectedIndexChanged);
            // 
            // lblQtdeEtiquetas
            // 
            this.lblQtdeEtiquetas.AutoSize = true;
            this.lblQtdeEtiquetas.Location = new System.Drawing.Point(13, 116);
            this.lblQtdeEtiquetas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQtdeEtiquetas.Name = "lblQtdeEtiquetas";
            this.lblQtdeEtiquetas.Size = new System.Drawing.Size(106, 17);
            this.lblQtdeEtiquetas.TabIndex = 27;
            this.lblQtdeEtiquetas.Text = "Qtde Etiquetas:";
            // 
            // btnImprimeEtiquetas
            // 
            this.btnImprimeEtiquetas.Enabled = false;
            this.btnImprimeEtiquetas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimeEtiquetas.Location = new System.Drawing.Point(245, 225);
            this.btnImprimeEtiquetas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnImprimeEtiquetas.Name = "btnImprimeEtiquetas";
            this.btnImprimeEtiquetas.Size = new System.Drawing.Size(164, 55);
            this.btnImprimeEtiquetas.TabIndex = 24;
            this.btnImprimeEtiquetas.Text = "Imprime Etiquetas";
            this.btnImprimeEtiquetas.Click += new System.EventHandler(this.btnImprimeEtiquetas_Click);
            // 
            // cboListaImpresssora
            // 
            this.cboListaImpresssora.FormattingEnabled = true;
            this.cboListaImpresssora.Location = new System.Drawing.Point(39, 55);
            this.cboListaImpresssora.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboListaImpresssora.Name = "cboListaImpresssora";
            this.cboListaImpresssora.Size = new System.Drawing.Size(555, 24);
            this.cboListaImpresssora.TabIndex = 31;
            this.cboListaImpresssora.SelectedIndexChanged += new System.EventHandler(this.cboListaImpresssora_SelectedIndexChanged);
            // 
            // lblimpressora
            // 
            this.lblimpressora.Location = new System.Drawing.Point(39, 33);
            this.lblimpressora.Name = "lblimpressora";
            this.lblimpressora.Size = new System.Drawing.Size(171, 26);
            this.lblimpressora.TabIndex = 29;
            this.lblimpressora.Text = "Selecione a Impressora";
            // 
            // picBarcode
            // 
            this.picBarcode.Enabled = false;
            this.picBarcode.Location = new System.Drawing.Point(39, 451);
            this.picBarcode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picBarcode.Name = "picBarcode";
            this.picBarcode.Size = new System.Drawing.Size(671, 25);
            this.picBarcode.TabIndex = 33;
            this.picBarcode.TabStop = false;
            this.picBarcode.Click += new System.EventHandler(this.picBarcode_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(506, 138);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(131, 22);
            this.textBox1.TabIndex = 35;
            // 
            // labelEspacamento
            // 
            this.labelEspacamento.AutoSize = true;
            this.labelEspacamento.Location = new System.Drawing.Point(502, 117);
            this.labelEspacamento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEspacamento.Name = "labelEspacamento";
            this.labelEspacamento.Size = new System.Drawing.Size(123, 17);
            this.labelEspacamento.TabIndex = 34;
            this.labelEspacamento.Text = "Eapaçamento (H):";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Pimaco A4356 (33 etiquetas por página)",
            "NewEx (36 etiquetas por página)",
            "Selecione..."});
            this.comboBox1.Location = new System.Drawing.Point(18, 61);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(289, 24);
            this.comboBox1.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 17);
            this.label1.TabIndex = 36;
            this.label1.Text = "Modelo Etiqueta:";
            // 
            // PopupImpressao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 502);
            this.Controls.Add(this.picBarcode);
            this.Controls.Add(this.gbImprimirEtiquetas);
            this.Controls.Add(this.cboListaImpresssora);
            this.Controls.Add(this.lblimpressora);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelEspacamento;
    }
}