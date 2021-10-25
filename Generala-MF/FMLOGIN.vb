Public Class FMLOGIN
    Dim _generalaBLL As New BLL.GENERALA


    Private Sub BCancelar_Click(sender As Object, e As EventArgs) Handles BCancelar.Click
        Me.Close()
    End Sub


    Private Sub FMLOGIN_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'cargo una lista de usuarios registrados.
        CBUsr.DataSource = Nothing
        CBUsr.DataSource = _generalaBLL.ListarUSRregistrados
        CBUsr.DisplayMember = "usuario"


    End Sub

    Private Sub BAceptar_Click(sender As Object, e As EventArgs) Handles BAceptar.Click
        Dim unUsuario As BE.USUARIO = Nothing
        If CBUsr.SelectedIndex > -1 Then
            unUsuario = DirectCast(CBUsr.SelectedItem, BE.USUARIO)
        End If
        If unUsuario IsNot Nothing And Not String.IsNullOrWhiteSpace(TBPasswd.Text) Then
            TBPasswd.BackColor = Color.White
            unUsuario.passwd = TBPasswd.Text
            unUsuario = _generalaBLL.logInUsuario(unUsuario)
            If unUsuario IsNot Nothing Then
                FMCONTENEDOR.liUSRLogin.Add(unUsuario)
                MsgBox("Bienvenido " & unUsuario.usuario)
                Me.Close()
            Else
                MsgBox("Usuario y contraseña incorrecta, por favor intentelo de nuevo")
                TBPasswd.BackColor = Color.Beige
            End If
        Else
            TBPasswd.BackColor = Color.Beige
        End If
        

    End Sub
End Class