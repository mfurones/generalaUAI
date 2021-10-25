Public Class FMESTADISTICA
    'cargo la dll de la generala
    Dim _generalaBLL As New BLL.GENERALA


    Private Sub FMESTADISTICA_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DGVE.DataSource = Nothing
        DGVE.DataSource = _generalaBLL.listarUSRestadistica

        With DGVE
            .Columns("IDusuario").Visible = False
            .Columns("passwd").Visible = False
            .Columns("nombre").Visible = False
            .Columns("apellido").Visible = False
            .Columns("sexo").Visible = False
            .Columns("email").Visible = False

        End With


    End Sub

    Private Sub Bsalir_Click(sender As Object, e As EventArgs) Handles Bsalir.Click
        Me.Close()
    End Sub
End Class