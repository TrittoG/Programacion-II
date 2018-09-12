using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercico5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "ejercicio 5";

            int numero,i,suma,suma2,otra;
            string numeroString;

            Console.Write("ingrese un numero: ");
            numeroString = Console.ReadLine();
            if(int.TryParse(numeroString, out numero))
            {
                

                for(i=0; i<=numero;i++)
                {
                    suma = 0;
                    suma2 = 0;

                    for (int j=1;j<=i;j++)
                    {
                        suma = suma + j;
                    }
                    for (int j = numero; j >= i+2; j--)
                    {
                        suma2 = suma2 + j;
                    }
                    if(suma == suma2)
                    {
                        otra = i + 1;
                        Console.WriteLine("el centro es: " + otra);
                    }
                    if (suma > suma2 || i == numero - 1 || numero == 1)
                    {
                        Console.WriteLine("el centro no existe");
                    }
                }

            }
        }
    }
}
