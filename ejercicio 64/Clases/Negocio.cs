using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Negocio
    {
        public List<string> clientes;
        private Caja caja1;
        private Caja caja2;

        public List<string> Clientes
        {
            get
            {
                return this.clientes;
            }
        }

        public Caja Caja1
        {
            get
            {
                return this.caja1;
            }
        }

        public Caja Caja2
        {
            get
            {
                return this.caja2;
            }
        }

        public Negocio(Caja c1, Caja c2)
        {
            this.caja1 = c1;
            this.caja2 = c2;

            clientes = new List<string>();
        }

        public void AsignarCaja()
        {
            Console.WriteLine("Asignando Cajas...");

            foreach(string st in this.Clientes)
            {
                System.Threading.Thread.Sleep(500);

                if (Caja1.FilaClientes.Count < Caja2.FilaClientes.Count)
                {
                    
                    Caja1.FilaClientes.Add(st);
                }
                else
                {
                    Caja2.FilaClientes.Add(st);
                }
            }


        }
    }
}
