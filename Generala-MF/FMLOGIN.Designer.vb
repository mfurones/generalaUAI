<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FMLOGIN
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
        Me.LUsr = New System.Windows.Forms.Label()
        Me.LPasswd = New System.Windows.Forms.Label()
        Me.CBUsr = New System.Windows.Forms.ComboBox()
        Me.TBPasswd = New System.Windows.Forms.TextBox()
        Me.BCancelar = New System.Windows.Forms.Button()
        Me.BAceptar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LUsr
        '
        Me.LUsr.AutoSize = True
        Me.LUsr.Location = New System.Drawing.Point(13, 13)
        Me.LUsr.Name = "LUsr"
        Me.LUsr.Size = New System.Drawing.Size(43, 13)
        Me.LUsr.TabIndex = 0
        Me.LUsr.Text = "Usuario"
        '
        'LPasswd
        '
        Me.LPasswd.AutoSize = True
        Me.LPasswd.Location = New System.Drawing.Point(13, 54)
        Me.LPasswd.Name = "LPasswd"
        Me.LPasswd.Size = New System.Drawing.Size(61, 13)
        Me.LPasswd.TabIndex = 0
        Me.LPasswd.Text = "Contraseña"
        '
        'CBUsr
        '
        Me.CBUsr.FormattingEnabled = True
        Me.CBUsr.Location = New System.Drawing.Point(16, 30)
        Me.CBUsr.Name = "CBUsr"
        Me.CBUsr.Size = New System.Drawing.Size(300, 21)
        Me.CBUsr.TabIndex = 1
        '
        'TBPasswd
        '
        Me.TBPasswd.Location = New System.Drawing.Point(13, 71)
        Me.TBPasswd.Name = "TBPasswd"
        Me.TBPasswd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TBPasswd.Size = New System.Drawing.Size(300, 20)
        Me.TBPasswd.TabIndex = 2
        '
        'BCancelar
        '
        Me.BCancelar.Location = New System.Drawing.Point(240, 107)
        Me.BCancelar.Name = "BCancelar"
        Me.BCancelar.Size = New System.Drawing.Size(75, 23)
        Me.BCancelar.TabIndex = 3
        Me.BCancelar.Text = "&Cancelar"
        Me.BCancelar.UseVisualStyleBackColor = True
        '
        'BAceptar
        '
        Me.BAceptar.Location = New System.Drawing.Point(159, 107)
        Me.BAceptar.Name = "BAceptar"
        Me.BAceptar.Size = New System.Drawing.Size(75, 23)
        Me.BAceptar.TabIndex = 3
        Me.BAceptar.Text = "&Aceptar"
        Me.BAceptar.UseVisualStyleBackColor = True
        '
        'FMLOGIN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(344, 155)
        Me.ControlBox = False
        Me.Controls.Add(Me.BAceptar)
        Me.Controls.Add(Me.BCancelar)
        Me.Controls.Add(Me.TBPasswd)
        Me.Controls.Add(Me.CBUsr)
        Me.Controls.Add(Me.LPasswd)
        Me.Controls.Add(Me.LUsr)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(350, 180)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(350, 180)
        Me.Name = "FMLOGIN"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FMLOGIN"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LUsr As System.Windows.Forms.Label
    Friend WithEvents LPasswd As System.Windows.Forms.Label
    Friend WithEvents CBUsr As System.Windows.Forms.ComboBox
    Friend WithEvents TBPasswd As System.Windows.Forms.TextBox
    Friend WithEvents BCancelar As System.Windows.Forms.Button
    Friend WithEvents BAceptar As System.Windows.Forms.Button
End Class
