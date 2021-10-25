using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;



namespace BLL
{
    public class GENERALA
    {
        public GENERALA()
        {
            _generalaBE = new BE.GENERALA();
            _dadoBLL = new BLL.DADO();
            _usuarioDAL = new DAL.USUARIO();
            _liPlayers = new List<BLL.PLAYER>();
        }

        #region property

        private BE.GENERALA _generalaBE;
        public BE.GENERALA GeneralaBE
        {
            get { return _generalaBE; }
            set { _generalaBE = value; }
        }

        private List<BLL.PLAYER> _liPlayers;
        public List<BLL.PLAYER> LiPlayers
        {
            get { return _liPlayers; }
            set { _liPlayers = value; }
        }

        private BLL.DADO _dadoBLL;
        public BLL.DADO DadoBLL
        {
            get { return _dadoBLL; }
            set { _dadoBLL = value; }
        }

        private DAL.USUARIO _usuarioDAL;

        #endregion

        #region metodos

        //reduce la cantidad de rondas
        //guarda quien es el proximo jugador
        public void turnoNext()
        {
            _generalaBE.rondas += 1;
            _generalaBE.turno = _generalaBE.rondas % _liPlayers.Count;
            //chequeo si ya finalizaron el total de rondas
            if (_generalaBE.rondas >= _generalaBE.rondasTotales)
            {
                //lanzo evento que finalizo el juego
                finJuegoEventoRaise();
            }
        }

        //agrega una lista de jugadores
        public void agregarPlayers(List<BLL.PLAYER> lp)
        {
            _liPlayers = lp;
            //cargo la cantidad de rondas totales que va a tener el juego
            //en funcion a la cantidad d jugadores
            _generalaBE.rondasTotales = _liPlayers.Count * 11;
        }

        //cuenta la cantidad de tiradas de un jugador
        public void tiradaNext()
        {
            _generalaBE.numeroJugada += 1;
        }

        #region Chequear()

        //chequea las posibilidades al tirar los dados
        public List<int> chequear(int j, int nj)
        {
            //genero un vector con los resultados segun los dados
            List<int> resultado = new List<int>();
            //chequeo si ya se obtuvo
            if (_liPlayers[j].planillaBLL.planillaBE.AnotadorValores[10] > 0)
            {
                resultado.Add(2 * generala(_liPlayers[j].liDados));
            }
            else
            {
                resultado.Add(0);
            }
            //chequea del 1 al 6
            for (int i = 1; i < 7; i++)
			{
			    resultado.Add(numero(i, _liPlayers[j].liDados));
			}
            //chequea escalera
            resultado.Add(escalera(_liPlayers[j].liDados));
            //chequea full
            resultado.Add(full(_liPlayers[j].liDados));
            //chequea poker
            resultado.Add(poker(_liPlayers[j].liDados));
            //chequea generala
            int g = generala(_liPlayers[j].liDados);
            resultado.Add(g);
            for (int i = 7; i < 10; i++)
			{
			 if (nj == 0 && resultado[i] > 0)
             {
                 resultado[i] += 5;
             }
			}
            //chequeo si hay generala servida y lanzo el evento
            if (g > 0 && nj == 0)
            {
                GeneralaServidaEventoRaise(_liPlayers[j].usuarioBE);
            }
            return resultado;
        }
        
        #region composicion chequear

        //chequea la cantidad de repeticiones de un dado y devuelve el puntaje
        public int numero(int num, List<BE.DADO> d)
        {
            int c = 0;
            foreach (BE.DADO i in d)
            {
                if (i.cara == num)
                {
                    c += num;
                }

            }
            return c;
        }

        //chequea si se produce la escalera
        public int escalera(List<BE.DADO> dl)
        {
            //funcion para ordenar con linQ
            List<BE.DADO> d = (from dado in dl orderby dado.cara ascending select dado).ToList();
            //si uno es mayor que el otro sucesivamente o viceversa, hay escalera
            if ((d[0].cara == 1 && d[1].cara == 2 && d[2].cara == 3 && d[3].cara == 4 && d[4].cara == 5) ||
                (d[0].cara == 2 && d[1].cara == 3 && d[2].cara == 4 && d[3].cara == 5 && d[4].cara == 6))
            {
                return 20;
            }
            return 0;
        }

