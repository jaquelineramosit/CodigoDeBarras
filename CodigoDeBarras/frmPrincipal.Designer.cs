namespace CodigoDeBarras
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnsRelatorio = new System.Windows.Forms.MenuStrip();
            this.estoqueToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.conferirEstoqueToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.estoqueRealToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.conferirEstoqueApuradoXRealToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.estoqueRealToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.gerarEtiquetasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmRelatorio = new System.Windows.Forms.ToolStripMenuItem();
            this.custoXGrupoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.custoXSubGrupoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsRelatorio.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // mnsRelatorio
            // 
            this.mnsRelatorio.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnsRelatorio.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.estoqueToolStripMenuItem1,
            this.toolStripMenuItem1,
            this.estoqueRealToolStripMenuItem1,
            this.toolStripMenuItem2,
            this.gerarEtiquetasToolStripMenuItem,
            this.tsmRelatorio});
            this.mnsRelatorio.Location = new System.Drawing.Point(0, 0);
            this.mnsRelatorio.Name = "mnsRelatorio";
            this.mnsRelatorio.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.mnsRelatorio.Size = new System.Drawing.Size(1106, 24);
            this.mnsRelatorio.TabIndex = 1;
            this.mnsRelatorio.Text = "menuStrip1";
            // 
            // estoqueToolStripMenuItem1
            // 
            this.estoqueToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.conferirEstoqueToolStripMenuItem1,
            this.estoqueRealToolStripMenuItem,
            this.conferirEstoqueApuradoXRealToolStripMenuItem});
            this.estoqueToolStripMenuItem1.Name = "estoqueToolStripMenuItem1";
            this.estoqueToolStripMenuItem1.Size = new System.Drawing.Size(61, 20);
            this.estoqueToolStripMenuItem1.Text = "Estoque";
            // 
            // conferirEstoqueToolStripMenuItem1
            // 
            this.conferirEstoqueToolStripMenuItem1.Name = "conferirEstoqueToolStripMenuItem1";
            this.conferirEstoqueToolStripMenuItem1.Size = new System.Drawing.Size(252, 22);
            this.conferirEstoqueToolStripMenuItem1.Text = "Estoque Apurado";
            this.conferirEstoqueToolStripMenuItem1.Click += new System.EventHandler(this.estoqueApuradoToolStripMenuItem_Click);
            // 
            // estoqueRealToolStripMenuItem
            // 
            this.estoqueRealToolStripMenuItem.Name = "estoqueRealToolStripMenuItem";
            this.estoqueRealToolStripMenuItem.Size = new System.Drawing.Size(252, 22);
            this.estoqueRealToolStripMenuItem.Text = "Estoque Real";
            this.estoqueRealToolStripMenuItem.Click += new System.EventHandler(this.importarEstoqueToolStripMenuItem_Click);
            // 
            // conferirEstoqueApuradoXRealToolStripMenuItem
            // 
            this.conferirEstoqueApuradoXRealToolStripMenuItem.Name = "conferirEstoqueApuradoXRealToolStripMenuItem";
            this.conferirEstoqueApuradoXRealToolStripMenuItem.Size = new System.Drawing.Size(252, 22);
            this.conferirEstoqueApuradoXRealToolStripMenuItem.Text = "Conferir - Estoque Apurado x Real";
            this.conferirEstoqueApuradoXRealToolStripMenuItem.Click += new System.EventHandler(this.conferirEstoqueToolStripMenuItem1_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(110, 20);
            this.toolStripMenuItem1.Text = "Estoque Apurado";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.estoqueApuradoToolStripMenuItem_Click);
            // 
            // estoqueRealToolStripMenuItem1
            // 
            this.estoqueRealToolStripMenuItem1.Name = "estoqueRealToolStripMenuItem1";
            this.estoqueRealToolStripMenuItem1.Size = new System.Drawing.Size(86, 20);
            this.estoqueRealToolStripMenuItem1.Text = "Estoque Real";
            this.estoqueRealToolStripMenuItem1.Click += new System.EventHandler(this.importarEstoqueToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(152, 20);
            this.toolStripMenuItem2.Text = "Conferir - Apurado x Real";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.conferirEstoqueToolStripMenuItem1_Click);
            // 
            // gerarEtiquetasToolStripMenuItem
            // 
            this.gerarEtiquetasToolStripMenuItem.Name = "gerarEtiquetasToolStripMenuItem";
            this.gerarEtiquetasToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.gerarEtiquetasToolStripMenuItem.Text = "Gerar Etiquetas";
            this.gerarEtiquetasToolStripMenuItem.Click += new System.EventHandler(this.gerarEtiquetasToolStripMenuItem_Click);
            // 
            // tsmRelatorio
            // 
            this.tsmRelatorio.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.custoXGrupoToolStripMenuItem,
            this.custoXSubGrupoToolStripMenuItem});
            this.tsmRelatorio.Name = "tsmRelatorio";
            this.tsmRelatorio.Size = new System.Drawing.Size(71, 20);
            this.tsmRelatorio.Text = "Relatórios";
            // 
            // custoXGrupoToolStripMenuItem
            // 
            this.custoXGrupoToolStripMenuItem.Name = "custoXGrupoToolStripMenuItem";
            this.custoXGrupoToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.custoXGrupoToolStripMenuItem.Text = "Custo x Grupo";
            this.custoXGrupoToolStripMenuItem.Click += new System.EventHandler(this.custoXGrupoToolStripMenuItem_Click);
            // 
            // custoXSubGrupoToolStripMenuItem
            // 
            this.custoXSubGrupoToolStripMenuItem.Name = "custoXSubGrupoToolStripMenuItem";
            this.custoXSubGrupoToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.custoXSubGrupoToolStripMenuItem.Text = "Custo x Sub Grupo";
            this.custoXSubGrupoToolStripMenuItem.Click += new System.EventHandler(this.custoXSubGrupoToolStripMenuItem_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 497);
            this.Controls.Add(this.mnsRelatorio);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnsRelatorio;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmPrincipal";
            this.Text = "Formulário Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.mnsRelatorio.ResumeLayout(false);
            this.mnsRelatorio.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem estoqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importarEstoqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estoqueApuradoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem conferirEstoqueToolStripMenuItem;
        private System.Windows.Forms.MenuStrip mnsRelatorio;
        private System.Windows.Forms.ToolStripMenuItem estoqueToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem conferirEstoqueToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem estoqueRealToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem conferirEstoqueApuradoXRealToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem estoqueRealToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem gerarEtiquetasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmRelatorio;
        private System.Windows.Forms.ToolStripMenuItem custoXGrupoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem custoXSubGrupoToolStripMenuItem;
    }
}