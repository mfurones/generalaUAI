Public Class GENERALA

    Sub New()
        _generalaBE = New BE.GENERALA
        _dadoBLL = New BLL.DADO
        _usuarioDAL = New DAL.USUARIO
    End Sub

#Region "propertys"

    Private _generalaBE As BE.GENERALA
    Public Property generalaBE() As BE.GENERALA
        Get
            Return _generalaBE
        End Get
        Set(ByVal value As BE.GENERALA)
            _generalaBE = value
        End Set
    End Property

    Private _liPlayers As New List(Of BLL.PLAYER)
    Public Property liPlayers() As List(Of BLL.PLAYER)
        Get
            Return _liPlayers
        End Get
        Set(ByVal value As List(Of BLL.PLAYER))
            _liPlayers = value
        End Set
    End Property

    Private _dadoBLL As BLL.DADO
    Public Property dadoBLL() As BLL.DADO
        Get
            Return _dadoBLL
        End Get
        Set(ByVal value As BLL.DADO)
            _dadoBLL = value
        End Set
    End Property

    Private _usuarioDAL As DAL.USUARIO

#End Region

#Region "metodos"

    'reduce la cantidad de rondas
    'guarda quien es el proximo jugador
    Public Sub turnoNext()
        _generalaBE.rondas += 1
        _generalaBE.turno = _generalaBE.rondas Mod _liPlayers.Count
        If _generalaBE.rondas >= _generalaBE.rondasTotales Then
            RaiseEvent finJuego()
        End If
    End Sub

    'agrega una lista de jugadores
    Public Sub agregarPlayers(lp As List(Of BLL.PLAYER))
        _liPlayers = lp
        'cargo la cantidad de rondas totales que va a tener el juego en funcion a la cantidad d jugadores
        _generalaBE.rondasTotales = _liPlayers.Count * 11
    End Sub

    'cuenta la cantidad de tiradas de un jugador
    Public Sub TiradaNext()
        _generalaBE.numeroJugada += 1
    End Sub


#Region "private chequear()"

    'chequea las posibilidades al tirar los dados
    Public Function chequear(j As Integer, nj As Integer) As List(Of Integer)
        'genero un vector con los resultados segun los dados
        Dim resultado As New List(Of Integer)
        'chequeo si ya se obtivo
        If _liPlayers.Item(j).planillaBLL.planillaBE.anotadorValor.Item(10) Then
            resultado.Add(2 * generala(_liPlayers.Item(j).liDados))
        Else
            resultado.Add(0)
        End If
        'chequea del 1 al 6
        resultado.Add(numero(1, _liPlayers.Item(j).liDados))
        resultado.Add(numero(2, _liPlayers.Item(j).liDados))
        resultado.Add(numero(3, _liPlayers.Item(j).liDados))
        resultado.Add(numero(4, _liPlayers.Item(j).liDados))
        resultado.Add(numero(5, _liPlayers.Item(j).liDados))
        resultado.Add(numero(6, _liPlayers.Item(j).liDados))
        'chequea escalera
        resultado.Add(escalera(_liPlayers.Item(j).liDados))
        'chequea full
        resultado.Add(full(_liPlayers.Item(j).liDados))
        'chequea poker
        resultado.Add(poker(_liPlayers.Item(j).liDados))
        'chequea generala
        Dim g As Integer = generala(_liPlayers.Item(j).liDados)
        resultado.Add(g)
        For i As Integer = 7 To 9
            If nj = 0 And resultado.Item(i) Then
                resultado.Item(i) += 5
            End If
        Next
        If g And Not nj Then
            RaiseEvent generalaServida(_liPlayers.Item(j).usuarioBE)
        End If
        Return resultado
    End Function

