namespace GUI
{
    partial class FMLOGIN
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
            this.BAceptar = new System.Windows.Forms.Button();
            this.BCancelar = new System.Windows.Forms.Button();
            this.TBPasswd = new System.Windows.Forms.TextBox();
            this.CBUsr = new System.Windows.Forms.ComboBox();
            this.LPasswd = new System.Windows.Forms.Label();
            this.LUsr = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BAceptar
            // 
            this.BAceptar.Location = new System.Drawing.Point(167, 113);
            this.BAceptar.Name = "BAceptar";
            this.BAceptar.Size = new System.Drawing.Size(75, 23);
            this.BAceptar.TabIndex = 8;
            this.BAceptar.Text = "&Aceptar";
            this.BAceptar.UseVisualStyleBackColor = true;
            this.BAceptar.Click += new System.EventHandler(this.BAceptar_Click);
            // 
            // BCancelar
            // 
            this.BCancelar.Location = new System.Drawing.Point(248, 113);
            this.BCancelar.Name = "BCancelar";
            this.BCancelar.Size = new System.Drawing.Size(75, 23);
            this.BCancelar.TabIndex = 9;
            this.BCancelar.Text = "&Cancelar";
            this.BCancelar.UseVisualStyleBackColor = true;
            this.BCancelar.Click += new System.EventHandler(this.BCancelar_Click);
            // 
            // TBPasswd
            // 
            this.TBPasswd.Location = new System.Drawing.Point(21, 77);
            this.TBPasswd.Name = "TBPasswd";
            this.TBPasswd.PasswordChar = '*';
            this.TBPasswd.Size = new System.Drawing.Size(300, 20);
            this.TBPasswd.TabIndex = 7;
            // 
            // CBUsr
            // 
            this.CBUsr.FormattingEnabled = true;
            this.CBUsr.Location = new System.Drawing.Point(24, 36);
            this.CBUsr.Name = "CBUsr";
            this.CBUsr.Size = new System.Drawing.Size(300, 21);
            this.CBUsr.TabIndex = 6;
            // 
            // LPasswd
            // 
            this.LPasswd.AutoSize = true;
            this.LPasswd.Location = new System.Drawing.Point(21, 60);
            this.LPasswd.Name = "LPasswd";
            this.LPasswd.Size = new System.Drawing.Size(61, 13);
            this.LPasswd.TabIndex = 4;
            this.LPasswd.Text = "Contraseña";
            // 
            // LUsr
            // 
            this.LUsr.AutoSize = true;
            this.LUsr.Location = new System.Drawing.Point(21, 19);
            this.LUsr.Name = "LUsr";
            this.LUsr.Size = new System.Drawing.Size(43, 13);
            this.LUsr.TabIndex = 5;
            this.LUsr.Text = "Usuario";
            // 
            // FMLOGIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 155);
            this.ControlBox = false;
            this.Controls.Add(this.BAceptar);
            this.Controls.Add(this.BCancelar);
            this.Controls.Add(this.TBPasswd);
            this.Controls.Add(this.CBUsr);
            this.Controls.Add(this.LPasswd);
            this.Controls.Add(this.LUsr);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FMLOGIN";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FMLOGIN";
            this.Load += new System.EventHandler(this.FMLOGIN_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button BAceptar;
        internal System.Windows.Forms.Button BCancelar;
        internal System.Windows.Forms.TextBox TBPasswd;
        internal System.Windows.Forms.ComboBox CBUsr;
        internal System.Windows.Forms.Label LPasswd;
        internal System.Windows.Forms.Label LUsr;
    }
}