using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace BLL
{
    public class DADO
    {
        public DADO() { }

        //funcion random
        private Random r = new Random();

        //devuelve un nuevo dado lanzado (con una cara que vario)
        public BE.DADO lanzarDado()
        {
            BE.DADO unDado = new BE.DADO();
            unDado.cara = r.Next(1, 7);
            return unDado;
        }

    }
}
