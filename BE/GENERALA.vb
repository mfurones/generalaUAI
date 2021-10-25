Public Class GENERALA

    Sub New()
        _rondas = -1
        _turno = 0
        _numeroJugada = 0

    End Sub

    Private _rondas As Integer
    Public Property rondas() As Integer
        Get
            Return _rondas
        End Get
        Set(ByVal value As Integer)
            _rondas = value
        End Set
    End Property

    Private _rondasTotales As Integer
    Public Property rondasTotales() As Integer
        Get
            Return _rondasTotales
        End Get
        Set(ByVal value As Integer)
            _rondasTotales = value
        End Set
    End Property

    Private _turno As Integer
    Public Property turno() As Integer
        Get
            Return _turno
        End Get
        Set(ByVal value As Integer)
            _turno = value
        End Set
    End Property

    Private _numeroJugada As Integer
    Public Property numeroJugada() As Integer
        Get
            Return _numeroJugada
        End Get
        Set(ByVal value As Integer)
            _numeroJugada = value
        End Set
    End Property




End Class
