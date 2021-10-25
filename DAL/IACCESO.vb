'Genero una interfaz de accesos para unificar los metodos que me van a permitir hacer una acceso a una BD
'e independizar la implementacion segun el motor de BD que utilice
Friend Interface IACCESO
    'metodo para realizar una lectura
    Function Leer(procedimiento As String, Optional parametros() As IDbDataParameter = Nothing) As DataTable
    'metodo para realizar una escritura
    Function Escribir(procedimiento As String, parametros() As IDbDataParameter) As Integer
    'metodo para establecer un parametro del tipo string
    Function CrearParametro(nombre As String, valor As String) As IDbDataParameter
    'metodo para establecer un parametro del tipo integer
    Function CrearParametro(nombre As String, valor As Integer) As IDbDataParameter

End Interface
