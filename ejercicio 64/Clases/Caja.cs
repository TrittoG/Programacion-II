using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
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
                return this.filaClientes;
            }
        }

        public void AtenderClientes()
        {
            foreach(string st in this.FilaClientes)
            {
                System.Threading.Thread.Sleep(2000);
                Console.WriteLine("Nombre: " + st + "  "+ System.Threading.Thread.CurrentThread.Name);
            }
        }
    }
}
