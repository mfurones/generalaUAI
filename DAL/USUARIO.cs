using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;

namespace DAL
{
    public class USUARIO
    {
        //va a contener las herramientas para acceder a la BD
        private IACCESO acc;

        //se utiliza esta clace para una BD de MySql
        //private ACCSQLSERVER acc = new ACCMYSQL();

        public USUARIO()
        {
            //se utiliza esta clase para una BD de SQLserver
            acc = new ACCSQLSERVER();
            //se utiliza esta clase para una BD de MySql
            //acc = new ACCMYSQL();
        }

        
        #region metodos

        //01 ### REGISTRAR USUARIO ###
        //funcion para registrar un usuario
        public int registrarUsuario(BE.USUARIO usr)
        {
            //genero una lista de parametros proveniente del objeto usuario
            IDbDataParameter[] parametros = new IDbDataParameter[5];
            parametros[0] = acc.CrearParametro("usuario", usr.usuario);
            parametros[1] = acc.CrearParametro("passwd", usr.passwd);
            parametros[2] = acc.CrearParametro("nombre", usr.nombre);
            parametros[3] = acc.CrearParametro("apellido", usr.apellido);
            parametros[4] = acc.CrearParametro("email", usr.email);
            parametros[5] = acc.CrearParametro("sexo", usr.sexo);
            //ejecuto la escritura con el SP
            int resultado = acc.Escribir("REGISTRARUSUARIO", parametros);
            //devuelvo el estado de la escritura
            return resultado;
            }

        //02 ### LOGIN USUARIO ###
        //funcion para chequear un usr y un pwd
        public BE.USUARIO logInUsuario(BE.USUARIO usr)
        {
            //genero y paso los parametros para chequear en el SP
            IDbDataParameter[] parametros = new IDbDataParameter[1];
            parametros[0] = acc.CrearParametro("usuario", usr.usuario);
            parametros[1] = acc.CrearParametro("passwd", usr.passwd);
            //ejecuto una lectura y la almaceno en memoria
            DataTable DT = acc.Leer("LOGINUSUARIO", parametros);
            //verifico si hubo coincidencia
            if (DT.Rows.Count > 0)
            {
                //cargo lo obtenido en la BD
                BE.USUARIO unUsuario = new BE.USUARIO { usuario = usr.usuario };
                //devuelvo un usuario
                return unUsuario;
            }
            //devuelvo null si no hay coincidencia
            return null;

            
        }

        //03 ### BUSCAR USUARIO COMPLETO ###
        //funcion para buscar un usuario a traves del usuario
        public BE.USUARIO buscarUsuario(BE.USUARIO usr)
        {
            //paso como parametro el usuario para buscar con el SP
            IDbDataParameter[] parametros = new IDbDataParameter[0];
            parametros[0] = acc.CrearParametro("usuario", usr.usuario);
            //ejecuto la busqueda del SP y lo almaceno en memoria
            DataTable DT = acc.Leer("BUSCARUSUARIO", parametros);
            //verifico si encontro algo
            if (DT.Rows.Count > 0)
            {
                BE.USUARIO unUsuario = new BE.USUARIO();
                DataRow dr = DT.Rows[0];
                unUsuario.IDusuario = (int)dr["IDusuario"];
                unUsuario.usuario = (string)dr["usuario"];
                unUsuario.nombre = (string)dr["nombre"];
                unUsuario.apellido = (string)dr["apellido"];
                unUsuario.email = (string)dr["email"];
                unUsuario.sexo = (string)dr["sexo"];
                unUsuario.victorias = (int)dr["victorias"];
                unUsuario.partidos = (int)dr["partidos"];
                //devuelvo el usuario
                return unUsuario;
            }
            //si no encontro nada devuelvo vacio
            return null;
        }

        //04 ### LISTAR USUARIOS REGISTRADOS ###
        //funcion para buscar todos los usuarios registrados
        public List<BE.USUARIO> ListarUSRregistrados()
        {
            //ejecuto la busqueda del SP y lo almaceno en memoria
            DataTable DT = acc.Leer("LISTARUSRREGISTRADOS", null);
            //verifico si encontro algo
            if (DT.Rows.Count > 0)
            {
                //genero una lista de usuarios
                List<BE.USUARIO> listUsuarios = new List<BE.USUARIO>();
                //'recorro la tabla recogida por la DB
                foreach (DataRow dr in DT.Rows)
                {
                    //genero un objeto USUARIO y lo cargo con la info de la BD
                    BE.USUARIO unUsuario = new BE.USUARIO {usuario = (string)dr["usuario"]};
                    //lo agrego en la lista
                    listUsuarios.Add(unUsuario);
                }
                //devuelvo la lista de usuarios
                return listUsuarios;
            }
            //si no encontro nada devuelvo vacio
            return null;
        }

        //05 ### GUARDAR VICTORIA ###
        //funcion para guardar la victoria de un jugador
        public int guardarVictoria(BE.USUARIO usr)
        {
            //genero una lista de parametros con lo que quiero registrar en la BD
            IDbDataParameter[] parametros = new IDbDataParameter[1];
            parametros[0] = acc.CrearParametro("usuario", usr.usuario);
            parametros[1] = acc.CrearParametro("victorias", usr.victorias);
            //ejecuto la escritura con el SP
            int resultado = acc.Escribir("GUARDARVICTORIA", parametros);
            //devuelvo el estado de la escritura
            return resultado;
        }

