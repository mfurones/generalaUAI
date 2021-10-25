namespace GUI
{
    partial class FMESTADISTICA
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
            this.Bsalir = new System.Windows.Forms.Button();
            this.DGVE = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGVE)).BeginInit();
            this.SuspendLayout();
            // 
            // Bsalir
            // 
            this.Bsalir.Location = new System.Drawing.Point(290, 278);
            this.Bsalir.Name = "Bsalir";
            this.Bsalir.Size = new System.Drawing.Size(75, 23);
            this.Bsalir.TabIndex = 3;
            this.Bsalir.Text = "&Salir";
            this.Bsalir.UseVisualStyleBackColor = true;
            this.Bsalir.Click += new System.EventHandler(this.Bsalir_Click);
            // 
            // DGVE
            // 
            this.DGVE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVE.Location = new System.Drawing.Point(16, 14);
            this.DGVE.Name = "DGVE";
            this.DGVE.Size = new System.Drawing.Size(349, 258);
            this.DGVE.TabIndex = 2;
            // 
            // FMESTADISTICA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 314);
            this.ControlBox = false;
            this.Controls.Add(this.Bsalir);
            this.Controls.Add(this.DGVE);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FMESTADISTICA";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FMESTADISTICA";
            this.Load += new System.EventHandler(this.FMESTADISTICA_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVE)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button Bsalir;
        internal System.Windows.Forms.DataGridView DGVE;
    }
}