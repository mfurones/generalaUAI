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
    public partial class FMESTADISTICA : Form
    {
        public FMESTADISTICA()
        {
            InitializeComponent();
        }

        //cargo la dll de la generala
        BLL.GENERALA _generalaBLL = new BLL.GENERALA();

        private void FMESTADISTICA_Load(object sender, EventArgs e)
        {
            DGVE.DataSource = null;
            DGVE.DataSource = _generalaBLL.listarUSRestadistica();
            //elimino las columnas que no quiero visualizar
            DGVE.Columns["IDusuario"].Visible = false;
            DGVE.Columns["passwd"].Visible = false;
            DGVE.Columns["nombre"].Visible = false;
            DGVE.Columns["apellido"].Visible = false;
            DGVE.Columns["sexo"].Visible = false;
            DGVE.Columns["email"].Visible = false;
        }

        private void Bsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
