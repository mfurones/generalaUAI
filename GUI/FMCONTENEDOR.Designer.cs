namespace GUI
{
    partial class FMCONTENEDOR
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
            this.MSContenedor = new System.Windows.Forms.MenuStrip();
            this.partidaNuevaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estadisticasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeLaGeneralaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reglamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.concepciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MSContenedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // MSContenedor
            // 
            this.MSContenedor.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.partidaNuevaToolStripMenuItem,
            this.usuarioToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.MSContenedor.Location = new System.Drawing.Point(0, 0);
            this.MSContenedor.Name = "MSContenedor";
            this.MSContenedor.Size = new System.Drawing.Size(864, 24);
            this.MSContenedor.TabIndex = 1;
            this.MSContenedor.Text = "menuStrip1";
            // 
            // partidaNuevaToolStripMenuItem
            // 
            this.partidaNuevaToolStripMenuItem.Name = "partidaNuevaToolStripMenuItem";
            this.partidaNuevaToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.partidaNuevaToolStripMenuItem.Text = "Partida &Nueva";
            this.partidaNuevaToolStripMenuItem.Click += new System.EventHandler(this.partidaNuevaToolStripMenuItem_Click);
            // 
            // usuarioToolStripMenuItem
            // 
            this.usuarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem,
            this.registrarseToolStripMenuItem,
            this.estadisticasToolStripMenuItem});
            this.usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            this.usuarioToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.usuarioToolStripMenuItem.Text = "&Usuario";
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.loginToolStripMenuItem.Text = "&Login";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // registrarseToolStripMenuItem
            // 
            this.registrarseToolStripMenuItem.Name = "registrarseToolStripMenuItem";
            this.registrarseToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.registrarseToolStripMenuItem.Text = "&Registrarse";
            this.registrarseToolStripMenuItem.Click += new System.EventHandler(this.registrarseToolStripMenuItem_Click);
            // 
            // estadisticasToolStripMenuItem
            // 
            this.estadisticasToolStripMenuItem.Name = "estadisticasToolStripMenuItem";
            this.estadisticasToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.estadisticasToolStripMenuItem.Text = "&Estadísticas";
            this.estadisticasToolStripMenuItem.Click += new System.EventHandler(this.estadisticasToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDeLaGeneralaToolStripMenuItem,
            this.reglamentoToolStripMenuItem,
            this.concepciónToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // acercaDeLaGeneralaToolStripMenuItem
            // 
            this.acercaDeLaGeneralaToolStripMenuItem.Name = "acercaDeLaGeneralaToolStripMenuItem";
            this.acercaDeLaGeneralaToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.acercaDeLaGeneralaToolStripMenuItem.Text = "Acerca de la &Generala";
            this.acercaDeLaGeneralaToolStripMenuItem.Click += new System.EventHandler(this.acercaDeLaGeneralaToolStripMenuItem_Click);
            // 
            // reglamentoToolStripMenuItem
            // 
            this.reglamentoToolStripMenuItem.Name = "reglamentoToolStripMenuItem";
            this.reglamentoToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.reglamentoToolStripMenuItem.Text = "&Reglamento";
            this.reglamentoToolStripMenuItem.Click += new System.EventHandler(this.reglamentoToolStripMenuItem_Click);
            // 
            // concepciónToolStripMenuItem
            // 
            this.concepciónToolStripMenuItem.Name = "concepciónToolStripMenuItem";
            this.concepciónToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.concepciónToolStripMenuItem.Text = "&Concepción";
            this.concepciónToolStripMenuItem.Click += new System.EventHandler(this.concepciónToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.salirToolStripMenuItem.Text = "&Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // FMCONTENEDOR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 425);
            this.Controls.Add(this.MSContenedor);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.MSContenedor;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(870, 450);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(870, 450);
            this.Name = "FMCONTENEDOR";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generala";
            this.Load += new System.EventHandler(this.FMCONTENEDOR_Load);
            this.MSContenedor.ResumeLayout(false);
            this.MSContenedor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MSContenedor;
        private System.Windows.Forms.ToolStripMenuItem partidaNuevaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estadisticasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeLaGeneralaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reglamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem concepciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
    }
}