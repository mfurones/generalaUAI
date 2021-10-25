'importamos la direccion de dll para trabajar con las BDs
Imports System.Data
'importamos la direccion de dll para trabajar con herramientas especificas de SQLSERVER a nivel cliente
Imports System.Data.SqlClient

'esta clase nos permite tener una serie de herramientas que son especificas para trabajar contra una BD de SQLSERVER y ser consumidas por nuestro programa
Friend Class ACCSQLSERVER
    'implemento una interfaz como medio de compatibilidad de llamado a metodos.
    Implements IACCESO

#Region "Conexion"
    'generamos una coneccion del tipo SQLserver
    Dim CN As New SqlConnection

    Private Sub Abrir()
        'Initial catalog --> Nombre de la base de datos
        'Dim IC As String = "GENERALAMF"
        'Datasourse --> Servidor de sql
        'Dim DS As String = "UAISQL"
        'Integrated security --> La forma en que se loguea al sql (SSPI utiliza los permisos de windows)
        'Dim IntS As String = "SSPI"
        'pasamos los parametros para la conexion
        'CN.ConnectionString = "Initial catalog='" & IC & "';data source='" & DS & "';Integrated Security='" & IntS

        CN.ConnectionString = "Initial catalog=GENERALAMF;data source=UAISQL;Integrated Security=SSPI"
        'corroboramos si la conexion ya esta abierta
        If (CN.State <> ConnectionState.Open) Then
            'abre la conexion
            CN.Open()
        End If

    End Sub

    Private Sub Cerrar()
        'cierra la conexion
        CN.Close()
    End Sub
#End Region

#Region "Interaccion con la BD de SQLSERVER"
    'hacemos una lectura sobre la BD y nos traemos los valores consultados
    'se le pasa el nombre del procedimiento y opcionalmente un parametros (que puede servir por ejemplo para hacer una busqueda en particular
    Public Function Leer(procedimiento As String, Optional parametros() As IDbDataParameter = Nothing) As DataTable Implements IACCESO.Leer
        'generamos una tabla donde vamos a volcar los resultados de la lectura
        Dim tabla As New DataTable
        'generamos un adaptador que se utiliza para rellenar la tabla
        Dim DA As New SqlDataAdapter
        'se le agrega un comando de SQLSERVER
        DA.SelectCommand = New SqlCommand
        With DA.SelectCommand
            'se le pasa el nombre del procedimiento
            .CommandText = procedimiento
            'se indica el tipo de comando, que va a ser a traves de un procedimiento almacenado
            .CommandType = CommandType.StoredProcedure
            'se le pasa la conexion a la BD con la que vamos a trabajar
            .Connection = CN
            'consultamos si hay parametros, en caso de haberlos agregamos el parametro
            If parametros IsNot Nothing Then
                .Parameters.AddRange(parametros)
            End If
        End With
        'abro la conexion contra la BD
        Abrir()
        'lleno la tabla con lo consultado en la BD
        Try
            DA.Fill(tabla)
        Catch ex As Exception
            tabla = Nothing
        End Try
        'cierro la conexion a la BD
        Cerrar()
        'devuelvo la tabla rellena con la informacion de la consulta a la BD (si por X motivo hay un error, devolvemos la tabla vacia)
        Return tabla
    End Function

    'con esta funcion vamos a hacer una escritura en la base de datos
    'le vamos a pasar a la funcion el nombre del procedimiento y una tabla con todos los campos que vamos a modificar
    Public Function Escribir(procedimiento As String, parametros() As IDbDataParameter) As Integer Implements IACCESO.Escribir
        'se le agrega un comando de SQLSERVER
        Dim cmd As New SqlCommand
        With cmd
            'se le pasa el nombre del procedimiento
            .CommandText = procedimiento
            'se indica el el momando va a ser a travez de un procedimiento almacenado
            .CommandType = CommandType.StoredProcedure
            'se indica el tipo de comando, que va a ser a traves de un procedimiento almacenado
            .Connection = CN
            'agregamos la matriz de parametros
            .Parameters.AddRange(parametros)
        End With
        'abro la coneccion contra la base
        Abrir()
        'realizo la ejecucion y me guardo el valor de filas modificadas
        Dim fa As Integer
        Try
            fa = cmd.ExecuteNonQuery
        Catch ex As Exception
            fa = -1
        End Try
        'cierro la coneccion a la base
        Cerrar()
        'devuelvo el numero de filas modificadas (si fa = -1 significa que hubo un error al pedir la ejecucion)
        Return fa
    End Function
#End Region

#Region "Parametros para SQLSERVER"

    'creamos una funcion con sobrecarga que se utiliza para pasar un valor sin importar el tipo y este lo reconoce (gracias a la sobrecarga) y lo devuelve a traves de una interfaz
    'de este modo la devolucion de un IDbDataParameter es lo suficientemente generico (a nivel de parametros) como para enviar un tipo de parametro especifico y ser reconocido recien'
    'en la BD

    'convierte el parametro a string de SQLSERVER
    Public Function CrearParametro(nombre As String, valor As String) As IDbDataParameter Implements IACCESO.CrearParametro
        'genero un parametro del tipo SqlParameter
        Dim p As New SqlParameter
        'indico el nombre de columna que voy a trabajar
        p.ParameterName = "@" + nombre
        'indico el tipo de dato que voy a pasar (en este caso es un string)
        p.DbType = DbType.String
        'paso el valor del dato a trabajar en la BD
        p.Value = valor
        'devuelvo el parametro especifico de SQLSERVER
        Return p
    End Function

    'convierte el parametro a integer de SQLSERVER
    Public Function CrearParametro(nombre As String, valor As Integer) As IDbDataParameter Implements IACCESO.CrearParametro
        Dim p As New SqlParameter
        p.ParameterName = "@" + nombre
        'indico el tipo de dato que voy a pasar (en este caso es un integer)
        p.DbType = DbType.Int32
        p.Value = valor
        Return p
    End Function

#End Region

End Class
