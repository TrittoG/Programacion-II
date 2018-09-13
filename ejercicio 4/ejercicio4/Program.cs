using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "ejercicio 4";

            int i, numero,cantidad, suma = 0;
            cantidad = 0;
            numero = 1;
            while(cantidad != 4)
            {
                suma = 0;
                for (i= 1;i<numero;i++)
                {
                    if(numero % i == 0)
                    {
                        suma = i + suma;
                    }
                    
                }
                if (suma == numero)
                {
                    Console.WriteLine("numero perfecto = " + numero);
                    cantidad++;
                }
                numero++;
            }

            Console.ReadKey();
        }
    }
}
