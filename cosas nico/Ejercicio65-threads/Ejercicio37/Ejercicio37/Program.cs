using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio65;
using System.Threading;

namespace Ejercicio37
{
	class Program
	{
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio NRO 37";
            // Mi central 
            Centralita c = new Centralita("Fede Center");

            // Mis 4 llamadas 
            /*	Local l1 = new Local("Bernal", 30, "Rosario", 2.65f);
                Provincial l2 = new Provincial("Morón", Franja.Franja_1, 21, "Bernal");
                Local l3 = new Local("Lanús", 45, "San Rafael", 1.99f);
                Provincial l4 = new Provincial(l2, Franja.Franja_3);

                // Las llamadas se irán registrando en la Centralita. // La centralita mostrará por pantalla todas las llamadas según las vaya registrando. 
                c.Llamadas.Add(l1);
                Console.WriteLine(c.Mostrar());
                c.Llamadas.Add(l2);
                Console.WriteLine(c.Mostrar());
                c.Llamadas.Add(l3);
                Console.WriteLine(c.Mostrar());
                c.Llamadas.Add(l4);
                Console.WriteLine(c.Mostrar()); 

                c.OrdenarLlamadas();
                Console.WriteLine("ORDENADAS");
                Console.WriteLine(c.Mostrar());*/

            Thread simu = new Thread(new ParameterizedThreadStart(Simulador.SimuladorCentralita));
            simu.Start(c);

            string respuesta = "0";
            do
            {
                Console.WriteLine("1)Listar locales");
                Console.WriteLine("2)Listar provinciales");
                Console.WriteLine("3)Listar todas");
                Console.WriteLine("4)Salir");
                respuesta = Console.ReadLine();
                switch(respuesta)
                {
                    case "1":
                        Console.WriteLine(c.Mostrar());
                        break;
                    case "2":
                        Console.WriteLine(c.GananciasPorProvincial);
                        break;
                    case "3":
                        Console.WriteLine(c.GananciasPorTotal);
                        break;
                    case "4":
                        respuesta = "4";
                        simu.Abort();
                        break;
                }
            } while (respuesta != "4");      
		}
	}
}
