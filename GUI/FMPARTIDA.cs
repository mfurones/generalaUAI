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
    public partial class FMPARTIDA : Form
    {
        public FMPARTIDA()
        {
            InitializeComponent();
        }

        //variables para asignar usuarios al juego
        BE.USUARIO _usr1 = null;
        BE.USUARIO _usr2 = null;
        BE.USUARIO _usr3 = null;
        BE.USUARIO _usr4 = null;

        private void FMPARTIDA_Load(object sender, EventArgs e)
        {
            //cargo los usuarios ya logueados
            LBlogin.DataSource = null;
            LBlogin.DataSource = FMCONTENEDOR.liUSRLogin;
            LBlogin.DisplayMember = "usuario";

            //arranca con el resto de los usuarios desactivados
            CB2.Checked = true;
            CB3.Checked = true;
            CB4.Checked = true;

            if (FMCONTENEDOR.liUSRLogin.Count > 0)
            {
                BAsignar1.Enabled = true;
            }
            else
            {
                BAsignar1.Enabled = false;
            }

            //desactivo los botones para obligar la asignacion en el campo 1
            BAsignar2.Enabled = false;
            BAsignar3.Enabled = false;
            BAsignar4.Enabled = false;

            //desactivo el boton crear partida hasta que ingrese un usuario
            Bpartida.Enabled = false;

        }

        #region Botones de asignacion de usuario"

        private void BAsignar1_Click(object sender, EventArgs e)
        {
            BE.USUARIO usrTemp;
            //asigna el usuario seleccionado a una variable temporal
            if (LBlogin.SelectedIndex > -1)
            {
                usrTemp = (BE.USUARIO)LBlogin.SelectedItem;
                //chequeo de no duplicarlo
                if (usrTemp != _usr2 && usrTemp != _usr3 && usrTemp != _usr4)
                {
                    _usr1 = usrTemp;
                    //actualiza el nombre en el textbox
                    TB1.Text = _usr1.usuario;
                    //habilito los botones de usuario
                    BAsignar2.Enabled = true;
                    BAsignar3.Enabled = true;
                    BAsignar4.Enabled = true;
                    //habilito el boton de crear partida
                    Bpartida.Enabled = true;
                }
            }
        }

        private void BAsignar2_Click(object sender, EventArgs e)
        {
            //deschequeo el checkbox
            CB2.Checked = false;
            BE.USUARIO usrTemp;
            //asigna el usuario seleccionado a una variable temporal
            if (LBlogin.SelectedIndex > -1)
            {
                usrTemp = (BE.USUARIO)LBlogin.SelectedItem;
                //chequeo de no duplicarlo
                if (usrTemp != _usr1 && usrTemp != _usr3 && usrTemp != _usr4)
                {
                    _usr2 = usrTemp;
                    //actualiza el nombre en el textbox
                    TB2.Text = _usr2.usuario;
                }
                else
                {
                    CB2.Checked = true;
                }
            }
        }

        private void BAsignar3_Click(object sender, EventArgs e)
        {
            //deschequeo el checkbox
            CB3.Checked = false;
            BE.USUARIO usrTemp;
            //asigna el usuario seleccionado a una variable temporal
            if (LBlogin.SelectedIndex > -1)
            {
                usrTemp = (BE.USUARIO)LBlogin.SelectedItem;
                //chequeo de no duplicarlo
                if (usrTemp != _usr1 && usrTemp != _usr2 && usrTemp != _usr4)
                {
                    _usr3 = usrTemp;
                    //actualiza el nombre en el textbox
                    TB3.Text = _usr3.usuario;
                }
                else
                {
                    CB3.Checked = true;
                }
            }
        }

        private void BAsignar4_Click(object sender, EventArgs e)
        {
            //deschequeo el checkbox
            CB4.Checked = false;
            BE.USUARIO usrTemp;
            //asigna el usuario seleccionado a una variable temporal
            if (LBlogin.SelectedIndex > -1)
            {
                usrTemp = (BE.USUARIO)LBlogin.SelectedItem;
                //chequeo de no duplicarlo
                if (usrTemp != _usr1 && usrTemp != _usr2 && usrTemp != _usr3)
                {
                    _usr4 = usrTemp;
                    //actualiza el nombre en el textbox
                    TB4.Text = _usr4.usuario;
                }
                else
                {
                    CB4.Checked = true;
                }
            }
        }

        #endregion
        
        #region Checkbox

        private void CB2_CheckedChanged(object sender, EventArgs e)
        {
            //limpio la variable y el texto del objeto que puede contener
            if (CB2.Enabled)
            {
                TB2.Text = "";
                _usr2 = null;
            }
        }

        private void CB3_CheckedChanged(object sender, EventArgs e)
        {
            //limpio la variable y el texto del objeto que puede contener
            if (CB3.Enabled)
            {
                TB3.Text = "";
                _usr3 = null;
            }
        }

        private void CB4_CheckedChanged(object sender, EventArgs e)
        {
            //limpio la variable y el texto del objeto que puede contener
            if (CB4.Enabled)
            {
                TB4.Text = "";
                _usr4 = null;
            }
        }

        #endregion

        //Boton "Crear"
        private void Bpartida_Click(object sender, EventArgs e)
        {
            //genero una lista de usuarios que van a ser parte de la partida
            List<BE.USUARIO> usuarios = new List<BE.USUARIO>();
            //chequeo de que la variable no este vacia antes de generar la lista
            if (_usr1 != null)
            {
                usuarios.Add(_usr1);
            }
            if (_usr2 != null)
            {
                usuarios.Add(_usr2);
            }
            if (_usr3 != null)
            {
                usuarios.Add(_usr3);
            }
            if (_usr4 != null)
            {
                usuarios.Add(_usr4);
            }

            FMCONTENEDOR.liUSRPartida = usuarios;
            
            //controlar la concepcion de static
            FMCONTENEDOR.nuevoJuego();


            this.Close();
        }

        //boton "Cancelar"
        private void Bcancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
