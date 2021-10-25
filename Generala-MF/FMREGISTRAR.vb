Public Class FMREGISTRAR
    'cargo la dll del juego
    Dim _generalaBLL As BLL.GENERALA
    'es un numero que tengo que validar antes de crear al usuario
    Dim _validarCampo As Integer

    Private Sub FMREGISTRAR_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _generalaBLL = New BLL.GENERALA
        'me aseguro que los campos esten vacios
        TBid.Text = ""
        TBusuario.Text = ""
        TBpasswd1.Text = ""
        TBpasswd2.Text = ""
        TBnombre.Text = ""
        TBapellido.Text = ""
        TBmail.Text = ""
        TBvalidar.Text = ""
        CBsexo.DataSource = Nothing
        CBsexo.DataSource = {"Masculino", "Femenino", "Otro"}
        'genero un codigo validador
        _validarCampo = ValidarRandom()
        Bvalidar.Text = _validarCampo

    End Sub

    'devuelve un numero aleatorio de 8 cifras
    Public Function ValidarRandom() As Integer
        'funcion random
        Dim R As New Random
        Return R.Next(10000000, 99999999)
    End Function

    'Boton para salir del formulario
    Private Sub Bsalir_Click(sender As Object, e As EventArgs) Handles Bsalir.Click

        Me.Close()
    End Sub

    'boton para crear un usuario
    Private Sub Bcrear_Click(sender As Object, e As EventArgs) Handles Bcrear.Click
        'valido si toda la info suministrada esta OK, entonces genero al usuario
        If validarCampos() Then
            Dim unUsuarios As New BE.USUARIO
            With unUsuarios
                .usuario = TBusuario.Text
                .passwd = TBpasswd1.Text
                .nombre = TBnombre.Text
                .apellido = TBapellido.Text
                .email = TBmail.Text
                .sexo = CBsexo.SelectedItem
            End With
            'guarda al usuario en la DB
            _generalaBLL.registrarUsuario(unUsuarios)
            Me.Close()
        Else
            MsgBox("Por favor completar correctamente los campos.")
        End If
    End Sub

    'boton para generar un nuevo captcha
    Private Sub Bvalidar_Click(sender As Object, e As EventArgs) Handles Bvalidar.Click
        _validarCampo = ValidarRandom()
        Bvalidar.Text = _validarCampo
    End Sub

    'valida todos los campos
    Private Function validarCampos() As Boolean
        Dim resultado As Boolean = True

        '### usuario ##

        If String.IsNullOrWhiteSpace(TBusuario.Text) OrElse TBusuario.Text.Length < 4 OrElse TBusuario.Text.Length > 10 Then
            TBusuario.BackColor = Color.Beige
            resultado = False
        Else
            TBusuario.BackColor = Color.White
        End If

        '### password1 ##

        If String.IsNullOrWhiteSpace(TBpasswd1.Text) OrElse TBpasswd1.Text.Length < 4 OrElse TBpasswd1.Text.Length > 10 Then
            TBpasswd1.BackColor = Color.Beige
            resultado = False
        Else
            TBpasswd1.BackColor = Color.White
        End If

        '### password2 ##

        If String.IsNullOrWhiteSpace(TBpasswd2.Text) OrElse TBpasswd2.Text.Length < 4 OrElse TBpasswd2.Text.Length > 10 OrElse TBpasswd1.Text <> TBpasswd2.Text Then

            TBpasswd2.BackColor = Color.Beige
            resultado = False
        Else
            TBpasswd2.BackColor = Color.White
        End If

        '### Nombre##

        If String.IsNullOrWhiteSpace(TBnombre.Text) OrElse TBnombre.Text.Length > 16 Then
            TBnombre.BackColor = Color.Beige
            resultado = False
        Else
            TBnombre.BackColor = Color.White
        End If

        '### Apellido ###

        If String.IsNullOrWhiteSpace(TBapellido.Text) OrElse TBapellido.Text.Length > 16 Then
            TBapellido.BackColor = Color.Beige
            resultado = False
        Else
            TBapellido.BackColor = Color.White
        End If

        '### e-mail ###

        If String.IsNullOrWhiteSpace(TBmail.Text) OrElse TBmail.Text.Length > 60 Then
            TBmail.BackColor = Color.Beige
            resultado = False
        Else
            TBmail.BackColor = Color.White
        End If

        '### validar ###

        If String.IsNullOrWhiteSpace(TBvalidar.Text) OrElse _validarCampo <> Integer.Parse(TBvalidar.Text) Then
            TBvalidar.BackColor = Color.Beige
            resultado = False
        Else
            TBvalidar.BackColor = Color.White
        End If

        Return resultado
    End Function



End Class