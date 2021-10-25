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
    public partial class FMREGISTRAR : Form
    {
        public FMREGISTRAR()
        {
            InitializeComponent();
        }

        //cargo la dll del juego
        BLL.GENERALA _generalaBLL = new BLL.GENERALA();
        //es un numero que tengo que validar antes de crear al usuario
        int _validarCampo;

        //Carga de formulario
        private void FMREGISTRAR_Load(object sender, EventArgs e)
        {
            //me aseguro que los campos esten vacios
            TBid.Text = "";
            TBusuario.Text = "";
            TBpasswd1.Text = "";
            TBpasswd2.Text = "";
            TBnombre.Text = "";
            TBapellido.Text = "";
            TBmail.Text = "";
            TBvalidar.Text = "";
            CBsexo.DataSource = null;
            CBsexo.DataSource = new List<string>(new string[] {"Masculino", "Femenino", "Otro"});
            //genero un codigo validador
            _validarCampo = ValidarRandom();
            Bvalidar.Text = _validarCampo.ToString();
        }

        //devuelve un numero aleatorio de 8 cifras
        private int ValidarRandom()
        {
            //funcion random
            Random r = new Random();
            return r.Next(10000000, 99999999);
        }

        //Boton para salir del formulario
        private void Bsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //boton para crear un usuario
        private void Bcrear_Click(object sender, EventArgs e)
        {
            //valido si toda la info suministrada esta OK, entonces genero al usuario
            if (validarCampos())
            {
                BE.USUARIO unUsuario = new BE.USUARIO();
                unUsuario.usuario = TBusuario.Text;
                unUsuario.passwd = TBpasswd1.Text;
                unUsuario.nombre = TBnombre.Text;
                unUsuario.apellido = TBapellido.Text;
                unUsuario.email = TBmail.Text;
                unUsuario.sexo = CBsexo.SelectedItem.ToString();
                //guarda al usuario en la DB
                _generalaBLL.registrarUsuario(unUsuario);
                this.Close();
            }
            else
            {
                MessageBox.Show("Por favor completar correctamente los campos.");
            }
        }

        //boton para generar un nuevo captcha
        private void Bvalidar_Click(object sender, EventArgs e)
        {
            _validarCampo = ValidarRandom();
            Bvalidar.Text = _validarCampo.ToString();
        }

        //valida todos los campos
        private bool validarCampos()
        {
            bool resultado = true;

            //### usuario ###
            if (string.IsNullOrWhiteSpace(TBusuario.Text) ||
                TBusuario.Text.Length < 4 ||
                TBusuario.Text.Length > 10)
            {
                TBusuario.BackColor = Color.Beige;
                resultado = false;
            }
            else
            {
                TBusuario.BackColor = Color.White;
            }

            //### password1 ###
            if (string.IsNullOrWhiteSpace(TBpasswd1.Text) ||
                TBpasswd1.Text.Length < 4 ||
                TBpasswd1.Text.Length > 10)
            {
                TBpasswd1.BackColor = Color.Beige;
                resultado = false;
            }
            else
            {
                TBpasswd1.BackColor = Color.White;
            }

            //### password2 ###
            if (string.IsNullOrWhiteSpace(TBpasswd2.Text) ||
                TBpasswd2.Text.Length < 4 ||
                TBpasswd2.Text.Length > 10 ||
                TBpasswd1.Text != TBpasswd2.Text)
            {
                TBpasswd2.BackColor = Color.Beige;
                resultado = false;
            }
            else
            {
                TBpasswd2.BackColor = Color.White;
            }
            
            //### Nombre ###
            if (string.IsNullOrWhiteSpace(TBnombre.Text) ||
                TBnombre.Text.Length > 16)
            {
                TBnombre.BackColor = Color.Beige;
                resultado = false;
            }
            else
            {
                TBnombre.BackColor = Color.White;
            }

            //### Apellido ###
            if (string.IsNullOrWhiteSpace(TBapellido.Text) ||
                TBapellido.Text.Length > 16)
            {
                TBapellido.BackColor = Color.Beige;
                resultado = false;
            }
            else
            {
                TBapellido.BackColor = Color.White;
            }

            //### email ###
            if (string.IsNullOrWhiteSpace(TBmail.Text) ||
                TBmail.Text.Length > 60)
            {
                TBmail.BackColor = Color.Beige;
                resultado = false;
            }
            else
            {
                TBmail.BackColor = Color.White;
            }

            //### validar ###
            if (string.IsNullOrWhiteSpace(TBvalidar.Text) ||
                _validarCampo != int.Parse(TBvalidar.Text))
            {
                TBvalidar.BackColor = Color.Beige;
                resultado = false;
            }
            else
            {
                TBvalidar.BackColor = Color.White;
            }
            
            return resultado;
        }

    }
}
