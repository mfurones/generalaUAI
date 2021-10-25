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
    public partial class FMCONTENEDOR : Form
    {
        public FMCONTENEDOR()
        {
            InitializeComponent();
        }

        #region Contenedores de Formularios

        // verificar el tema de static
        static FMTABLERO unFMTablero = null;
        FMPARTIDA unFMPartida = null;
        FMLOGIN unFMLogin = null;
        FMREGISTRAR unFMRegistrar = null;
        FMESTADISTICA unFMEstadistica = null;
        FMACERCAGENERALA unFMAcercaGenerala = null;
        FMREGLAMENTO unFMReglamento = null;
        FMCONCEPCION unFMConcepcion = null;

        #endregion

        //aca se cargan todos los usuarios que se hayan logueado en el juego
        private static List<BE.USUARIO> _liUSRLogin = new List<BE.USUARIO>();
        public static List<BE.USUARIO> liUSRLogin
        {
            get { return _liUSRLogin; }
            set { _liUSRLogin = value; }
        }

        //aca se guardan los jugadores
        private static List<BE.USUARIO> _liUSRPartida = new List<BE.USUARIO>();
        public static List<BE.USUARIO> liUSRPartida
        {
            get { return _liUSRPartida; }
            set { _liUSRPartida = value; }
        }

        //Carga el formulario
        private void FMCONTENEDOR_Load(object sender, EventArgs e)
        {
            //este es el formulario contenedor
            this.IsMdiContainer = true;

            //cargo un tablero inicial
            unFMTablero = new FMTABLERO();
            unFMTablero.MdiParent = this;
            unFMTablero.TopMost = false;
            unFMTablero.Enabled = false;
            unFMTablero.Show();

        }

        #region MenuStrip

        //partida nueva
        private void partidaNuevaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            limpiarFM();
            unFMPartida = new FMPARTIDA();
            unFMPartida.MdiParent = this;
            unFMPartida.TopMost = true;
            unFMPartida.Show();
        }

        //Login
        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            limpiarFM();
            unFMLogin = new FMLOGIN();
            unFMLogin.MdiParent = this;
            unFMLogin.TopMost = true;
            unFMLogin.Show();
        }

        //Registrarse
        private void registrarseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            limpiarFM();
            unFMRegistrar = new FMREGISTRAR();
            unFMRegistrar.MdiParent = this;
            unFMRegistrar.TopMost = true;
            unFMRegistrar.Show();
        }

        //Estadistica
        private void estadisticasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            limpiarFM();
            unFMEstadistica = new FMESTADISTICA();
            unFMEstadistica.MdiParent = this;
            unFMEstadistica.TopMost = true;
            unFMEstadistica.Show();
        }

        //Acerca de Generala
        private void acercaDeLaGeneralaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            limpiarFM();
            unFMAcercaGenerala = new FMACERCAGENERALA();
            unFMAcercaGenerala.MdiParent = this;
            unFMAcercaGenerala.TopMost = true;
            unFMAcercaGenerala.Show();
        }

        //Reglamento
        private void reglamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            limpiarFM();
            unFMReglamento = new FMREGLAMENTO();
            unFMReglamento.MdiParent = this;
            unFMReglamento.TopMost = true;
            unFMReglamento.Show();
        }

        //Concepccion
        private void concepciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            limpiarFM();
            unFMConcepcion = new FMCONCEPCION();
            unFMConcepcion.MdiParent = this;
            unFMConcepcion.TopMost = true;
            unFMConcepcion.Show();
        }

        //Salir
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

#endregion

        //se utiliza para cerrar todos los formularios abiertos y limpiarlos
        private void limpiarFM()
        {
            checkFM(unFMPartida);
            checkFM(unFMLogin);
            checkFM(unFMRegistrar);
            checkFM(unFMEstadistica);
            checkFM(unFMAcercaGenerala);
            checkFM(unFMReglamento);
            checkFM(unFMConcepcion);
        }
        //funcion generica para cerrar formularios
        // verificar el tema de static
        private static void checkFM(Form fm)
        {
            if (fm != null)
            {
                fm.Close();
                fm = null;
            }
        }

        //Lanzo un nuevo tablero listo para jugar
        
        // verificar el tema de static
        public static void nuevoJuego()
        {
            checkFM(unFMTablero);
            unFMTablero = new FMTABLERO();
            unFMTablero.MdiParent = new FMCONTENEDOR(); //debe ir un this
            unFMTablero.TopMost = false;
            unFMTablero.Enabled = true;
            unFMTablero.Show();
        }
    }
}
