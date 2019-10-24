namespace CodigoDeBarras
{
    partial class frmEstoqueSistema
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEstoqueSistema));
            this.gbEstoque = new System.Windows.Forms.GroupBox();
            this.lblMensagem = new System.Windows.Forms.Label();
            this.btnSelArquivo = new System.Windows.Forms.Button();
            this.lblUltAtualizacao = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblQtdeReg = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvEstoqueReal = new System.Windows.Forms.DataGridView();
            this.txtImportarArquivo = new System.Windows.Forms.TextBox();
            this.btnImportar = new System.Windows.Forms.Button();
            this.gbEstoque.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstoqueReal)).BeginInit();
            this.SuspendLayout();
            // 
            // gbEstoque
            // 
            this.gbEstoque.Controls.Add(this.lblMensagem);
            this.gbEstoque.Controls.Add(this.btnSelArquivo);
            this.gbEstoque.Controls.Add(this.lblUltAtualizacao);
            this.gbEstoque.Controls.Add(this.label3);
            this.gbEstoque.Controls.Add(this.lblQtdeReg);
            this.gbEstoque.Controls.Add(this.label2);
            this.gbEstoque.Controls.Add(this.dgvEstoqueReal);
            this.gbEstoque.Controls.Add(this.txtImportarArquivo);
            this.gbEstoque.Controls.Add(this.btnImportar);
            this.gbEstoque.Location = new System.Drawing.Point(12, 25);
            this.gbEstoque.Name = "gbEstoque";
            this.gbEstoque.Size = new System.Drawing.Size(1033, 548);
            this.gbEstoque.TabIndex = 7;
            this.gbEstoque.TabStop = false;
            this.gbEstoque.Text = "Estoque";
            // 
            // lblMensagem
            // 
            this.lblMensagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensagem.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblMensagem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblMensagem.Location = new System.Drawing.Point(6, 508);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(627, 19);
            this.lblMensagem.TabIndex = 14;
            this.lblMensagem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnSelArquivo
            // 
            this.btnSelArquivo.Location = new System.Drawing.Point(364, 33);
            this.btnSelArquivo.Name = "btnSelArquivo";
            this.btnSelArquivo.Size = new System.Drawing.Size(33, 28);
            this.btnSelArquivo.TabIndex = 12;
            this.btnSelArquivo.Text = "...";
            this.btnSelArquivo.UseVisualStyleBackColor = true;
            this.btnSelArquivo.Click += new System.EventHandler(this.btnSelArquivo_Click);
            // 
            // lblUltAtualizacao
            // 
            this.lblUltAtualizacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUltAtualizacao.Location = new System.Drawing.Point(752, 508);
            this.lblUltAtualizacao.Name = "lblUltAtualizacao";
            this.lblUltAtualizacao.Size = new System.Drawing.Size(73, 19);
            this.lblUltAtualizacao.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(652, 508);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 19);
            this.label3.TabIndex = 10;
            this.label3.Text = "Últ Atualização:";
            // 
            // lblQtdeReg
            // 
            this.lblQtdeReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtdeReg.Location = new System.Drawing.Point(955, 508);
            this.lblQtdeReg.Name = "lblQtdeReg";
            this.lblQtdeReg.Size = new System.Drawing.Size(73, 19);
            this.lblQtdeReg.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(868, 508);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "Qtde Registros:";
            // 
            // dgvEstoqueReal
            // 
            this.dgvEstoqueReal.AllowUserToAddRows = false;
            this.dgvEstoqueReal.AllowUserToDeleteRows = false;
            this.dgvEstoqueReal.AllowUserToOrderColumns = true;
            this.dgvEstoqueReal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstoqueReal.Location = new System.Drawing.Point(6, 71);
            this.dgvEstoqueReal.Name = "dgvEstoqueReal";
            this.dgvEstoqueReal.ReadOnly = true;
            this.dgvEstoqueReal.Size = new System.Drawing.Size(1021, 431);
            this.dgvEstoqueReal.TabIndex = 8;
            // 
            // txtImportarArquivo
            // 
            this.txtImportarArquivo.Enabled = false;
            this.txtImportarArquivo.Location = new System.Drawing.Point(6, 38);
            this.txtImportarArquivo.Name = "txtImportarArquivo";
            this.txtImportarArquivo.Size = new System.Drawing.Size(353, 20);
            this.txtImportarArquivo.TabIndex = 7;
            // 
            // btnImportar
            // 
            this.btnImportar.Location = new System.Drawing.Point(403, 27);
            this.btnImportar.Name = "btnImportar";
            this.btnImportar.Size = new System.Drawing.Size(84, 37);
            this.btnImportar.TabIndex = 0;
            this.btnImportar.Text = "Importar";
            this.btnImportar.UseVisualStyleBackColor = true;
            this.btnImportar.Click += new System.EventHandler(this.btnImportar_Click);
            // 
            // frmEstoqueSistema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 599);
            this.Controls.Add(this.gbEstoque);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmEstoqueSistema";
            this.Text = ".: Estoque Real :.";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmEstoqueSistema_Load);
            this.gbEstoque.ResumeLayout(false);
            this.gbEstoque.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstoqueReal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbEstoque;
        private System.Windows.Forms.Label lblUltAtualizacao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblQtdeReg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvEstoqueReal;
        private System.Windows.Forms.TextBox txtImportarArquivo;
        private System.Windows.Forms.Button btnImportar;
        private System.Windows.Forms.Button btnSelArquivo;
        public System.Windows.Forms.Label lblMensagem;
    }
}