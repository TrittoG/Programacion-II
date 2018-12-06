using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio64
{
    public class Negocio
    {
        private Caja caja1;
        private Caja caja2;
        private List<string> clientes;

        public Negocio(Caja c1, Caja c2)
        {
            clientes = new List<string>();
            caja1 = c1;
            caja2 = c2;
        }

        public Caja Caja1
        {
            get
            {
                return caja1;
            }
        }

        public Caja Caja2
        {
            get
            {
                return caja2;
            }
        }

        public List<string> Clientes
        {
            get
            {
                return clientes;
            }
        }

        public void AsignarCaja()
        {
            Console.WriteLine("Asignando cajas..");
            foreach(string s in clientes)
            {
                System.Threading.Thread.Sleep(1000);
                if (caja1.FilaClientes.Count <= caja2.FilaClientes.Count)
                {
                    caja1.FilaClientes.Add(s);
                }
                else
                    caja2.FilaClientes.Add(s);
            }
        }
    }
}
