namespace GUI
{
    partial class FMREGISTRAR
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
            this.CBsexo = new System.Windows.Forms.ComboBox();
            this.Bcrear = new System.Windows.Forms.Button();
            this.Bsalir = new System.Windows.Forms.Button();
            this.Bvalidar = new System.Windows.Forms.Button();
            this.TBvalidar = new System.Windows.Forms.TextBox();
            this.Lsexo = new System.Windows.Forms.Label();
            this.TBmail = new System.Windows.Forms.TextBox();
            this.Lmail = new System.Windows.Forms.Label();
            this.TBapellido = new System.Windows.Forms.TextBox();
            this.Lapellido = new System.Windows.Forms.Label();
            this.TBnombre = new System.Windows.Forms.TextBox();
            this.Lnombre = new System.Windows.Forms.Label();
            this.TBpasswd2 = new System.Windows.Forms.TextBox();
            this.Lpasswd2 = new System.Windows.Forms.Label();
            this.TBpasswd1 = new System.Windows.Forms.TextBox();
            this.Lpasswd1 = new System.Windows.Forms.Label();
            this.TBusuario = new System.Windows.Forms.TextBox();
            this.Lusuario = new System.Windows.Forms.Label();
            this.TBid = new System.Windows.Forms.TextBox();
            this.Lid = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CBsexo
            // 
            this.CBsexo.FormattingEnabled = true;
            this.CBsexo.Items.AddRange(new object[] {
            "Masculino",
            "Femenino",
            "Otro"});
            this.CBsexo.Location = new System.Drawing.Point(107, 228);
            this.CBsexo.Name = "CBsexo";
            this.CBsexo.Size = new System.Drawing.Size(200, 21);
            this.CBsexo.TabIndex = 48;
            // 
            // Bcrear
            // 
            this.Bcrear.Location = new System.Drawing.Point(123, 298);
            this.Bcrear.Name = "Bcrear";
            this.Bcrear.Size = new System.Drawing.Size(89, 20);
            this.Bcrear.TabIndex = 50;
            this.Bcrear.Text = "&Crear";
            this.Bcrear.UseVisualStyleBackColor = true;
            this.Bcrear.Click += new System.EventHandler(this.Bcrear_Click);
            // 
            // Bsalir
            // 
            this.Bsalir.Location = new System.Drawing.Point(218, 298);
            this.Bsalir.Name = "Bsalir";
            this.Bsalir.Size = new System.Drawing.Size(89, 20);
            this.Bsalir.TabIndex = 32;
            this.Bsalir.Text = "&Salir";
            this.Bsalir.UseVisualStyleBackColor = true;
            this.Bsalir.Click += new System.EventHandler(this.Bsalir_Click);
            // 
            // Bvalidar
            // 
            this.Bvalidar.Location = new System.Drawing.Point(12, 254);
            this.Bvalidar.Name = "Bvalidar";
            this.Bvalidar.Size = new System.Drawing.Size(89, 20);
            this.Bvalidar.TabIndex = 33;
            this.Bvalidar.Text = "Validar";
            this.Bvalidar.UseVisualStyleBackColor = true;
            this.Bvalidar.Click += new System.EventHandler(this.Bvalidar_Click);
            // 
            // TBvalidar
            // 
            this.TBvalidar.Location = new System.Drawing.Point(107, 254);
            this.TBvalidar.Name = "TBvalidar";
            this.TBvalidar.Size = new System.Drawing.Size(200, 20);
            this.TBvalidar.TabIndex = 49;
            // 
            // Lsexo
            // 
            this.Lsexo.AutoSize = true;
            this.Lsexo.Location = new System.Drawing.Point(9, 231);
            this.Lsexo.Name = "Lsexo";
            this.Lsexo.Size = new System.Drawing.Size(36, 13);
            this.Lsexo.TabIndex = 35;
            this.Lsexo.Text = "SEXO";
            // 
            // TBmail
            // 
            this.TBmail.Location = new System.Drawing.Point(107, 202);
            this.TBmail.Name = "TBmail";
            this.TBmail.Size = new System.Drawing.Size(200, 20);
            this.TBmail.TabIndex = 46;
            // 
            // Lmail
            // 
            this.Lmail.AutoSize = true;
            this.Lmail.Location = new System.Drawing.Point(9, 205);
            this.Lmail.Name = "Lmail";
            this.Lmail.Size = new System.Drawing.Size(42, 13);
            this.Lmail.TabIndex = 36;
            this.Lmail.Text = "E-MAIL";
            // 
            // TBapellido
            // 
            this.TBapellido.Location = new System.Drawing.Point(107, 176);
            this.TBapellido.Name = "TBapellido";
            this.TBapellido.Size = new System.Drawing.Size(200, 20);
            this.TBapellido.TabIndex = 47;
            // 
            // Lapellido
            // 
            this.Lapellido.AutoSize = true;
            this.Lapellido.Location = new System.Drawing.Point(9, 179);
            this.Lapellido.Name = "Lapellido";
            this.Lapellido.Size = new System.Drawing.Size(59, 13);
            this.Lapellido.TabIndex = 38;
            this.Lapellido.Text = "APELLIDO";
            // 
            // TBnombre
            // 
            this.TBnombre.Location = new System.Drawing.Point(107, 150);
            this.TBnombre.Name = "TBnombre";
            this.TBnombre.Size = new System.Drawing.Size(200, 20);
            this.TBnombre.TabIndex = 45;
            // 
            // Lnombre
            // 
            this.Lnombre.AutoSize = true;
            this.Lnombre.Location = new System.Drawing.Point(9, 153);
            this.Lnombre.Name = "Lnombre";
            this.Lnombre.Size = new System.Drawing.Size(54, 13);
            this.Lnombre.TabIndex = 40;
            this.Lnombre.Text = "NOMBRE";
            // 
            // TBpasswd2
            // 
            this.TBpasswd2.Location = new System.Drawing.Point(107, 124);
            this.TBpasswd2.Name = "TBpasswd2";
            this.TBpasswd2.PasswordChar = '*';
            this.TBpasswd2.Size = new System.Drawing.Size(200, 20);
            this.TBpasswd2.TabIndex = 44;
            // 
            // Lpasswd2
            // 
            this.Lpasswd2.AutoSize = true;
            this.Lpasswd2.Location = new System.Drawing.Point(9, 127);
            this.Lpasswd2.Name = "Lpasswd2";
            this.Lpasswd2.Size = new System.Drawing.Size(88, 13);
            this.Lpasswd2.TabIndex = 41;
            this.Lpasswd2.Text = "RE-PASSWORD";
            // 
            // TBpasswd1
            // 
            this.TBpasswd1.Location = new System.Drawing.Point(107, 98);
            this.TBpasswd1.Name = "TBpasswd1";
            this.TBpasswd1.PasswordChar = '*';
            this.TBpasswd1.Size = new System.Drawing.Size(200, 20);
            this.TBpasswd1.TabIndex = 43;
            // 
            // Lpasswd1
            // 
            this.Lpasswd1.AutoSize = true;
            this.Lpasswd1.Location = new System.Drawing.Point(9, 101);
            this.Lpasswd1.Name = "Lpasswd1";
            this.Lpasswd1.Size = new System.Drawing.Size(70, 13);
            this.Lpasswd1.TabIndex = 37;
            this.Lpasswd1.Text = "PASSWORD";
            // 
            // TBusuario
            // 
            this.TBusuario.Location = new System.Drawing.Point(107, 72);
            this.TBusuario.Name = "TBusuario";
            this.TBusuario.Size = new System.Drawing.Size(200, 20);
            this.TBusuario.TabIndex = 42;
            //this.TBusuario.TextChanged += new System.EventHandler(this.TBusuario_TextChanged);
            // 
            // Lusuario
            // 
            this.Lusuario.AutoSize = true;
            this.Lusuario.Location = new System.Drawing.Point(9, 75);
            this.Lusuario.Name = "Lusuario";
            this.Lusuario.Size = new System.Drawing.Size(56, 13);
            this.Lusuario.TabIndex = 34;
            this.Lusuario.Text = "USUARIO";
            // 
            // TBid
            // 
            this.TBid.Enabled = false;
            this.TBid.Location = new System.Drawing.Point(107, 46);
            this.TBid.Name = "TBid";
            this.TBid.Size = new System.Drawing.Size(200, 20);
            this.TBid.TabIndex = 31;
            // 
            // Lid
            // 
            this.Lid.AutoSize = true;
            this.Lid.Location = new System.Drawing.Point(9, 49);
            this.Lid.Name = "Lid";
            this.Lid.Size = new System.Drawing.Size(18, 13);
            this.Lid.TabIndex = 39;
            this.Lid.Text = "ID";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(9, 8);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(163, 13);
            this.Label1.TabIndex = 30;
            this.Label1.Text = "Completar los siguientes campos:";
            // 
            // FMREGISTRAR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 327);
            this.ControlBox = false;
            this.Controls.Add(this.CBsexo);
            this.Controls.Add(this.Bcrear);
            this.Controls.Add(this.Bsalir);
            this.Controls.Add(this.Bvalidar);
            this.Controls.Add(this.TBvalidar);
            this.Controls.Add(this.Lsexo);
            this.Controls.Add(this.TBmail);
            this.Controls.Add(this.Lmail);
            this.Controls.Add(this.TBapellido);
            this.Controls.Add(this.Lapellido);
            this.Controls.Add(this.TBnombre);
            this.Controls.Add(this.Lnombre);
            this.Controls.Add(this.TBpasswd2);
            this.Controls.Add(this.Lpasswd2);
            this.Controls.Add(this.TBpasswd1);
            this.Controls.Add(this.Lpasswd1);
            this.Controls.Add(this.TBusuario);
            this.Controls.Add(this.Lusuario);
            this.Controls.Add(this.TBid);
            this.Controls.Add(this.Lid);
            this.Controls.Add(this.Label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FMREGISTRAR";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FMREGISTRAR";
            this.Load += new System.EventHandler(this.FMREGISTRAR_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ComboBox CBsexo;
        internal System.Windows.Forms.Button Bcrear;
        internal System.Windows.Forms.Button Bsalir;
        internal System.Windows.Forms.Button Bvalidar;
        internal System.Windows.Forms.TextBox TBvalidar;
        internal System.Windows.Forms.Label Lsexo;
        internal System.Windows.Forms.TextBox TBmail;
        internal System.Windows.Forms.Label Lmail;
        internal System.Windows.Forms.TextBox TBapellido;
        internal System.Windows.Forms.Label Lapellido;
        internal System.Windows.Forms.TextBox TBnombre;
        internal System.Windows.Forms.Label Lnombre;
        internal System.Windows.Forms.TextBox TBpasswd2;
        internal System.Windows.Forms.Label Lpasswd2;
        internal System.Windows.Forms.TextBox TBpasswd1;
        internal System.Windows.Forms.Label Lpasswd1;
        internal System.Windows.Forms.TextBox TBusuario;
        internal System.Windows.Forms.Label Lusuario;
        internal System.Windows.Forms.TextBox TBid;
        internal System.Windows.Forms.Label Lid;
        internal System.Windows.Forms.Label Label1;
    }
}