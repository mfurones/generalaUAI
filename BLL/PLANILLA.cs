using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class PLANILLA
    {
        public PLANILLA()
        {
            _planillaBE = new BE.PLANILLA();
        }
        
        #region property

        private BE.PLANILLA _planillaBE;
        //guarda un objeto BE.PLANILLA
        public BE.PLANILLA planillaBE
        {
            get { return _planillaBE; }
        }

        #endregion

        #region metodos

        //agrega un puntaje en la anotador de la planilla y cambia su estado
        public void puntuar(int posicion, int valor)
        {
            _planillaBE.AnotadorValores[posicion] = valor;
            _planillaBE.AnotadorEstado[posicion] = false;
        }

        //suma los puntajes actuales y devuelve el resultado
        public int resultado()
        {
            int total = 0;
            foreach (int i in _planillaBE.AnotadorValores)
            {
                total += i; 
            }
            return total;
        }

        #endregion






    }
}
