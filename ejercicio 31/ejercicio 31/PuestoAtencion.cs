using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_31
{
    enum Puesto
    {
        caja1,
        caja2
    }


    class PuestoAtencion
    {
        private static int numeroActual;
        private Puesto puesto;

        static PuestoAtencion()
        {
            numeroActual = 0;
        }

        public PuestoAtencion(Puesto puesto)
        {
            this.puesto = puesto;
        }


        public static int NumeroActual
        {          
            get
            {
                numeroActual = numeroActual + 1;
                return numeroActual;
            }
        }

        public bool Atender(Cliente cli)
        {
            System.Threading.Thread.Sleep(500);
            return true;
        }
    }
}
