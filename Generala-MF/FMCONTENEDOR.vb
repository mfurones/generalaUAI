Public Class FMCONTENEDOR

#Region "Contenedores de formularios"

    Dim unFMTablero As FMTABLERO = Nothing
    Dim unFMPartida As FMPARTIDA = Nothing
    Dim unFMLogin As FMLOGIN = Nothing
    Dim unFMRegistrarse As FMREGISTRAR = Nothing
    Dim unFMEstadistica As FMESTADISTICA = Nothing
    Dim unFMAcercaGenerala As FMACERCAGENERALA = Nothing
    Dim unFMReglamento As FMREGLAMENTO = Nothing
    Dim unFMConcepcion As FMCONCEPCION = Nothing

#End Region

    'aca se cargan todos los usuarios que se hayan logueado en el juego
    Private _liUSRLogin As New List(Of BE.USUARIO)
    Public Property liUSRLogin() As List(Of BE.USUARIO)
        Get
            Return _liUSRLogin
        End Get
        Set(ByVal value As List(Of BE.USUARIO))
            _liUSRLogin = value
        End Set
    End Property

    'aca se guardan los jugadores
    Private _liUSRPartida As New List(Of BE.USUARIO)
    Public Property liUSRPartida() As List(Of BE.USUARIO)
        Get
            Return _liUSRPartida
        End Get
        Set(ByVal value As List(Of BE.USUARIO))
            _liUSRPartida = value
        End Set
    End Property

    'Carga el formulario
    Private Sub FMCONTENEDOR_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'este es el formulario contenedor
        Me.IsMdiContainer = True

        'cargo un tablero inicial
        unFMTablero = New FMTABLERO
        unFMTablero.MdiParent = Me
        unFMTablero.TopMost = False
        unFMTablero.Enabled = False
        unFMTablero.Show()

    End Sub

#Region "menuStripContenedor"

    'partida nueva
    Private Sub PartidaNuevaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PartidaNuevaToolStripMenuItem.Click
        limpiarFM()
        unFMPartida = New FMPARTIDA
        unFMPartida.MdiParent = Me
        unFMPartida.TopMost = True
        unFMPartida.Show()
    End Sub

    'Login
    Private Sub LogINToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles LogINToolStripMenuItem1.Click
        limpiarFM()
        unFMLogin = New FMLOGIN
        unFMLogin.MdiParent = Me
        unFMLogin.TopMost = True
        unFMLogin.Show()


    End Sub

    'Registrarse
    Private Sub RegistrarseToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles RegistrarseToolStripMenuItem1.Click
        limpiarFM()
        unFMRegistrarse = New FMREGISTRAR
        unFMRegistrarse.MdiParent = Me
        unFMRegistrarse.TopMost = True
        unFMRegistrarse.Show()
    End Sub

    'Estadistica
    Private Sub EstadisticasToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles EstadisticasToolStripMenuItem1.Click
        limpiarFM()
        unFMEstadistica = New FMESTADISTICA
        unFMEstadistica.MdiParent = Me
        unFMEstadistica.TopMost = True
        unFMEstadistica.Show()
    End Sub

    'Acerca de Generala
    Private Sub AcercaDeLaGeneralaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AcercaDeLaGeneralaToolStripMenuItem.Click
        limpiarFM()
        unFMAcercaGenerala = New FMACERCAGENERALA
        unFMAcercaGenerala.MdiParent = Me
        unFMAcercaGenerala.TopMost = True
        unFMAcercaGenerala.Show()
    End Sub

    'reglamento
    Private Sub ReglamentoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReglamentoToolStripMenuItem.Click
        limpiarFM()
        unFMReglamento = New FMREGLAMENTO
        unFMReglamento.MdiParent = Me
        unFMReglamento.TopMost = True
        unFMReglamento.Show()
    End Sub

    'Concepcion
    Private Sub ConcepcionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConcepcionToolStripMenuItem.Click
        limpiarFM()
        unFMConcepcion = New FMCONCEPCION
        unFMConcepcion.MdiParent = Me
        unFMConcepcion.TopMost = True
        unFMConcepcion.Show()
    End Sub

    'Salir
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub

#End Region

    'Lanzo un nuevo tablero listo para jugar
    Public Sub nuevoJuego()
        If unFMTablero IsNot Nothing Then
            unFMTablero.Close()
            unFMTablero = Nothing
        End If
        unFMTablero = New FMTABLERO
        unFMTablero.MdiParent = Me
        unFMTablero.TopMost = False
        unFMTablero.Enabled = True
        unFMTablero.Show()
    End Sub

    'se utiliza para cerrar todos los formularios abiertos y limpiarlos
    Private Sub limpiarFM()
        If unFMPartida IsNot Nothing Then
            unFMPartida.Close()
            unFMPartida = Nothing
        End If
        If unFMLogin IsNot Nothing Then
            unFMLogin.Close()
            unFMLogin = Nothing
        End If
        If unFMRegistrarse IsNot Nothing Then
            unFMRegistrarse.Close()
            unFMRegistrarse = Nothing
        End If
        If unFMEstadistica IsNot Nothing Then
            unFMEstadistica.Close()
            unFMEstadistica = Nothing
        End If
        If unFMAcercaGenerala IsNot Nothing Then
            unFMAcercaGenerala.Close()
            unFMAcercaGenerala = Nothing
        End If
        If unFMReglamento IsNot Nothing Then
            unFMReglamento.Close()
            unFMReglamento = Nothing
        End If
        If unFMConcepcion IsNot Nothing Then
            unFMConcepcion.Close()
            unFMConcepcion = Nothing
        End If

    End Sub


End Class