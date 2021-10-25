using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class USUARIO
    {
        public USUARIO() { }

        private int _IDusuario;
        public int IDusuario
        {
            get { return _IDusuario; }
            set { _IDusuario = value; }
        }
        private string _usuario;
        public string usuario
        {
            get { return _usuario; }
            set { _usuario = value; }
        }
        private string _passwd;
        public string passwd
        {
            get { return _passwd; }
            set { _passwd = value; }
        }
        private string _nombre;
        public string nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
        private string _apellido;
        public string apellido
        {
            get { return _apellido; }
            set { _apellido = value; }
        }
        private string _email;
        public string email
        {
            get { return _email; }
            set { _email = value; }
        }
        private string _sexo;
        public string sexo
        {
            get { return _sexo; }
            set { _sexo = value; }
        }
        private int _victorias;
        public int victorias
        {
            get { return _victorias; }
            set { _victorias = value; }
        }
        private int _partidos;
        public int partidos
        {
            get { return _partidos; }
            set { _partidos = value; }
        }

    }
}
