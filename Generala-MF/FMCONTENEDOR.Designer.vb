<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FMCONTENEDOR
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
        Me.MSContenedor = New System.Windows.Forms.MenuStrip()
        Me.PartidaNuevaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsuarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogINToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistrarseToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EstadisticasToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AcercaDeLaGeneralaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReglamentoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConcepcionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MSContenedor.SuspendLayout()
        Me.SuspendLayout()
        '
        'MSContenedor
        '
        Me.MSContenedor.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PartidaNuevaToolStripMenuItem, Me.UsuarioToolStripMenuItem, Me.HelpToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MSContenedor.Location = New System.Drawing.Point(0, 0)
        Me.MSContenedor.Name = "MSContenedor"
        Me.MSContenedor.Size = New System.Drawing.Size(864, 24)
        Me.MSContenedor.TabIndex = 1
        Me.MSContenedor.Text = "MenuContenedor"
        '
        'PartidaNuevaToolStripMenuItem
        '
        Me.PartidaNuevaToolStripMenuItem.Name = "PartidaNuevaToolStripMenuItem"
        Me.PartidaNuevaToolStripMenuItem.Size = New System.Drawing.Size(87, 20)
        Me.PartidaNuevaToolStripMenuItem.Text = "Partida &Nueva"
        '
        'UsuarioToolStripMenuItem
        '
        Me.UsuarioToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LogINToolStripMenuItem1, Me.RegistrarseToolStripMenuItem1, Me.EstadisticasToolStripMenuItem1})
        Me.UsuarioToolStripMenuItem.Name = "UsuarioToolStripMenuItem"
        Me.UsuarioToolStripMenuItem.Size = New System.Drawing.Size(55, 20)
        Me.UsuarioToolStripMenuItem.Text = "&Usuario"
        '
        'LogINToolStripMenuItem1
        '
        Me.LogINToolStripMenuItem1.Name = "LogINToolStripMenuItem1"
        Me.LogINToolStripMenuItem1.Size = New System.Drawing.Size(130, 22)
        Me.LogINToolStripMenuItem1.Text = "&Login"
        '
        'RegistrarseToolStripMenuItem1
        '
        Me.RegistrarseToolStripMenuItem1.Name = "RegistrarseToolStripMenuItem1"
        Me.RegistrarseToolStripMenuItem1.Size = New System.Drawing.Size(130, 22)
        Me.RegistrarseToolStripMenuItem1.Text = "&Registrarse"
        '
        'EstadisticasToolStripMenuItem1
        '
        Me.EstadisticasToolStripMenuItem1.Name = "EstadisticasToolStripMenuItem1"
        Me.EstadisticasToolStripMenuItem1.Size = New System.Drawing.Size(130, 22)
        Me.EstadisticasToolStripMenuItem1.Text = "&Estadisticas"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AcercaDeLaGeneralaToolStripMenuItem, Me.ReglamentoToolStripMenuItem, Me.ConcepcionToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(40, 20)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'AcercaDeLaGeneralaToolStripMenuItem
        '
        Me.AcercaDeLaGeneralaToolStripMenuItem.Name = "AcercaDeLaGeneralaToolStripMenuItem"
        Me.AcercaDeLaGeneralaToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.AcercaDeLaGeneralaToolStripMenuItem.Text = "Acerca de la &Generala"
        '
        'ReglamentoToolStripMenuItem
        '
        Me.ReglamentoToolStripMenuItem.Name = "ReglamentoToolStripMenuItem"
        Me.ReglamentoToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.ReglamentoToolStripMenuItem.Text = "&Reglamento"
        '
        'ConcepcionToolStripMenuItem
        '
        Me.ConcepcionToolStripMenuItem.Name = "ConcepcionToolStripMenuItem"
        Me.ConcepcionToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.ConcepcionToolStripMenuItem.Text = "&Concepción"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.SalirToolStripMenuItem.Text = "&Salir"
        '
        'FMCONTENEDOR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(864, 425)
        Me.Controls.Add(Me.MSContenedor)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MSContenedor
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(870, 450)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(870, 450)
        Me.Name = "FMCONTENEDOR"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FMCONTENEDOR"
        Me.MSContenedor.ResumeLayout(False)
        Me.MSContenedor.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MSContenedor As System.Windows.Forms.MenuStrip
    Friend WithEvents PartidaNuevaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UsuarioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogINToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RegistrarseToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EstadisticasToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AcercaDeLaGeneralaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReglamentoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConcepcionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
