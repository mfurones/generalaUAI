using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//importamos la direccion de dll para trabajar con las BDs
using System.Data;
//importamos la direccion de dll para trabajar con herramientas especificas de SQLSERVER a nivel cliente
using System.Data.SqlClient;

//esta clase nos permite tener una serie de herramientas que son especificas para trabajar
//contra una BD de SQLSERVER y ser consumidas por nuestro programa
namespace DAL
{
    //implemento una interfaz como medio de compatibilidad de llamado a metodos.
    public class ACCSQLSERVER : IACCESO
    {
        public ACCSQLSERVER() { }

        #region Conexion
        //generamos una coneccion del tipo SQLserver
        SqlConnection cn = new SqlConnection();

        private void abrir()
        {
        //Initial catalog --> Nombre de la base de datos
        //= "GENERALAMF"
        //Datasourse --> Servidor de sql
        // = "UAISQL"
        //Integrated security --> La forma en que se loguea al sql (SSPI utiliza los permisos de windows)
        // = "SSPI"

            cn.ConnectionString = "Initial catalog=GENERALAMF;data source=UAISQL;Integrated Security=SSPI";
            //corroboramos si la conexion ya esta abierta
            if(cn.State != ConnectionState.Open)
            {
                cn.Open();
            }

        }

        private void cerrar()
        {
            //cierra la conexion
            cn.Close();
        }

        #endregion

        #region Interaccion con la BD de SQLSERVER

        //hacemos una lectura sobre la BD y nos traemos los valores consultados
        //se le pasa el nombre del procedimiento y opcionalmente un parametros
        //(que puede servir por ejemplo para hacer una busqueda en particular
        DataTable IACCESO.Leer(string procedimiento, IDbDataParameter[] parametros)
        {
            //generamos una tabla donde vamos a volcar los resultados de la lectura
            DataTable tabla = new DataTable();
            //generamos un adaptador que se utiliza para rellenar la tabla
            SqlDataAdapter DA = new SqlDataAdapter();
            //se le agrega un comando de SQLSERVER
            DA.SelectCommand = new SqlCommand();
            //se le pasa el nombre del procedimiento
            DA.SelectCommand.CommandText = procedimiento;
            //se indica el tipo de comando, que va a ser a traves de un procedimiento almacenado
            DA.SelectCommand.CommandType = CommandType.StoredProcedure;
            //se le pasa la conexion a la BD con la que vamos a trabajar
            DA.SelectCommand.Connection = cn;
            //consultamos si hay parametros, en caso de haberlos agregamos el parametro
            if (parametros != null)
            {
                DA.SelectCommand.Parameters.AddRange(parametros);
            }
            //abro la conexion contra la BD
            abrir();
            //lleno la tabla con lo consultado en la BD
            try
            {
                DA.Fill(tabla);
            }
            catch (Exception e)
            {
                tabla = null;
            }
            //cierro la conexion a la BD
            cerrar();
            //devuelvo la tabla rellena con la informacion de la consulta a la BD
            //(si por X motivo hay un error, devolvemos la tabla vacia)
            return tabla;
        }

        //con esta funcion vamos a hacer una escritura en la base de datos
        //le vamos a pasar a la funcion el nombre del procedimiento y una tabla con todos
        //los campos que vamos a modificar
        int IACCESO.Escribir(string procedimiento, IDbDataParameter[] parametros)
        {
            //se le agrega un comando de SQLSERVER
            SqlCommand cmd = new SqlCommand();
            //se le pasa el nombre del procedimiento
            cmd.CommandText = procedimiento;
            //se indica el tipo de comando, que va a ser a traves de un procedimiento almacenado
            cmd.CommandType = CommandType.StoredProcedure;
            //se le pasa la conexion a la BD con la que vamos a trabajar
            cmd.Connection = cn;
            //agregamos la matriz de parametros
            cmd.Parameters.AddRange(parametros);
            //abro la coneccion contra la base
            abrir();
            //realizo la ejecucion y me guardo el valor de filas modificadas
            int fa;
            try
            {
                fa = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                fa = -1;
            }
            //cierro la coneccion a la base
            cerrar();
            //devuelvo el numero de filas modificadas
            //(si fa = -1 significa que hubo un error al pedir la ejecucion)
            return fa;
        }
        
        #endregion

        #region Parametros para SQLSERVER

        //creamos una funcion con sobrecarga que se utiliza para pasar un valor sin importar el tipo
        //y este lo reconoce (gracias a la sobrecarga) y lo devuelve a traves de una interfaz
        //de este modo la devolucion de un IDbDataParameter es lo suficientemente generico (a nivel
        //de parametros) como para enviar un tipo de parametro especifico y ser reconocido recien en la BD
        
        //convierte el parametro a string de SQLSERVER
        IDbDataParameter IACCESO.CrearParametro(string nombre, string valor)
        {
            //genero un parametro del tipo SqlParameter
            SqlParameter p = new SqlParameter();
            //indico el nombre de columna que voy a trabajar
            p.ParameterName = "@" + nombre;
            //indico el tipo de dato que voy a pasar (en este caso es un string)
            p.DbType = DbType.String;
            //paso el valor del dato a trabajar en la BD
            p.Value = valor;
            //devuelvo el parametro especifico de SQLSERVER
            return p;
        }

        //convierte el parametro a integer de SQLSERVER
        IDbDataParameter IACCESO.CrearParametro(string nombre, int valor)
        {
            //genero un parametro del tipo SqlParameter
            SqlParameter p = new SqlParameter();
            //indico el nombre de columna que voy a trabajar
            p.ParameterName = "@" + nombre;
            //indico el tipo de dato que voy a pasar (en este caso es un integer)
            p.DbType = DbType.Int32;
            //paso el valor del dato a trabajar en la BD
            p.Value = valor;
            //devuelvo el parametro especifico de SQLSERVER
            return p;
        }

        #endregion
    }
}