#Region "composicion de chequear"

    'chequea la cantidad de repeticiones de un dado y devuelve el puntaje
    Private Function numero(num As Integer, ByVal d As List(Of BE.DADO)) As Integer
        Dim c As Integer = 0
        For Each i In d
            If i.cara = num Then
                c += num
            End If
        Next
        Return c
    End Function

    'chequea si se produce la escalera
    Private Function escalera(ByVal dl As List(Of BE.DADO)) As Integer
        Dim d As New List(Of BE.DADO)
        d.AddRange(dl)
        'funcion para ordenar
        d.Sort(Function(x, y) x.cara.CompareTo(y.cara))
        'si uno es mayor que el otro sucesivamente o viceversa, hay escalera
        If (d.Item(0).cara = 1 And d.Item(1).cara = 2 And d.Item(2).cara = 3 And d.Item(3).cara = 4 And d.Item(4).cara = 5) Or
            (d.Item(0).cara = 2 And d.Item(1).cara = 3 And d.Item(2).cara = 4 And d.Item(3).cara = 5 And d.Item(4).cara = 6) Then
            Return 20
        End If
        Return 0
    End Function

    'chequea si se produce full
    Private Function full(ByVal dl As List(Of BE.DADO)) As Integer
        Dim d As New List(Of BE.DADO)
        d.AddRange(dl)
        'funcion para ordenar
        d.Sort(Function(x, y) x.cara.CompareTo(y.cara))
        'si los primeros 3 y los ultimos 2 son iguales o los primeros dos y los ultimos 3 son iguales, hay poker.
        If d.Item(0).cara = d.Item(2).cara And d.Item(3).cara = d.Item(4).cara Then
            Return 30
        ElseIf d.Item(0).cara = d.Item(1).cara And d.Item(2).cara = d.Item(4).cara Then
            Return 30
        End If
        Return 0
    End Function

    'chequea si se produce Poker
    Private Function poker(ByVal dl As List(Of BE.DADO)) As Integer
        Dim d As New List(Of BE.DADO)
        d.AddRange(dl)
        'funcion para ordenar
        d.Sort(Function(x, y) x.cara.CompareTo(y.cara))
        'una ves ordenados si el primero y el ante-ultimo o el segundo y el ultimo son iguales , hay al menos 4 iguales
        If d.Item(0).cara = d.Item(3).cara Or d.Item(1).cara = d.Item(4).cara Then
            Return 40
        End If
        Return 0
    End Function

    'chequea si se produce generala
    Private Function generala(ByVal dl As List(Of BE.DADO)) As Integer
        Dim d As New List(Of BE.DADO)
        d.AddRange(dl)
        'funcion para ordenar
        d.Sort(Function(x, y) x.cara.CompareTo(y.cara))
        'una ves ordenados si el primero y el ultimo son iguales, todos son iguales
        If d.Item(0).cara = d.Item(4).cara Then
            Return 50
        End If
        Return 0
    End Function

#End Region

#End Region

#Region "Eventos"

    'se lanza cuando ocurre una generala servida
    Public Event generalaServida(jugador As BE.USUARIO)
    'se lanza cuando finaliza el juego.
    Public Event finJuego()

#End Region


#End Region

#Region "mapper"

#Region "DAL.USUARIO"

    'con un usr y passwd devuelve al mismo usuario con todos los datos
    Public Function logInUsuario(usr As BE.USUARIO) As BE.USUARIO
        Dim unUSR As BE.USUARIO
        'verifico que el usr y passwd sean coincidentes
        unUSR = _usuarioDAL.logInUsuario(usr)
        'si lo encuentra lo busca
        If unUSR IsNot Nothing Then
            'lo carga completo y lo devuelve
            unUSR = _usuarioDAL.buscarUsuario(usr)
            Return unUSR
        End If
        'para debug
        MsgBox("no se encontro un usuario")
        'en caso de no encontrar al usuario, devuelve vacio
        Return Nothing
    End Function

    'funcion para registrar un usuario
    Public Function registrarUsuario(usr As BE.USUARIO) As Boolean
        If _usuarioDAL.registrarUsuario(usr) Then
            MsgBox("el usuario " & usr.usuario & " fue registrado con exito.")
            Return True
        Else
            MsgBox("Surgio un error con la Base de Datos")
            Return False
        End If
    End Function

    'funcion para guardar la victoria de un jugador
    Public Function guardarVictoria(usr As BE.USUARIO) As Integer
        Return _usuarioDAL.guardarVictoria(usr)
    End Function

    'funcion para buscar todos los usuarios registrados
    Public Function ListarUSRregistrados() As List(Of BE.USUARIO)
        'guardo una lista de usuarios
        Dim LUR As List(Of BE.USUARIO) = _usuarioDAL.ListarUSRregistrados
        'si no encuentro usuarios registrados solicito que lo hagan
        If LUR Is Nothing Then
            MsgBox("No se encuentran usuarios registrados. Favor de registrarse.")
        End If
        Return LUR
    End Function

    'funcion para guardar la victoria de un jugador
    Public Function guardarPartidos(usr As BE.USUARIO) As Integer
        Return _usuarioDAL.guardarPartidos(usr)
    End Function

    'funcion para buscar la estadistica de los usuarios
    Public Function listarUSRestadistica() As List(Of BE.USUARIO)
        Dim LUE As List(Of BE.USUARIO) = _usuarioDAL.ListarUSRestadistica
        If LUE Is Nothing Then
            MsgBox("No se encuentran usuarios registrados. Favor de registrarse.")
        End If
        Return LUE
    End Function


#End Region

#End Region

End Class
