using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class GENERALA
    {
        public GENERALA() {
        _rondas = -1;
        _turno = 0;
        _numeroJugada = 0;
        }


        private int _rondas;
        public int rondas
        {
            get { return _rondas; }
            set { _rondas = value; }
        }

        private int _rondasTotales;
        public int rondasTotales
        {
            get { return _rondasTotales; }
            set { _rondasTotales = value; }
        }

        private int _turno;
        public int turno
        {
            get { return _turno; }
            set { _turno = value; }
        }

        private int _numeroJugada;
        public int numeroJugada
        {
            get { return _numeroJugada; }
            set { _numeroJugada = value; }
        }





    }
}
