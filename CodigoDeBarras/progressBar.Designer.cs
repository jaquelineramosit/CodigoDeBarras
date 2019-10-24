namespace CodigoDeBarras
{
    partial class progressBar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(progressBar));
            this.barraDeProgresso = new System.Windows.Forms.ProgressBar();
            this.lblMensagem = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // barraDeProgresso
            // 
            this.barraDeProgresso.Location = new System.Drawing.Point(11, 11);
            this.barraDeProgresso.Margin = new System.Windows.Forms.Padding(2);
            this.barraDeProgresso.Name = "barraDeProgresso";
            this.barraDeProgresso.Size = new System.Drawing.Size(431, 30);
            this.barraDeProgresso.TabIndex = 6;
            this.barraDeProgresso.UseWaitCursor = true;
            // 
            // lblMensagem
            // 
            this.lblMensagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensagem.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblMensagem.Location = new System.Drawing.Point(11, 51);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(431, 20);
            this.lblMensagem.TabIndex = 7;
            // 
            // progressBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 81);
            this.Controls.Add(this.lblMensagem);
            this.Controls.Add(this.barraDeProgresso);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "progressBar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aguarde... Processo em execução";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ProgressBar barraDeProgresso;
        public System.Windows.Forms.Label lblMensagem;
    }
}