        //chequea si se produce full
        public int full(List<BE.DADO> dl)
        {
            //funcion para ordenar
            List<BE.DADO> d = (from dado in dl orderby dado.cara ascending select dado).ToList();
            //si los primeros 3 y los ultimos 2 son iguales o los primeros dos y los ultimos 3 son iguales, hay full.
            if (d[0].cara == d[2].cara && d[3].cara == d[4].cara)
            {
                return 30;
            }
            else if (d[0].cara == d[1].cara && d[2].cara == d[4].cara)
            {
                return 30;
            }
            else
            {
                return 0;
            }
        }

        //chequea si se produce Poker
        public int poker(List<BE.DADO> dl)
        {
            //funcion para ordenar
            List<BE.DADO> d = (from dado in dl orderby dado.cara ascending select dado).ToList();
            //una ves ordenados si el primero y el ante-ultimo o el segundo y el ultimo son iguales , hay al menos 4 iguales
            if (d[0].cara == d[3].cara || d[1].cara == d[4].cara)
            {
                return 40;
            }
            return 0;
        }

        //chequea si se produce generala
        public int generala(List<BE.DADO> dl)
        {
            //funcion para ordenar
            List<BE.DADO> d = (from dado in dl orderby dado.cara ascending select dado).ToList();
            //una ves ordenados si el primero y el ante-ultimo o el segundo y el ultimo son iguales , hay al menos 4 iguales
            if (d[0].cara == d[4].cara)
            {
                return 50;
            }
            return 0;
        }

        #endregion

        #endregion

        #region eventos

        //se lanza cuando ocurre una generala servida
        public delegate void generalaServidaDelegado(BE.USUARIO jugador);
        public event generalaServidaDelegado generalaServidaEvento;
        protected virtual void GeneralaServidaEventoRaise(BE.USUARIO jugador)
        {
            if (generalaServidaEvento != null)
            {
                generalaServidaEvento(jugador);
            }
        }

        //se lanza cuando finaliza el juego.
        public delegate void finJuegoDelegado();
        public event finJuegoDelegado finJuegoEvento;
        protected virtual void finJuegoEventoRaise()
        {
            if (finJuegoEvento != null)
            {
                finJuegoEvento();
            }
        }

        #endregion

        #endregion

        #region Mapper

        #region DAL.USUARIO

        //con un usr y passwd devuelve al mismo usuario con todos los datos
        public BE.USUARIO logInUsuario(BE.USUARIO usr)
        {
            BE.USUARIO unUSR;
            //verifico que el usr y passwd sean coincidentes
            unUSR = _usuarioDAL.logInUsuario(usr);
            //si lo encuentra lo busca
            if (unUSR != null)
            {
                //lo carga completo y lo devuelve
                unUSR = _usuarioDAL.buscarUsuario(usr);
                return unUSR;
            }
            //en caso de no encontrar al usuario, devuelve vacio
            return null;
        }

        //funcion para registrar un usuario
        public bool registrarUsuario(BE.USUARIO usr)
        {
            if (_usuarioDAL.registrarUsuario(usr) > 0)
            {
                return true;
            }
            return false;
        }

        //funcion para guardar la victoria de un jugador
        public int guardarVictoria(BE.USUARIO usr)
        {
            return _usuarioDAL.guardarVictoria(usr);
        }

        //funcion para buscar todos los usuarios registrados
        public List<BE.USUARIO> ListarUSRregistrados()
        {
            //guardo una lista de usuarios
            return _usuarioDAL.ListarUSRregistrados();
        }

        //funcion para guardar la victoria de un jugador
        public int guardarPartidos(BE.USUARIO usr)
        {
            return _usuarioDAL.guardarPartidos(usr);
        }

        //funcion para buscar la estadistica de los usuarios
        public List<BE.USUARIO> listarUSRestadistica()
        {
            return _usuarioDAL.ListarUSRestadistica();
        }

        #endregion

        #endregion








    }
}
