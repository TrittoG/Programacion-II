using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Ejercicio31
{
    enum Puesto
    {
        Caja1,
        Caja2
    }

    class PuestoAtencion
    {
<<<<<<< HEAD
		private static int numeroActual;
		private Puesto puesto;

=======
        private Puesto puesto;
        private static int numeroActual;

        static PuestoAtencion()
        {
            numeroActual = 0;
        }
        
        public PuestoAtencion(Puesto puesto)
        {
            this.puesto = puesto;
        }

        public bool Atender(Cliente cli)
        {
            Thread.Sleep(500);
            return true;
        }

        static int NumeroActual
        {
            get
            {
                numeroActual++;
                return numeroActual;
            }
        }
>>>>>>> eace9f5a7e901b80cfa6cc173568dd124dc52ded
    }

	public enum Puesto
	{
		Caja1,
		Caja2
	}

	private static int NumeroActual
	{
		get
		{
			
			return numeroActual;
		}
	}
}
