using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class PLANILLA
    {

        public PLANILLA() 
        {
            for (int i = 0; i < 11; i++)
            {
                _anotadorValores.Add(0);
                _anotadorEstado.Add(true);
            }
        }

        private List<int> _anotadorValores;
        //0 --> Generala Doble
        //1 ---> 1
        //2 ---> 2
        //3 ---> 3
        //4 ---> 4
        //5 ---> 5
        //6 ---> 6
        //7 ---> Escalera
        //8 ---> Full
        //9 ---> Poker
        //10 --> Generala
        public List<int> AnotadorValores
        {
            get { return _anotadorValores; }
            set { _anotadorValores = value; }
        }

        private List<bool> _anotadorEstado;
        public List<bool> AnotadorEstado
        {
            get { return _anotadorEstado; }
            set { _anotadorEstado = value; }
        }

    }
}
