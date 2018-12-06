using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio52
{
    public class Cartuchera2
    {
        public List<Lapiz> lapices;
        public List<Boligrafo> lapiceras;

        public Cartuchera2()
        {
            lapiceras = new List<Boligrafo>();
            lapices = new List<Lapiz>();
        }

        public bool ProbarElemento()
        {
            foreach(Lapiz a in lapices)
            {
                if(((IAcciones)a).UnidadesDeEscritura < 0.1)
                {
                    ((IAcciones)a).Recargar(10);
                    return false;
                }
                ((IAcciones)a).Escribir("1");
            }

            foreach(Boligrafo b in lapiceras)
            {
                if(((IAcciones)b).UnidadesDeEscritura < 0.3)
                {
                    ((IAcciones)b).Recargar(20);
                    return false;
                }
                ((IAcciones)b).Escribir("1");
            }

            return true;
        }
    }
}
