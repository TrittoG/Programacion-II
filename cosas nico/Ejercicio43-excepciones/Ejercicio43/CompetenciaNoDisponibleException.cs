using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio43
{
    public class CompetenciaNoDisponibleException :Exception
    {
        private string nombreClase;
        private string nombreMetodo;

        public CompetenciaNoDisponibleException(string mensaje, string nombre, string metodo)   :this(mensaje, nombre, metodo, null)
        {
           
        }

        public CompetenciaNoDisponibleException(string mensaje, string nombre, string metodo, Exception inner)  :base(mensaje, inner)
        {
            nombreClase = nombre;
            nombreMetodo = metodo;
        }

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

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Excepción en el método {0} de la clase {1}: {2}", NombreMetodo, NombreClase, this.Message);
            Exception inner = this.InnerException;
            while(inner != null)
            {
                sb.AppendFormat("\t{0}", inner.Message);
                inner = inner.InnerException;
            }
            return sb.ToString();
        }
    }
}
