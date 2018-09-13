using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio13
{
    class Program
    {
        static void Main(string[] args)
        {
            string respuesta;
            string seguir = "n";
            int valor;
            string valoor;
            string binario;
            double dec;

            Console.Title = "EJERÇICIO 13";
            do
            {
                Console.WriteLine("eleji decimal o binario d/b...");
                respuesta = Console.ReadLine();

                if (respuesta == "d")
                {
                    Console.WriteLine("ingrese el valor decimal");
                    valoor = Console.ReadLine();
                    if (int.TryParse(valoor, out valor))
                    {
                        binario = Conversor.DecimalBinario(valor);
                        Console.WriteLine("el valor {0} en binario es {1}", valor, binario);
                    }

                }
                else if(respuesta == "b")
                {
                    Console.WriteLine("ingrese el valor binario: ");
                    valoor = Console.ReadLine();

                    dec = Conversor.BinarioDecimal(valoor);
                    Console.WriteLine("el valor en decimal de {0} es {1}", valoor, dec);
                }

                Console.WriteLine("desea probar con otro valor s /n ?");
                seguir = Console.ReadLine();

            } while (seguir != "n");
           

        }
    }
}
