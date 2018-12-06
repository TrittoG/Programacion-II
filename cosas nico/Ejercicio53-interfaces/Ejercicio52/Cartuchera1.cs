using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio52
{
    public class Cartuchera1
    {
        public List<IAcciones> utiles;

        public Cartuchera1()
        {
            utiles = new List<IAcciones>();
        }

        public bool ProbarElementos()
        {
            foreach(IAcciones a in utiles)
            {
                if (a is Lapiz && a.UnidadesDeEscritura < 0.1)
                {
                    a.Recargar(10);
                    return false;
                }

                if (a is Boligrafo && a.UnidadesDeEscritura < 0.3)
                {
                    a.Recargar(20);
                    return false;
                }

                a.Escribir("1");
            }
            return true;
        }
    }
}
