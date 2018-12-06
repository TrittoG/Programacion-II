using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio64
{
    public class Caja
    {
        private List<string> filaClientes;

        public Caja()
        {
            filaClientes = new List<string>();
        }

        public List<string> FilaClientes
        {
            get
            {
                return filaClientes;
            }
        }

        public void AtenderCliente()
        {
            foreach(string a in filaClientes)
            {
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine(a + " " + System.Threading.Thread.CurrentThread.Name);
            }
        }
    }
}
