Public Class FMPARTIDA

    'variables para asignar usuarios al juego
    Dim _usr1 As BE.USUARIO = Nothing
    Dim _usr2 As BE.USUARIO = Nothing
    Dim _usr3 As BE.USUARIO = Nothing
    Dim _usr4 As BE.USUARIO = Nothing


    Private Sub FMPARTIDA_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'cargo los usuarios ya logueados
        LBlogin.DataSource = Nothing
        LBlogin.DataSource = FMCONTENEDOR.liUSRLogin
        LBlogin.DisplayMember = "usuario"

        'arranca con el resto de los usuarios desactivados
        CB2.Checked = True
        CB3.Checked = True
        CB4.Checked = True


        If FMCONTENEDOR.liUSRLogin.Count Then
            BAsignar1.Enabled = True
        Else
            BAsignar1.Enabled = False
        End If

        'desactivo los botones para obligar la asignacion en el campo 1
        BAsignar2.Enabled = False
        BAsignar3.Enabled = False
        BAsignar4.Enabled = False

        'desactivo el boton crear partida hasta que ingrese un usuario
        Bpartida.Enabled = False

    End Sub


#Region "botones de asignacion de usuario"

    Private Sub BAsignar1_Click(sender As Object, e As EventArgs) Handles BAsignar1.Click
        Dim usrTemp As BE.USUARIO
        'asigna el usuario seleccionado a una variable temporal
        If LBlogin.SelectedIndex > -1 Then
            usrTemp = DirectCast(LBlogin.SelectedItem, BE.USUARIO)
            'chequeo de no duplicarlo
            If usrTemp IsNot _usr2 And usrTemp IsNot _usr3 And usrTemp IsNot _usr4 Then
                _usr1 = usrTemp
                'actualiza el nombre en el textbox
                TB1.Text = _usr1.usuario
                'habilito los botones de usuario
                BAsignar2.Enabled = True
                BAsignar3.Enabled = True
                BAsignar4.Enabled = True
                'habilito el boton de crear partida
                Bpartida.Enabled = True
            End If
        End If
        
    End Sub

    Private Sub BAsignar2_Click(sender As Object, e As EventArgs) Handles BAsignar2.Click
        'deschequeo el checkbox
        CB2.Checked = False
        Dim usrTemp As BE.USUARIO
        'asigna el usuario seleccionado a una variable temporal
        If LBlogin.SelectedIndex > -1 Then
            usrTemp = DirectCast(LBlogin.SelectedItem, BE.USUARIO)
            'chequeo de no duplicarlo
            If usrTemp IsNot _usr1 And usrTemp IsNot _usr3 And usrTemp IsNot _usr4 Then
                _usr2 = usrTemp
                'actualiza el nombre en el textbox
                TB2.Text = _usr2.usuario
            Else
                CB2.Checked = True
            End If
        End If
    End Sub

    Private Sub BAsignar3_Click(sender As Object, e As EventArgs) Handles BAsignar3.Click
        'deschequeo el checkbox
        CB3.Checked = False
        Dim usrTemp As BE.USUARIO
        'asigna el usuario seleccionado a una variable temporal
        If LBlogin.SelectedIndex > -1 Then
            usrTemp = DirectCast(LBlogin.SelectedItem, BE.USUARIO)
            'chequeo de no duplicarlo
            If usrTemp IsNot _usr2 And usrTemp IsNot _usr1 And usrTemp IsNot _usr4 Then
                _usr3 = usrTemp
                'actualiza el nombre en el textbox
                TB3.Text = _usr3.usuario
            Else
                CB3.Checked = True
            End If
        End If
    End Sub

    Private Sub BAsignar4_Click(sender As Object, e As EventArgs) Handles BAsignar4.Click
        'deschequeo el checkbox
        CB4.Checked = False
        Dim usrTemp As BE.USUARIO
        'asigna el usuario seleccionado a una variable temporal
        If LBlogin.SelectedIndex > -1 Then
            usrTemp = DirectCast(LBlogin.SelectedItem, BE.USUARIO)
            'chequeo de no duplicarlo
            If usrTemp IsNot _usr2 And usrTemp IsNot _usr3 And usrTemp IsNot _usr1 Then
                _usr4 = usrTemp
                'actualiza el nombre en el textbox
                TB4.Text = _usr4.usuario
            Else
                CB4.Checked = True
            End If
        End If
    End Sub

#End Region

#Region "checkbox"

    Private Sub CB2_CheckedChanged(sender As Object, e As EventArgs) Handles CB2.CheckedChanged
        'limpio la variable y el texto del objeto que puede contener
        If CB2.Enabled Then
            TB2.Text = ""
            _usr2 = Nothing
        End If
    End Sub

    Private Sub CB3_CheckedChanged(sender As Object, e As EventArgs) Handles CB3.CheckedChanged
        'limpio la variable y el texto del objeto que puede contener
        If CB3.Enabled Then
            TB3.Text = ""
            _usr3 = Nothing
        End If
    End Sub

    Private Sub CB4_CheckedChanged(sender As Object, e As EventArgs) Handles CB4.CheckedChanged
        'limpio la variable y el texto del objeto que puede contener
        If CB4.Enabled Then
            TB4.Text = ""
            _usr4 = Nothing
        End If
    End Sub
#End Region
    
    'Boton "Crear"
    Private Sub Bpartida_Click(sender As Object, e As EventArgs) Handles Bpartida.Click
        'genero una lista de usuarios que van a ser parte de la partida
        Dim usuarios As New List(Of BE.USUARIO)
        'chequeo de que la variable no este vacia antes de generar la lista
        If _usr1 IsNot Nothing Then
            usuarios.Add(_usr1)
        End If
        If _usr2 IsNot Nothing Then
            usuarios.Add(_usr2)
        End If
        If _usr3 IsNot Nothing Then
            usuarios.Add(_usr3)
        End If
        If _usr4 IsNot Nothing Then
            usuarios.Add(_usr4)
        End If

        FMCONTENEDOR.liUSRPartida = usuarios
        FMCONTENEDOR.nuevoJuego()
        Me.Close()

    End Sub

    'boton "Cancelar"
    Private Sub Bcancelar_Click(sender As Object, e As EventArgs) Handles Bcancelar.Click
        Me.Close()
    End Sub
End Class