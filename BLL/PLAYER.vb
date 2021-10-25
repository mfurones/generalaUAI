Public Class PLAYER

    Sub New()
        For i As Integer = 0 To 4
            _liDados.Add(New BE.DADO)
        Next
        _planillaBLL = New PLANILLA

    End Sub


#Region "propertys"

    Private _usuarioBE As BE.USUARIO
    Public Property usuarioBE() As BE.USUARIO
        Get
            Return _usuarioBE
        End Get
        Set(ByVal value As BE.USUARIO)
            _usuarioBE = value
        End Set
    End Property

    Private _planillaBLL As BLL.PLANILLA
    Public Property planillaBLL() As BLL.PLANILLA
        Get
            Return _planillaBLL
        End Get
        Set(ByVal value As BLL.PLANILLA)
            _planillaBLL = value
        End Set
    End Property

    Private _liDados As New List(Of BE.DADO)
    Public Property liDados() As List(Of BE.DADO)
        Get
            Return _liDados
        End Get
        Set(ByVal value As List(Of BE.DADO))
            _liDados = value
        End Set
    End Property



#End Region

#Region "metodos"




#End Region


End Class
