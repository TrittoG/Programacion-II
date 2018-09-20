using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_31
{
    class Negocio
    {
        private PuestoAtencion caja;
        private Queue<Cliente> clientes;
        private string nombre;

        private Negocio()
        {
            this.caja = new PuestoAtencion(Puesto.caja1);
            this.clientes = new Queue<Cliente>();
        }

        public Negocio(string nombre)
        {
            this.nombre = nombre;
        }

        public static bool operator ==(Negocio n, Cliente c)
        {
            if(!(n is null || c is null))
            {
                if(n.clientes.Contains(c))
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator !=(Negocio n, Cliente c)
        {
            return !(n == c);
        }

        public static bool operator +(Negocio n, Cliente c)
        {
            if(!(n is null || c is null))
            {
                if(!(n==c))
                {
                    n.clientes.Enqueue(c);
                    return true;
                }
            }
            return false;
        }
        

        public Cliente Cliente
        {
            set
            {
                if(!(this == value))
                {
                    bool bol;
                    bol = this+value;
                }
            }
            get
            {
                return this.clientes.Dequeue();
            }
        }

        public static bool operator ~(Negocio n)
        {
            if(!(n is null))
            {
                n.caja.Atender(n.Cliente);
                return true;
            }
            return false;
        }


        public int ClientesPendientes
        {
            get
            {
                return this.clientes.Count();
            }
        }
    }
}
