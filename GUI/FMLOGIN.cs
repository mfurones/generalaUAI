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
    public partial class FMLOGIN : Form
    {
        public FMLOGIN()
        {
            InitializeComponent();
        }

        //Libreria del juego
        BLL.GENERALA _generalaBLL = new BLL.GENERALA();

        private void BCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FMLOGIN_Load(object sender, EventArgs e)
        {
            //cargo una lista de usuarios registrados.
            CBUsr.DataSource = null;
            CBUsr.DataSource = _generalaBLL.ListarUSRregistrados();
            CBUsr.DisplayMember = "usuario";
        }

        private void BAceptar_Click(object sender, EventArgs e)
        {
            BE.USUARIO unUsuario = null;
            //chequeo de que tengo una seleccion
            if (CBUsr.SelectedIndex > -1)
            {
                //guardo el usuario seleccionado
                unUsuario = (BE.USUARIO)CBUsr.SelectedItem;
            }
            //verifico que el usuario esta seleccionado y la passwd esta escrita
            if (unUsuario != null && !string.IsNullOrWhiteSpace(TBPasswd.Text))
            {
                TBPasswd.BackColor = Color.White;
                //le agreo la passwd
                unUsuario.passwd = TBPasswd.Text;
                //compruebo el usuario y passwd en la DB
                unUsuario = _generalaBLL.logInUsuario(unUsuario);
                //si me devuelve al usuario procedo
                if (unUsuario != null)
                {
                    //agrego al usuario logueado al formulario base
                    FMCONTENEDOR.liUSRLogin.Add(unUsuario);
                    MessageBox.Show("Bienvenido {0}", unUsuario.usuario);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Usuario y contraseña incorrecta, por favor intentelo de nuevo");
                    TBPasswd.BackColor = Color.Beige;
                }
            }
            else
            {
                TBPasswd.BackColor = Color.Beige;
            }

        }

    }
}
