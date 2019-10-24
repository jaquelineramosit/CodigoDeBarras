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
            this.gbEstoque = new System.Windows.Forms.GroupBox();
            this.btnConferir = new System.Windows.Forms.Button();
            this.btnSelArquivo = new System.Windows.Forms.Button();
            this.lblUltAtualizacao = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblQtdeReg = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvEstoqueReal = new System.Windows.Forms.DataGridView();
            this.txtImportarArquivo = new System.Windows.Forms.TextBox();
            this.btnImportar = new System.Windows.Forms.Button();
            this.lblMensagem = new System.Windows.Forms.Label();
            this.gbEstoque.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstoqueReal)).BeginInit();
            this.SuspendLayout();
            // 
            // gbEstoque
            // 
            this.gbEstoque.Controls.Add(this.lblMensagem);
            this.gbEstoque.Controls.Add(this.btnConferir);
            this.gbEstoque.Controls.Add(this.btnSelArquivo);
            this.gbEstoque.Controls.Add(this.lblUltAtualizacao);
            this.gbEstoque.Controls.Add(this.label3);
            this.gbEstoque.Controls.Add(this.lblQtdeReg);
            this.gbEstoque.Controls.Add(this.label2);
            this.gbEstoque.Controls.Add(this.dgvEstoqueReal);
            this.gbEstoque.Controls.Add(this.txtImportarArquivo);
            this.gbEstoque.Controls.Add(this.btnImportar);
            this.gbEstoque.Location = new System.Drawing.Point(16, 31);
            this.gbEstoque.Margin = new System.Windows.Forms.Padding(4);
            this.gbEstoque.Name = "gbEstoque";
            this.gbEstoque.Padding = new System.Windows.Forms.Padding(4);
            this.gbEstoque.Size = new System.Drawing.Size(1377, 674);
            this.gbEstoque.TabIndex = 7;
            this.gbEstoque.TabStop = false;
            this.gbEstoque.Text = "Estoque";
            // 
            // btnConferir
            // 
            this.btnConferir.Location = new System.Drawing.Point(1257, 23);
            this.btnConferir.Margin = new System.Windows.Forms.Padding(4);
            this.btnConferir.Name = "btnConferir";
            this.btnConferir.Size = new System.Drawing.Size(112, 46);
            this.btnConferir.TabIndex = 13;
            this.btnConferir.Text = "Conferir";
            this.btnConferir.UseVisualStyleBackColor = true;
            this.btnConferir.Click += new System.EventHandler(this.btnConferir_Click);
            // 
            // btnSelArquivo
            // 
            this.btnSelArquivo.Location = new System.Drawing.Point(485, 41);
            this.btnSelArquivo.Margin = new System.Windows.Forms.Padding(4);
            this.btnSelArquivo.Name = "btnSelArquivo";
            this.btnSelArquivo.Size = new System.Drawing.Size(44, 34);
            this.btnSelArquivo.TabIndex = 12;
            this.btnSelArquivo.Text = "...";
            this.btnSelArquivo.UseVisualStyleBackColor = true;
            this.btnSelArquivo.Click += new System.EventHandler(this.btnSelArquivo_Click);
            // 
            // lblUltAtualizacao
            // 
            this.lblUltAtualizacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUltAtualizacao.Location = new System.Drawing.Point(1003, 625);
            this.lblUltAtualizacao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUltAtualizacao.Name = "lblUltAtualizacao";
            this.lblUltAtualizacao.Size = new System.Drawing.Size(97, 23);
            this.lblUltAtualizacao.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(870, 625);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 23);
            this.label3.TabIndex = 10;
            this.label3.Text = "Últ Atualização:";
            // 
            // lblQtdeReg
            // 
            this.lblQtdeReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtdeReg.Location = new System.Drawing.Point(1273, 625);
            this.lblQtdeReg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQtdeReg.Name = "lblQtdeReg";
            this.lblQtdeReg.Size = new System.Drawing.Size(97, 23);
            this.lblQtdeReg.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1157, 625);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "Qtde Registros:";
            // 
            // dgvEstoqueReal
            // 
            this.dgvEstoqueReal.AllowUserToAddRows = false;
            this.dgvEstoqueReal.AllowUserToDeleteRows = false;
            this.dgvEstoqueReal.AllowUserToOrderColumns = true;
            this.dgvEstoqueReal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstoqueReal.Location = new System.Drawing.Point(8, 87);
            this.dgvEstoqueReal.Margin = new System.Windows.Forms.Padding(4);
            this.dgvEstoqueReal.Name = "dgvEstoqueReal";
            this.dgvEstoqueReal.ReadOnly = true;
            this.dgvEstoqueReal.Size = new System.Drawing.Size(1361, 530);
            this.dgvEstoqueReal.TabIndex = 8;
            // 
            // txtImportarArquivo
            // 
            this.txtImportarArquivo.Enabled = false;
            this.txtImportarArquivo.Location = new System.Drawing.Point(8, 47);
            this.txtImportarArquivo.Margin = new System.Windows.Forms.Padding(4);
            this.txtImportarArquivo.Name = "txtImportarArquivo";
            this.txtImportarArquivo.Size = new System.Drawing.Size(469, 22);
            this.txtImportarArquivo.TabIndex = 7;
            // 
            // btnImportar
            // 
            this.btnImportar.Location = new System.Drawing.Point(537, 33);
            this.btnImportar.Margin = new System.Windows.Forms.Padding(4);
            this.btnImportar.Name = "btnImportar";
            this.btnImportar.Size = new System.Drawing.Size(112, 46);
            this.btnImportar.TabIndex = 0;
            this.btnImportar.Text = "Importar";
            this.btnImportar.UseVisualStyleBackColor = true;
            this.btnImportar.Click += new System.EventHandler(this.btnImportar_Click);
            // 
            // lblMensagem
            // 
            this.lblMensagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensagem.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblMensagem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblMensagem.Location = new System.Drawing.Point(8, 625);
            this.lblMensagem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(836, 23);
            this.lblMensagem.TabIndex = 14;
            this.lblMensagem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmEstoqueSistema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1406, 737);
            this.Controls.Add(this.gbEstoque);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmEstoqueSistema";
            this.Text = ".: Estoque Cadastrado :.";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
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
        private System.Windows.Forms.Button btnConferir;
        public System.Windows.Forms.Label lblMensagem;
    }
}