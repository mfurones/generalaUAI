Public Class USUARIO

    Sub New()

    End Sub

    Private _IDusuario As Integer
    Public Property IDusuario() As Integer
        Get
            Return _IDusuario
        End Get
        Set(ByVal value As Integer)
            _IDusuario = value
        End Set
    End Property

    Private _usuario As String
    Public Property usuario() As String
        Get
            Return _usuario
        End Get
        Set(ByVal value As String)
            _usuario = value
        End Set
    End Property

    Private _passwd As String
    Public Property passwd() As String
        Get
            Return _passwd
        End Get
        Set(ByVal value As String)
            _passwd = value
        End Set
    End Property

    Private _nombre As String
    Public Property nombre() As String
        Get
            Return _nombre
        End Get
        Set(ByVal value As String)
            _nombre = value
        End Set
    End Property

    Private _apellido As String
    Public Property apellido() As String
        Get
            Return _apellido
        End Get
        Set(ByVal value As String)
            _apellido = value
        End Set
    End Property

    Private _email As String
    Public Property email() As String
        Get
            Return _email
        End Get
        Set(ByVal value As String)
            _email = value
        End Set
    End Property

    Private _sexo As String
    Public Property sexo() As String
        Get
            Return _sexo
        End Get
        Set(ByVal value As String)
            _sexo = value
        End Set
    End Property

    Private _victorias As Integer
    Public Property victorias() As Integer
        Get
            Return _victorias
        End Get
        Set(ByVal value As Integer)
            _victorias = value
        End Set
    End Property

    Private _partidos As Integer
    Public Property partidos() As Integer
        Get
            Return _partidos
        End Get
        Set(ByVal value As Integer)
            _partidos = value
        End Set
    End Property



End Class
