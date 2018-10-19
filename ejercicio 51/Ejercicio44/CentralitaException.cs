using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio44
{
    public class CentralitaException   :Exception
    {
        #region Variables
        private string nombreClase;
        private string nombreMetodo;
        #endregion

        #region Constructores
        public CentralitaException(string mensaje, string clase, string metodo) :this(mensaje, clase, metodo, null)
        {
        }

        public CentralitaException(string mensaje, string clase, string metodo, Exception innerException)   :base(mensaje, innerException)
        {
            nombreClase = clase;
            nombreMetodo = metodo;
        }
        #endregion

        #region Propiedades
        public string NombreClase
        {
            get
            {
                return nombreClase;
            }
        }

        public string NombreMetodo
        {
            get
            {
                return nombreMetodo;
            }
        }
        #endregion
    }
}
