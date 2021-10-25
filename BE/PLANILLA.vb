Public Class PLANILLA

    Sub New()
        For i As Integer = 0 To 10
            _anotadorValor.Add(0)
            _anotadorEstado.Add(True)
        Next
    End Sub

    Private _anotadorValor As New List(Of Integer)
    ''' 0 --> Generala Doble
    ''' 1 ---> 1
    ''' 2 ---> 2
    ''' 3 ---> 3
    ''' 4 ---> 4
    ''' 5 ---> 5
    ''' 6 ---> 6
    ''' 7 ---> Escalera
    ''' 8 ---> Full
    ''' 9 ---> Poker
    ''' 10 --> Generala
    Public Property anotadorValor() As List(Of Integer)
        Get
            Return _anotadorValor
        End Get
        Set(ByVal value As List(Of Integer))
            _anotadorValor = value
        End Set
    End Property

    Private _anotadorEstado As New List(Of Boolean)
    Public Property anotadorEstado() As List(Of Boolean)
        Get
            Return _anotadorEstado
        End Get
        Set(ByVal value As List(Of Boolean))
            _anotadorEstado = value
        End Set
    End Property




End Class
