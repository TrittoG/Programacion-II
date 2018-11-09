using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clases;
using System.Threading;

namespace ejercicio_64
{
    class Program
    {
        static void Main(string[] args)
        {
            Caja c1 = new Caja();
            Caja c2 = new Caja();

            Negocio nego = new Negocio(c1, c2);
            nego.clientes.Add("Pedro");
            nego.clientes.Add("Juan");
            nego.clientes.Add("Nico");
            nego.clientes.Add("GGT");
            nego.clientes.Add("Fabian");
            nego.clientes.Add("Pablo");
            nego.clientes.Add("Elgordo");
            nego.clientes.Add("EL LALO");
            nego.clientes.Add("Pedro");
            nego.clientes.Add("Juan");
            nego.clientes.Add("Nico");
            nego.clientes.Add("GGT");

            Thread t = new Thread(nego.AsignarCaja);
            Thread u = new Thread(c1.AtenderClientes);
            Thread v = new Thread(c2.AtenderClientes);

            t.Name = "Negocio";
            u.Name = "C1";
            v.Name = "C2";

            t.Start();
            t.Join();
            u.Start();
            v.Start();

           

            Console.ReadKey();
        }
    }
}
