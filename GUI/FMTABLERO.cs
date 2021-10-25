using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class FMTABLERO : Form
    {
        public FMTABLERO()
        {
            InitializeComponent();
        }


        //variable sobre la cual el formulario guarda el juego para operar
        BLL.GENERALA _generalaBLL;

        //lista de puntajes temporales posibles de un jugador dentro de la tirada para luego ser asignada
        List<int> _tempPuntaje;

        //Carga el formulario del Tablero.
        private void FMTABLERO_Load(object sender, EventArgs e)
        {
            //cargo el juego nuevo
            _generalaBLL = new BLL.GENERALA();

            MEH manejadorEventosHandle = new MEH(_generalaBLL, this);

            _generalaBLL.generalaServidaEvento += manejadorEventosHandle.vicGS;
            _generalaBLL.finJuegoEvento += manejadorEventosHandle.vicPuntos;

            //tomo los usuarios de una nueva partida y los coloco en una lista de PLAYERS
            List<BLL.PLAYER> PL = new List<BLL.PLAYER>();
            foreach (var i in FMCONTENEDOR.liUSRPartida)
	        {
                PL.Add(new BLL.PLAYER() { usuarioBE = i });
	        }
            //le agrego la lista de players al juego
            _generalaBLL.agregarPlayers(PL);

            //pongo en 0 todos los datos de la GUI
            actualizarEstadoJuego();
            limpiaDados();
            cambiarEstadoBA(false);
            actualizarTempPuntaje(false);

        }

        #region Actualizar Labels

        //contiene todo lo que hay que refrescar por cada jugada
        private void actualizarEstadoJuego()
        {
            //genera el siguiente turno
            _generalaBLL.turnoNext();
            //muestra la tirada en curso
            LNumeroJugada.Text = _generalaBLL.GeneralaBE.rondas.ToString();

            //actualiza label Jugador
            LTurnoJugador.Text = _generalaBLL.LiPlayers[_generalaBLL.GeneralaBE.turno].usuarioBE.usuario;
            //actualiza el label de numero de tirada
            LNumeroTirada.Text = _generalaBLL.GeneralaBE.numeroJugada.ToString();
            //actualiza la tabla de puntajes para cada jugador
            for (int i = 0; i < _generalaBLL.LiPlayers.Count; i++)
            {
                refreshScore(i);
            }


        }

        private void refreshScore(int jugador)
        {
            string lb1, lb2;
            //aca guardo el control a buscar
            for (int i = 0; i < 11; i++)
            {
                lb1 = string.Format("SJ {0} A {1}", jugador + 1, i);
                foreach (Control c in this.Controls)
                {
                    if (c.Name == lb1)
                    {
                        c.Text = _generalaBLL.LiPlayers[jugador].planillaBLL.planillaBE.AnotadorValores[i].ToString();
                    }
                }
            }
            //armo un texto con el nombre del "label" que voy a buscar
            lb1 = string.Format("SJ {0} Resultado", jugador + 1);
            lb2 = string.Format("LJugador {0}", jugador + 1);
            //recorro todos los controles para encontrar el control del "label" que quiero buscar
            foreach (Control c in this.Controls)
            {
                //chequeo el nombre del "label" que busco
                if (c.Name == lb1)
                {
                    //asigno el contenido de informacion que necesito al "label" encontrado
                    c.Text = _generalaBLL.LiPlayers[jugador].planillaBLL.resultado().ToString();
                }
                if (c.Name == lb2)
                {
                    //asigno el contenido de informacion que necesito al "label" encontrado
                    c.Text = _generalaBLL.LiPlayers[jugador].usuarioBE.usuario;
                }
            }
        }

        //Actualiza los labels correspondientes al puntaje temporario
        private void actualizarTempPuntaje(bool boo)
        {
            string lb;
            for (int i = 0; i < 11; i++)
            {
                lb = string.Format("LST {0}", i);
                foreach (Control c in this.Controls)
                {
                    if (c.Name == lb)
                    {
                        if (boo)
                        {
                            c.Text = _tempPuntaje[i].ToString();
                        }
                        else
                        {
                            c.Text = "";
                        }
                    }
                }
            }
        }

        #endregion Actualizar Labels

        #region Checkbox Dados

        //Cambia el "enabled" de los checkers
        private void EstadoCheckers(bool boo)
        {
            CBD1.Enabled = boo;
            CBD2.Enabled = boo;
            CBD3.Enabled = boo;
            CBD4.Enabled = boo;
            CBD5.Enabled = boo;
        }

        //Se utiliza para deschequear los dados, asi como tambien para limpiarlos
        private void limpiaDados()
        {
            CBD1.Checked = false;
            CBD2.Checked = false;
            CBD3.Checked = false;
            CBD4.Checked = false;
            CBD5.Checked = false;

            EstadoCheckers(false);

            CBD1.Text = "";
            CBD2.Text = "";
            CBD3.Text = "";
            CBD4.Text = "";
            CBD5.Text = "";
        }

        //actualiza los dados de un lanzamiento de un jugador
        private void mostrarDados(int j)
        {
            CBD1.Text = _generalaBLL.LiPlayers[j].liDados[0].cara.ToString();
            CBD2.Text = _generalaBLL.LiPlayers[j].liDados[1].cara.ToString();
            CBD3.Text = _generalaBLL.LiPlayers[j].liDados[2].cara.ToString();
            CBD4.Text = _generalaBLL.LiPlayers[j].liDados[3].cara.ToString();
            CBD5.Text = _generalaBLL.LiPlayers[j].liDados[4].cara.ToString();
        }

        #endregion Checkbox Dados

        #region Botones de asignacion de resultados

        //Se usa para habilitar o deshabilitar los botones que ingresan los puntos
        private void cambiarEstadoBA(bool boo)
        {
            BAD1.Enabled = boo;
            BAD2.Enabled = boo;
            BAD3.Enabled = boo;
            BAD4.Enabled = boo;
            BAD5.Enabled = boo;
            BAD6.Enabled = boo;
            BAEscalera.Enabled = boo;
            BAFull.Enabled = boo;
            BAPoker.Enabled = boo;
            BAGenerala.Enabled = boo;
            BAGeneralaD.Enabled = boo;
        }

        //activa los botones segun el jugador indicado
        private void activarEstadoBA(int jugador)
        {
            BAD1.Enabled = _generalaBLL.LiPlayers[jugador].planillaBLL.planillaBE.AnotadorEstado[1];
            BAD2.Enabled = _generalaBLL.LiPlayers[jugador].planillaBLL.planillaBE.AnotadorEstado[2];
            BAD3.Enabled = _generalaBLL.LiPlayers[jugador].planillaBLL.planillaBE.AnotadorEstado[3];
            BAD4.Enabled = _generalaBLL.LiPlayers[jugador].planillaBLL.planillaBE.AnotadorEstado[4];
            BAD5.Enabled = _generalaBLL.LiPlayers[jugador].planillaBLL.planillaBE.AnotadorEstado[5];
            BAD6.Enabled = _generalaBLL.LiPlayers[jugador].planillaBLL.planillaBE.AnotadorEstado[6];
            BAEscalera.Enabled = _generalaBLL.LiPlayers[jugador].planillaBLL.planillaBE.AnotadorEstado[7];
            BAFull.Enabled = _generalaBLL.LiPlayers[jugador].planillaBLL.planillaBE.AnotadorEstado[8];
            BAPoker.Enabled = _generalaBLL.LiPlayers[jugador].planillaBLL.planillaBE.AnotadorEstado[9];
            BAGenerala.Enabled = _generalaBLL.LiPlayers[jugador].planillaBLL.planillaBE.AnotadorEstado[10];
            BAGeneralaD.Enabled = _generalaBLL.LiPlayers[jugador].planillaBLL.planillaBE.AnotadorEstado[0];
        }

        //carga los valores conseguido en el juego a un jugador
        private void cargarPuntaje(int jugador, int pos)
        {
            _generalaBLL.LiPlayers[jugador].planillaBLL.planillaBE.AnotadorValores[pos] = _tempPuntaje[pos];
            _generalaBLL.LiPlayers[jugador].planillaBLL.planillaBE.AnotadorEstado[pos] = false;
        }

        //Simplemente agrupo acciones en un solo metodo comunes a todos los botones
        private void agrupadorMetodosBA()
        {
            //#######################
            //### Pre-Condiciones ###
            //#######################
            
            //###########################
            //### Ejecucion del juego ###
            //###########################
            
            //########################
            //### Post-Condiciones ###
            //########################

            //Se utiliza para deschequear los dados, asi como tambien para limpiarlos
            limpiaDados();
            //Se usa para habilitar o deshabilitar los botones que ingresan los puntos
            cambiarEstadoBA(false);
            //Habilito el boton de lanzamiento de dados
            BLanzaDado.Enabled = true;
            //Reinicio el numero de jugadas para el Jugador
            _generalaBLL.GeneralaBE.numeroJugada = 0;
            //contiene todo lo que hay que refrescar por cada jugada
            actualizarEstadoJuego();
            //limpio los resultados temporales una ves asignados
            _tempPuntaje = null;
            actualizarTempPuntaje(false);
        }

        #region Botones

        private void BAD1_Click(object sender, EventArgs e)
        {
            cargarPuntaje(_generalaBLL.GeneralaBE.turno, 1);
            agrupadorMetodosBA();
        }

        private void BAD2_Click(object sender, EventArgs e)
        {
            cargarPuntaje(_generalaBLL.GeneralaBE.turno, 2);
            agrupadorMetodosBA();
        }

        private void BAD3_Click(object sender, EventArgs e)
        {
            cargarPuntaje(_generalaBLL.GeneralaBE.turno, 3);
            agrupadorMetodosBA();
        }

        private void BAD4_Click(object sender, EventArgs e)
        {
            cargarPuntaje(_generalaBLL.GeneralaBE.turno, 4);
            agrupadorMetodosBA();
        }

        private void BAD5_Click(object sender, EventArgs e)
        {
            cargarPuntaje(_generalaBLL.GeneralaBE.turno, 5);
            agrupadorMetodosBA();
        }

        private void BAD6_Click(object sender, EventArgs e)
        {
            cargarPuntaje(_generalaBLL.GeneralaBE.turno, 6);
            agrupadorMetodosBA();
        }

        private void BAEscalera_Click(object sender, EventArgs e)
        {
            cargarPuntaje(_generalaBLL.GeneralaBE.turno, 7);
            agrupadorMetodosBA();
        }

        private void BAFull_Click(object sender, EventArgs e)
        {
            cargarPuntaje(_generalaBLL.GeneralaBE.turno, 8);
            agrupadorMetodosBA();
        }

        private void BAPoker_Click(object sender, EventArgs e)
        {
            cargarPuntaje(_generalaBLL.GeneralaBE.turno, 9);
            agrupadorMetodosBA();
        }

        private void BAGenerala_Click(object sender, EventArgs e)
        {
            cargarPuntaje(_generalaBLL.GeneralaBE.turno, 10);
            agrupadorMetodosBA();
        }

        private void BAGeneralaD_Click(object sender, EventArgs e)
        {
            cargarPuntaje(_generalaBLL.GeneralaBE.turno, 0);
            agrupadorMetodosBA();
        }

        #endregion Botones

        #endregion Botones de asignacion de resultados

        #region Boton lanzar dados

        //lanza dados sobre los elementos no chequeados
        private void ejecutarDados(int j)
        {
            if (!CBD1.Checked)
            {
                _generalaBLL.LiPlayers[j].liDados[0] = _generalaBLL.DadoBLL.lanzarDado();
            }
            if (!CBD2.Checked)
            {
                _generalaBLL.LiPlayers[j].liDados[1] = _generalaBLL.DadoBLL.lanzarDado();
            }
            if (!CBD3.Checked)
            {
                _generalaBLL.LiPlayers[j].liDados[2] = _generalaBLL.DadoBLL.lanzarDado();
            }
            if (!CBD4.Checked)
            {
                _generalaBLL.LiPlayers[j].liDados[3] = _generalaBLL.DadoBLL.lanzarDado();
            }
            if (!CBD5.Checked)
            {
                _generalaBLL.LiPlayers[j].liDados[4] = _generalaBLL.DadoBLL.lanzarDado();
            }
        }

        ////Boton que se encarga de lanzar los dados y actualizar algunos estados.
        private void BLanzaDado_Click(object sender, EventArgs e)
        {
            //guardo temporalmente turno (jugador correspondiente) para una escritura mas legible
            int jugador = _generalaBLL.GeneralaBE.turno;

            //#######################
            //### Pre-Condiciones ###
            //#######################

            //limpio el puntaje para iniciar una nueva carga
            _tempPuntaje = null;
            //activa los botones segun el jugador indicado
            activarEstadoBA(jugador);
            //Cambia el "enabled" de los checkers
            EstadoCheckers(true);

            //###########################
            //### Ejecucion del juego ###
            //###########################

            //lanza dados sobre los elementos no chequeados
            ejecutarDados(jugador);
            //actualiza los dados de un lanzamiento de un jugador
            mostrarDados(jugador);

            //guardo el puntaje temporal segun cada tirada de dados.
            _tempPuntaje = _generalaBLL.chequear(jugador, _generalaBLL.GeneralaBE.numeroJugada);
            //Actualiza los labels correspondientes al puntaje temporario
            actualizarTempPuntaje(true);

            //########################
            //### Post-Condiciones ###
            //########################

            //cuenta la cantidad de tiradas de un jugador
            _generalaBLL.tiradaNext();
            //Muestra la jugada en curso
            LNumeroTirada.Text = _generalaBLL.GeneralaBE.numeroJugada.ToString();

            //deshabilita el boton de lanzar dados una vez superado los 3 lanzamientos.
            if (_generalaBLL.GeneralaBE.numeroJugada >= 3)
            {
                //Cambia el "enabled" de los checkers
                BLanzaDado.Enabled = false;
            }
            
        }

        #endregion Boton lanzar dados

        #region Eventos

        public class MEH
        {
            private BLL.GENERALA _g;
            private FMTABLERO _me;

            public MEH(BLL.GENERALA generalaBLL, FMTABLERO me)
            {
                _g = generalaBLL;
                _me = me;
            }

            //capta el evento cuando se produce una generala servida y registra al jugador
            public void vicGS(BE.USUARIO jugador)
            {
                ganador(jugador);
            }

            //cuando se termina un juego, capta el evento, busca a quien tiene mayor puntaje y lo registra.
            public void vicPuntos()
            {
                //hago una busqueda del jugador que mas puntos sumo
                int puntos = -1;
                BE.USUARIO jugador = null;
                foreach (BLL.PLAYER i in _g.LiPlayers)
                {
                    if (i.planillaBLL.resultado() > puntos)
                    {
                        puntos = i.planillaBLL.resultado();
                        jugador = i.usuarioBE;
                    }
                }
                ganador(jugador);
            }

            //contiene todas la rutina en comun para los eventos de victoria
            public void ganador(BE.USUARIO usr)
            {
                //deshabilito el tablero para obligarlo a generar una nueva partida si quiere seguir jugando.
                _me.Enabled = false;

                //muestra un cartel de quien fue el ganador
                MessageBox.Show("El jugador {0} ha ganado el juego!", usr.usuario);
                //actualizo las victolias en la lista de jugadores logueados
                //(para no tener que volver a buscar en la DB
                foreach (BE.USUARIO jug in FMCONTENEDOR.liUSRLogin)
                {
                    if (jug.usuario == usr.usuario)
                    {
                        jug.victorias += 1;
                        //guarda en la DB la victoria del jugador
                        _g.guardarVictoria(usr);
                    }
                }
                //busco a los jugadores de la partida entre los logueados y registro el partido jugado
                foreach (BE.USUARIO jug in FMCONTENEDOR.liUSRPartida)
                {
                    foreach (BE.USUARIO jl in FMCONTENEDOR.liUSRLogin)
                    {
                        if (jug.usuario == jl.usuario)
                        {
                            jl.partidos += 1;
                            _g.guardarPartidos(jl);
                        }
                    }
                }

            }
        }

        #endregion Eventos

    }


    

}
