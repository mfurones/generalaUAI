Public Class DADO

    Sub New()

    End Sub

    'funcion random
    Dim R As New Random

    'devuelve un nuevo dado lanzado (con una cara que vario)
    Public Function lanzarDado() As BE.DADO
        Dim unDado As New BE.DADO
        unDado.cara = R.Next(1, 7)
        Return unDado
    End Function


End Class
