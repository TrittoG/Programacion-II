using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio19
{
    class Program
    {
        static void Main(string[] args)
        {
            Sumador suma1 = new Sumador();
            Sumador suma2 = new Sumador(5);
            suma1.Sumar(24, 1);
            suma1.Sumar("asd", "ll");
            Console.WriteLine(suma1 + suma2);
            if(!(suma1 | suma2))
            {
                Console.WriteLine("Diferentes");
            }
            Console.WriteLine((int)suma1);
            Console.ReadKey();
        }
    }
}
