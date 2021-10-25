<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FMESTADISTICA
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
        Me.DGVE = New System.Windows.Forms.DataGridView()
        Me.Bsalir = New System.Windows.Forms.Button()
        CType(Me.DGVE, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGVE
        '
        Me.DGVE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVE.Location = New System.Drawing.Point(13, 13)
        Me.DGVE.Name = "DGVE"
        Me.DGVE.Size = New System.Drawing.Size(349, 258)
        Me.DGVE.TabIndex = 0
        '
        'Bsalir
        '
        Me.Bsalir.Location = New System.Drawing.Point(287, 277)
        Me.Bsalir.Name = "Bsalir"
        Me.Bsalir.Size = New System.Drawing.Size(75, 23)
        Me.Bsalir.TabIndex = 1
        Me.Bsalir.Text = "&Salir"
        Me.Bsalir.UseVisualStyleBackColor = True
        '
        'FMESTADISTICA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(378, 312)
        Me.ControlBox = False
        Me.Controls.Add(Me.Bsalir)
        Me.Controls.Add(Me.DGVE)
        Me.DoubleBuffered = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FMESTADISTICA"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FMESTADISTICA"
        Me.TopMost = True
        CType(Me.DGVE, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DGVE As System.Windows.Forms.DataGridView
    Friend WithEvents Bsalir As System.Windows.Forms.Button
End Class
