Public Class USUARIO
    'se utiliza esta clace para una BD de SQLserver
    Dim acc As New ACCSQLSERVER

    'se utiliza esta clace para una BD de MySql
    'Dim acc As New ACCMYSQL

    Sub New()

    End Sub

#Region "metodos"

    '01 ### REGISTRAR USUARIO ###
    'funcion para registrar un usuario
    Public Function registrarUsuario(usr As BE.USUARIO) As Integer
        'genero una lista de parametros proveniente del objeto usuario
        Dim parametros(5) As System.Data.IDbDataParameter
        parametros(0) = acc.CrearParametro("usuario", usr.usuario)
        parametros(1) = acc.CrearParametro("passwd", usr.passwd)
        parametros(2) = acc.CrearParametro("nombre", usr.nombre)
        parametros(3) = acc.CrearParametro("apellido", usr.apellido)
        parametros(4) = acc.CrearParametro("email", usr.email)
        parametros(5) = acc.CrearParametro("sexo", usr.sexo)
        'ejecuto la escritura con el SP
        Dim resultado As Integer = acc.Escribir("REGISTRARUSUARIO", parametros)
        'devuelvo el estado de la escritura
        Return resultado
    End Function

    '02 ### LOGIN USUARIO ###
    'funcion para chequear un usr y un pwd
    Public Function logInUsuario(usr As BE.USUARIO) As BE.USUARIO
        'genero y paso los parametros para chequear en el SP
        Dim parametros(1) As System.Data.IDbDataParameter
        parametros(0) = acc.CrearParametro("usuario", usr.usuario)
        parametros(1) = acc.CrearParametro("passwd", usr.passwd)
        'ejecuto una lectura y la almaceno en memoria
        Dim DT As DataTable = acc.Leer("LOGINUSUARIO", parametros)
        'verifico si hubo coincidencia
        If DT.Rows.Count > 0 Then
            'cargo lo obtenido en la BD
            Dim unUsuario As New BE.USUARIO With {.usuario = usr.usuario}
            'devuelvo un usuario
            Return unUsuario
        End If
        'devuelvo nothing si no hay coincidencia
        Return Nothing
    End Function

    '03 ### BUSCAR USUARIO COMPLETO ###
    'funcion para buscar un usuario a traves del usuario
    Public Function buscarUsuario(usr As BE.USUARIO) As BE.USUARIO
        'paso como parametro el usuario para buscar con el SP
        Dim parametros(0) As System.Data.IDbDataParameter
        parametros(0) = acc.CrearParametro("usuario", usr.usuario)
        'ejecuto la busqueda del SP y lo almaceno en memoria
        Dim DT As DataTable = acc.Leer("BUSCARUSUARIO", parametros)
        'verifico si encontro algo
        If DT.Rows.Count > 0 Then
            'genero un objeto USUARIO y lo cargo con la info de la BD
            Dim unUsuario As New BE.USUARIO
            Dim dr As DataRow = DT.Rows(0)
            With unUsuario
                .IDusuario = dr("IDusuario")
                .usuario = dr("usuario")
                .nombre = dr("nombre")
                .apellido = dr("apellido")
                .email = dr("email")
                .sexo = dr("sexo")
                .victorias = dr("victorias")
                .partidos = dr("partidos")
            End With
            'devuelvo el usuario
            Return unUsuario
        End If
        'si no encontro nada devuelvo vacio
        Return Nothing
    End Function

    '04 ### LISTAR USUARIOS REGISTRADOS ###
    'funcion para buscar todos los usuarios registrados
    Public Function ListarUSRregistrados() As List(Of BE.USUARIO)
        'ejecuto la busqueda del SP y lo almaceno en memoria
        Dim DT As DataTable = acc.Leer("LISTARUSRREGISTRADOS")
        'verifico si encontro algo
        If DT.Rows.Count > 0 Then
            'genero una lista de usuarios
            Dim listUsuarios As New List(Of BE.USUARIO)
            'recorro la tabla recogida por la DB
            For Each dr As DataRow In DT.Rows
                'genero un objeto USUARIO y lo cargo con la info de la BD
                Dim unUsuario As New BE.USUARIO With {.usuario = dr("usuario")}
                'lo agrego en la lista
                listUsuarios.Add(unUsuario)
            Next
            'devuelvo la lista de usuarios
            Return listUsuarios
        End If
        'si no encontro nada devuelvo vacio
        Return Nothing
    End Function

    '05 ### GUARDAR VICTORIA ###
    'funcion para guardar la victoria de un jugador
    Public Function guardarVictoria(usr As BE.USUARIO) As Integer
        'genero una lista de parametros con lo que quiero registrar en la BD
        Dim parametros(1) As System.Data.IDbDataParameter
        parametros(0) = acc.CrearParametro("usuario", usr.usuario)
        parametros(1) = acc.CrearParametro("victorias", usr.victorias)
        'ejecuto la escritura con el SP
        Dim resultado As Integer = acc.Escribir("GUARDARVICTORIA", parametros)
        'devuelvo el estado de la escritura
        Return resultado
    End Function

    '06 ### GUARDAR PARTIDOS ###
    'funcion para guardar el partido de un jugador
    Public Function guardarPartidos(usr As BE.USUARIO) As Integer
        'genero una lista de parametros con lo que quiero registrar en la BD
        Dim parametros(1) As System.Data.IDbDataParameter
        parametros(0) = acc.CrearParametro("usuario", usr.usuario)
        parametros(1) = acc.CrearParametro("partidos", usr.partidos)
        'ejecuto la escritura con el SP
        Dim resultado As Integer = acc.Escribir("GUARDARPARTIDOS", parametros)
        'devuelvo el estado de la escritura
        Return resultado
    End Function

    '07 ### LISTAR USUARIOS ESTADISTICA ###
    'funcion para buscar todos los usuarios registrados
    Public Function ListarUSRestadistica() As List(Of BE.USUARIO)
        'ejecuto la busqueda del SP y lo almaceno en memoria
        Dim DT As DataTable = acc.Leer("LISTARUSRESTADISTICA")
        'verifico si encontro algo
        If DT.Rows.Count > 0 Then
            'genero una lista de usuarios
            Dim listUsuarios As New List(Of BE.USUARIO)
            'recorro la tabla recogida por la DB
            For Each dr As DataRow In DT.Rows
                'genero un objeto USUARIO y lo cargo con la info de la BD
                Dim unUsuario As New BE.USUARIO With {.usuario = dr("usuario"), .victorias = dr("victorias"), .partidos = dr("partidos")}
                'lo agrego en la lista
                listUsuarios.Add(unUsuario)
            Next
            'devuelvo la lista de usuarios
            Return listUsuarios
        End If
        'si no encontro nada devuelvo vacio
        Return Nothing
    End Function

