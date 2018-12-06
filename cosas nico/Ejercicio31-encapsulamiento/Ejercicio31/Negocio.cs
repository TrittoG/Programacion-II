using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio31
{
    class Negocio
    {
<<<<<<< HEAD
		private PuestoAtencion caja;
		private string nombre;
		private Queue<Cliente> clientes;

		public Cliente Clientes
		{
			get
			{
				return this.clientes.First();
			}
		}
	}
=======
        private PuestoAtencion caja;
        private Queue<Cliente> clientes;
        private string nombre;

        private Negocio()
        {
            this.caja = new PuestoAtencion(Puesto.Caja1);
        }

        public Negocio(string nombre) : this()
        {
            this.nombre = nombre;
        }

        public Cliente Cliente
        {
            get
            {
                return clientes.Dequeue();
            }

            set
            {
                bool agregar = this + value;
            }
        }
        public static bool operator ==(Negocio n, Cliente c)
        {
            foreach(Cliente s in n.clientes)
            {
                if (s == c)
                    return true;
            }
            return false;
        }

        public static bool operator !=(Negocio n, Cliente c)
        {
            return !(n == c);
        }

        public static bool operator +(Negocio n, Cliente c)
        {
            if(n != c)
            {
                n.clientes.Enqueue(c);
                return true;
            }
            return false;
        }

        public static bool operator ~(Negocio n)
        {
            if (n.caja.Atender(n.Cliente))
            {
                return true;
            }
            return false;
        }
    }

>>>>>>> eace9f5a7e901b80cfa6cc173568dd124dc52ded
}
