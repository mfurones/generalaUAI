<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FMREGISTRAR
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.CBsexo = New System.Windows.Forms.ComboBox()
        Me.Bcrear = New System.Windows.Forms.Button()
        Me.Bsalir = New System.Windows.Forms.Button()
        Me.Bvalidar = New System.Windows.Forms.Button()
        Me.TBvalidar = New System.Windows.Forms.TextBox()
        Me.Lsexo = New System.Windows.Forms.Label()
        Me.TBmail = New System.Windows.Forms.TextBox()
        Me.Lmail = New System.Windows.Forms.Label()
        Me.TBapellido = New System.Windows.Forms.TextBox()
        Me.Lapellido = New System.Windows.Forms.Label()
        Me.TBnombre = New System.Windows.Forms.TextBox()
        Me.Lnombre = New System.Windows.Forms.Label()
        Me.TBpasswd2 = New System.Windows.Forms.TextBox()
        Me.Lpasswd2 = New System.Windows.Forms.Label()
        Me.TBpasswd1 = New System.Windows.Forms.TextBox()
        Me.Lpasswd1 = New System.Windows.Forms.Label()
        Me.TBusuario = New System.Windows.Forms.TextBox()
        Me.Lusuario = New System.Windows.Forms.Label()
        Me.TBid = New System.Windows.Forms.TextBox()
        Me.Lid = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'CBsexo
        '
        Me.CBsexo.FormattingEnabled = True
        Me.CBsexo.Items.AddRange(New Object() {"Masculino", "Femenino", "Otro"})
        Me.CBsexo.Location = New System.Drawing.Point(110, 229)
        Me.CBsexo.Name = "CBsexo"
        Me.CBsexo.Size = New System.Drawing.Size(200, 21)
        Me.CBsexo.TabIndex = 27
        '
        'Bcrear
        '
        Me.Bcrear.Location = New System.Drawing.Point(126, 299)
        Me.Bcrear.Name = "Bcrear"
        Me.Bcrear.Size = New System.Drawing.Size(89, 20)
        Me.Bcrear.TabIndex = 29
        Me.Bcrear.Text = "&Crear"
        Me.Bcrear.UseVisualStyleBackColor = True
        '
        'Bsalir
        '
        Me.Bsalir.Location = New System.Drawing.Point(221, 299)
        Me.Bsalir.Name = "Bsalir"
        Me.Bsalir.Size = New System.Drawing.Size(89, 20)
        Me.Bsalir.TabIndex = 11
        Me.Bsalir.Text = "&Salir"
        Me.Bsalir.UseVisualStyleBackColor = True
        '
        'Bvalidar
        '
        Me.Bvalidar.Location = New System.Drawing.Point(15, 255)
        Me.Bvalidar.Name = "Bvalidar"
        Me.Bvalidar.Size = New System.Drawing.Size(89, 20)
        Me.Bvalidar.TabIndex = 12
        Me.Bvalidar.Text = "Validar"
        Me.Bvalidar.UseVisualStyleBackColor = True
        '
        'TBvalidar
        '
        Me.TBvalidar.Location = New System.Drawing.Point(110, 255)
        Me.TBvalidar.Name = "TBvalidar"
        Me.TBvalidar.Size = New System.Drawing.Size(200, 20)
        Me.TBvalidar.TabIndex = 28
        '
        'Lsexo
        '
        Me.Lsexo.AutoSize = True
        Me.Lsexo.Location = New System.Drawing.Point(12, 232)
        Me.Lsexo.Name = "Lsexo"
        Me.Lsexo.Size = New System.Drawing.Size(36, 13)
        Me.Lsexo.TabIndex = 14
        Me.Lsexo.Text = "SEXO"
        '
        'TBmail
        '
        Me.TBmail.Location = New System.Drawing.Point(110, 203)
        Me.TBmail.Name = "TBmail"
        Me.TBmail.Size = New System.Drawing.Size(200, 20)
        Me.TBmail.TabIndex = 25
        '
        'Lmail
        '
        Me.Lmail.AutoSize = True
        Me.Lmail.Location = New System.Drawing.Point(12, 206)
        Me.Lmail.Name = "Lmail"
        Me.Lmail.Size = New System.Drawing.Size(42, 13)
        Me.Lmail.TabIndex = 15
        Me.Lmail.Text = "E-MAIL"
        '
        'TBapellido
        '
        Me.TBapellido.Location = New System.Drawing.Point(110, 177)
        Me.TBapellido.Name = "TBapellido"
        Me.TBapellido.Size = New System.Drawing.Size(200, 20)
        Me.TBapellido.TabIndex = 26
        '
        'Lapellido
        '
        Me.Lapellido.AutoSize = True
        Me.Lapellido.Location = New System.Drawing.Point(12, 180)
        Me.Lapellido.Name = "Lapellido"
        Me.Lapellido.Size = New System.Drawing.Size(59, 13)
        Me.Lapellido.TabIndex = 17
        Me.Lapellido.Text = "APELLIDO"
        '
        'TBnombre
        '
        Me.TBnombre.Location = New System.Drawing.Point(110, 151)
        Me.TBnombre.Name = "TBnombre"
        Me.TBnombre.Size = New System.Drawing.Size(200, 20)
        Me.TBnombre.TabIndex = 24
        '
        'Lnombre
        '
        Me.Lnombre.AutoSize = True
        Me.Lnombre.Location = New System.Drawing.Point(12, 154)
        Me.Lnombre.Name = "Lnombre"
        Me.Lnombre.Size = New System.Drawing.Size(54, 13)
        Me.Lnombre.TabIndex = 19
        Me.Lnombre.Text = "NOMBRE"
        '
        'TBpasswd2
        '
        Me.TBpasswd2.Location = New System.Drawing.Point(110, 125)
        Me.TBpasswd2.Name = "TBpasswd2"
        Me.TBpasswd2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TBpasswd2.Size = New System.Drawing.Size(200, 20)
        Me.TBpasswd2.TabIndex = 23
        '
        'Lpasswd2
        '
        Me.Lpasswd2.AutoSize = True
        Me.Lpasswd2.Location = New System.Drawing.Point(12, 128)
        Me.Lpasswd2.Name = "Lpasswd2"
        Me.Lpasswd2.Size = New System.Drawing.Size(88, 13)
        Me.Lpasswd2.TabIndex = 20
        Me.Lpasswd2.Text = "RE-PASSWORD"
        '
        'TBpasswd1
        '
        Me.TBpasswd1.Location = New System.Drawing.Point(110, 99)
        Me.TBpasswd1.Name = "TBpasswd1"
        Me.TBpasswd1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TBpasswd1.Size = New System.Drawing.Size(200, 20)
        Me.TBpasswd1.TabIndex = 22
        '
        'Lpasswd1
        '
        Me.Lpasswd1.AutoSize = True
        Me.Lpasswd1.Location = New System.Drawing.Point(12, 102)
        Me.Lpasswd1.Name = "Lpasswd1"
        Me.Lpasswd1.Size = New System.Drawing.Size(70, 13)
        Me.Lpasswd1.TabIndex = 16
        Me.Lpasswd1.Text = "PASSWORD"
        '
        'TBusuario
        '
        Me.TBusuario.Location = New System.Drawing.Point(110, 73)
        Me.TBusuario.Name = "TBusuario"
        Me.TBusuario.Size = New System.Drawing.Size(200, 20)
        Me.TBusuario.TabIndex = 21
        '
        'Lusuario
        '
        Me.Lusuario.AutoSize = True
        Me.Lusuario.Location = New System.Drawing.Point(12, 76)
        Me.Lusuario.Name = "Lusuario"
        Me.Lusuario.Size = New System.Drawing.Size(56, 13)
        Me.Lusuario.TabIndex = 13
        Me.Lusuario.Text = "USUARIO"
        '
        'TBid
        '
        Me.TBid.Enabled = False
        Me.TBid.Location = New System.Drawing.Point(110, 47)
        Me.TBid.Name = "TBid"
        Me.TBid.Size = New System.Drawing.Size(200, 20)
        Me.TBid.TabIndex = 10
        '
        'Lid
        '
        Me.Lid.AutoSize = True
        Me.Lid.Location = New System.Drawing.Point(12, 50)
        Me.Lid.Name = "Lid"
        Me.Lid.Size = New System.Drawing.Size(18, 13)
        Me.Lid.TabIndex = 18
        Me.Lid.Text = "ID"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(163, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Completar los siguientes campos:"
        '
        'FMREGISTRAR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(320, 331)
        Me.ControlBox = False
        Me.Controls.Add(Me.CBsexo)
        Me.Controls.Add(Me.Bcrear)
        Me.Controls.Add(Me.Bsalir)
        Me.Controls.Add(Me.Bvalidar)
        Me.Controls.Add(Me.TBvalidar)
        Me.Controls.Add(Me.Lsexo)
        Me.Controls.Add(Me.TBmail)
        Me.Controls.Add(Me.Lmail)
        Me.Controls.Add(Me.TBapellido)
        Me.Controls.Add(Me.Lapellido)
        Me.Controls.Add(Me.TBnombre)
        Me.Controls.Add(Me.Lnombre)
        Me.Controls.Add(Me.TBpasswd2)
        Me.Controls.Add(Me.Lpasswd2)
        Me.Controls.Add(Me.TBpasswd1)
        Me.Controls.Add(Me.Lpasswd1)
        Me.Controls.Add(Me.TBusuario)
        Me.Controls.Add(Me.Lusuario)
        Me.Controls.Add(Me.TBid)
        Me.Controls.Add(Me.Lid)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FMREGISTRAR"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FMREGISTRAR"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CBsexo As System.Windows.Forms.ComboBox
    Friend WithEvents Bcrear As System.Windows.Forms.Button
    Friend WithEvents Bsalir As System.Windows.Forms.Button
    Friend WithEvents Bvalidar As System.Windows.Forms.Button
    Friend WithEvents TBvalidar As System.Windows.Forms.TextBox
    Friend WithEvents Lsexo As System.Windows.Forms.Label
    Friend WithEvents TBmail As System.Windows.Forms.TextBox
    Friend WithEvents Lmail As System.Windows.Forms.Label
    Friend WithEvents TBapellido As System.Windows.Forms.TextBox
    Friend WithEvents Lapellido As System.Windows.Forms.Label
    Friend WithEvents TBnombre As System.Windows.Forms.TextBox
    Friend WithEvents Lnombre As System.Windows.Forms.Label
    Friend WithEvents TBpasswd2 As System.Windows.Forms.TextBox
    Friend WithEvents Lpasswd2 As System.Windows.Forms.Label
    Friend WithEvents TBpasswd1 As System.Windows.Forms.TextBox
    Friend WithEvents Lpasswd1 As System.Windows.Forms.Label
    Friend WithEvents TBusuario As System.Windows.Forms.TextBox
    Friend WithEvents Lusuario As System.Windows.Forms.Label
    Friend WithEvents TBid As System.Windows.Forms.TextBox
    Friend WithEvents Lid As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