#End Region

#Region "script DB SQLserver"

    '### columnas de la tabla 'USUARIO' de la DB
    'IDusuario INT
    'usuario VARCHAR(10) unique
    'passwd VARCHAR(10)
    'nombre VARCHAR(16)
    'apellido VARCHAR(16)
    'email VARCHAR(60)
    'sexo VARCHAR(10)
    'victorias INT

    '01 ### REGISTRAR USUARIO ###

    'CREATE PROCEDURE [dbo].[REGISTRARUSUARIO]
    '@usuario VARCHAR(10), @passwd VARCHAR(10), @nombre VARCHAR(16), @apellido VARCHAR(16), @email VARCHAR(60), @sexo VARCHAR(10)
    'AS 
    'BEGIN
    'DECLARE @ID INT
    'SET @ID = (SELECT COUNT(*) FROM USUARIO)
    'IF @ID > 0
    'BEGIN
    '	SET @ID = (SELECT MAX(@ID) FROM USUARIO ) 
    'END
    'SET @ID = @ID +1
    'INSERT INTO USUARIO(IDusuario, usuario, passwd, nombre, apellido, email, sexo, victorias) VALUES (@ID, @usuario, @passwd, @nombre, @apellido, @email, @sexo, 0)
    'END

    '02 ### LOGIN USUARIO ###

    'CREATE PROCEDURE [dbo].[LOGINUSUARIO]
    '@usuario VARCHAR(10), @passwd VARCHAR(10)
    'AS 
    'BEGIN 
    'SELECT usuario, passwd FROM USUARIO WHERE usuario = @usuario AND passwd = @passwd
    'END
    'GO

    '03 ### BUSCAR USUARIO COMPLETO ###

    'CREATE PROCEDURE [dbo].[BUSCARUSUARIO]
    '@usuario VARCHAR(10)
    'AS 
    'BEGIN 
    'SELECT IDusuario, usuario, nombre, apellido, email, sexo, victorias FROM USUARIO WHERE usuario = @usuario
    'END
    'GO

    '04 ### LISTAR USUARIOS REGISTRADOS ###

    'CREATE PROCEDURE [dbo].[LISTARUSRREGISTRADOS]
    'AS 
    'BEGIN 
    'SELECT usuario FROM USUARIO
    'END
    'GO

    '05 ### GUARDAR VICTORIA ###

    'CREATE PROCEDURE [dbo].[GUARDARVICTORIA]
    '@usuario VARCHAR(10), @victorias INT
    'AS 
    'BEGIN
    'UPDATE USUARIO SET victorias = @victorias WHERE usuario = @usuario
    'END

    '06 ### GUARDAR PARTIDOS ###

    'CREATE PROCEDURE [dbo].[GUARDARPARTIDOS]
    '@usuario VARCHAR(10), @partidos INT
    'AS 
    'BEGIN
    'UPDATE USUARIO SET partidos = @partidos WHERE usuario = @usuario
    'END

    '07 ### LISTAR USUARIOS ESTADISTICA ###

    'CREATE PROCEDURE [dbo].[LISTARUSRESTADISTICA]
    'AS 
    'BEGIN 
    'SELECT usuario, victorias, partidos FROM USUARIO
    'END
    'GO


#End Region


End Class
