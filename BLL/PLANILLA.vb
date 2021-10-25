Public Class PLANILLA

    Sub New()
        _planillaBE = New BE.PLANILLA
    End Sub

#Region "propertys"
    Private _planillaBE As BE.PLANILLA
    'guarda un objeto BE.PLANILLA
    Public ReadOnly Property planillaBE() As BE.PLANILLA
        Get
            Return _planillaBE
        End Get
    End Property

#End Region
    

#Region "Metodos"
    'agrega un puntaje en la anotador de la planilla y cambia su estado
    Public Sub puntuar(posicion As Integer, valor As Integer)
        _planillaBE.anotadorValor.Item(posicion) = valor
        _planillaBE.anotadorEstado.Item(posicion) = False
    End Sub

    'suma los puntajes actuales y devuelve el resultado
    Public Function resultado() As Integer
        Dim total As Integer = 0
        For Each i In _planillaBE.anotadorValor
            total += i
        Next
        Return total
    End Function
#End Region
    

    


End Class
