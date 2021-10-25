using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class PLAYER
    {

        public PLAYER()
        {
            _liDados = new List<BE.DADO>();
            for (int i = 0; i < 5; i++)
			{
			 _liDados.Add(new BE.DADO());
			}

            _planillaBLL = new PLANILLA();
        }

        #region Property

        private BE.USUARIO _usuarioBE;
        public BE.USUARIO usuarioBE
        {
            get { return _usuarioBE; }
            set { _usuarioBE = value; }
        }

        private BLL.PLANILLA _planillaBLL;
        public BLL.PLANILLA planillaBLL
        {
            get { return _planillaBLL; }
            set { _planillaBLL = value; }
        }

        private List<BE.DADO> _liDados;
        public List<BE.DADO> liDados
        {
            get { return _liDados; }
            set { _liDados = value; }
        }

        #endregion

        #region metodos

        #endregion


    }
}