        //06 ### GUARDAR PARTIDOS ###
        //funcion para guardar el partido de un jugador
        public int guardarPartidos(BE.USUARIO usr)
        {
            IDbDataParameter[] parametros = new IDbDataParameter[1];
            parametros[0] = acc.CrearParametro("usuario", usr.usuario);
            parametros[1] = acc.CrearParametro("partidos", usr.partidos);
            //ejecuto la escritura con el SP
            int resultado = acc.Escribir("GUARDARPARTIDOS", parametros);
            //devuelvo el estado de la escritura
            return resultado;
        }

        //07 ### LISTAR USUARIOS ESTADISTICA ###
        //funcion para buscar todos los usuarios registrados
        public List<BE.USUARIO> ListarUSRestadistica()
        {
            //ejecuto la busqueda del SP y lo almaceno en memoria
            DataTable DT = acc.Leer("LISTARUSRESTADISTICA", null);
            //verifico si encontro algo
            if (DT.Rows.Count > 0)
            {
                //genero una lista de usuarios
                List<BE.USUARIO> listaUsuarios = new List<BE.USUARIO>();
                //recorro la tabla recogida por la DB
                foreach (DataRow dr in DT.Rows)
	            {
		            //genero un objeto USUARIO y lo cargo con la info de la BD
                    BE.USUARIO unUsuario = new BE.USUARIO {usuario = (string)dr["usuario"], victorias = (int)dr["victorias"], partidos = (int)dr["partidos"]};
                    //lo agrego en la lista
                    listaUsuarios.Add(unUsuario);
	            }
                return listaUsuarios;
            }
            //si no encontro nada devuelvo vacio
            return null;
        }

        #endregion

        #region script DB SQLserver

    //### columnas de la tabla 'USUARIO' de la DB
    //IDusuario INT
    //usuario VARCHAR(10) unique
    //passwd VARCHAR(10)
    //nombre VARCHAR(16)
    //apellido VARCHAR(16)
    //email VARCHAR(60)
    //sexo VARCHAR(10)
    //victorias INT

    //01 ### REGISTRAR USUARIO ###

    //CREATE PROCEDURE [dbo].[REGISTRARUSUARIO]
    //@usuario VARCHAR(10), @passwd VARCHAR(10), @nombre VARCHAR(16), @apellido VARCHAR(16), @email VARCHAR(60), @sexo VARCHAR(10)
    //AS 
    //BEGIN
    //DECLARE @ID INT
    //SET @ID = (SELECT COUNT(*) FROM USUARIO)
    //IF @ID > 0
    //BEGIN
    //	SET @ID = (SELECT MAX(@ID) FROM USUARIO ) 
    //END
    //SET @ID = @ID +1
    //INSERT INTO USUARIO(IDusuario, usuario, passwd, nombre, apellido, email, sexo, victorias) VALUES (@ID, @usuario, @passwd, @nombre, @apellido, @email, @sexo, 0)
    //END

    //02 ### LOGIN USUARIO ###

    //CREATE PROCEDURE [dbo].[LOGINUSUARIO]
    //@usuario VARCHAR(10), @passwd VARCHAR(10)
    //AS 
    //BEGIN 
    //SELECT usuario, passwd FROM USUARIO WHERE usuario = @usuario AND passwd = @passwd
    //END
    //GO

    //03 ### BUSCAR USUARIO COMPLETO ###

    //CREATE PROCEDURE [dbo].[BUSCARUSUARIO]
    //@usuario VARCHAR(10)
    //AS 
    //BEGIN 
    //SELECT IDusuario, usuario, nombre, apellido, email, sexo, victorias FROM USUARIO WHERE usuario = @usuario
    //END
    //GO

    //04 ### LISTAR USUARIOS REGISTRADOS ###

    //CREATE PROCEDURE [dbo].[LISTARUSRREGISTRADOS]
    //AS 
    //BEGIN 
    //SELECT usuario FROM USUARIO
    //END
    //GO

    //05 ### GUARDAR VICTORIA ###

    //CREATE PROCEDURE [dbo].[GUARDARVICTORIA]
    //@usuario VARCHAR(10), @victorias INT
    //AS 
    //BEGIN
    //UPDATE USUARIO SET victorias = @victorias WHERE usuario = @usuario
    //END

    //06 ### GUARDAR PARTIDOS ###

    //CREATE PROCEDURE [dbo].[GUARDARPARTIDOS]
    //@usuario VARCHAR(10), @partidos INT
    //AS 
    //BEGIN
    //UPDATE USUARIO SET partidos = @partidos WHERE usuario = @usuario
    //END

    //07 ### LISTAR USUARIOS ESTADISTICA ###

    //CREATE PROCEDURE [dbo].[LISTARUSRESTADISTICA]
    //AS 
    //BEGIN 
    //SELECT usuario, victorias, partidos FROM USUARIO
    //END
    //GO


#endregion


    }
}
