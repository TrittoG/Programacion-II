using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio64;
using System.Threading;

namespace TestConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            Caja c1 = new Caja();
            Caja c2 = new Caja();
            Negocio negocio = new Negocio(c1, c2);
            for (int i = 0; i < 10; i++)
                negocio.Clientes.Add("Cliente" + i);

            Thread nego = new Thread(negocio.AsignarCaja);
            Thread Caja1 = new Thread(c1.AtenderCliente);
            Thread Caja2 = new Thread(c2.AtenderCliente);
            nego.Name = "Negocio";
            Caja1.Name = "Caja 1";
            Caja2.Name = "Caja 2";
            nego.Start();
            nego.Join();
            Caja1.Start();
            Caja2.Start();
            Console.ReadKey();
        }
    }
}
