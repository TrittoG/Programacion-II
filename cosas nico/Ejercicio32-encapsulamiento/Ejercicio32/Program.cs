using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio32
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio NRO 32";
            Equipo boca = new Equipo("Boca", 11);
            Jugador tevez = new Jugador(20456987, "Carlos", 10, 5);
            Jugador pavon = new Jugador(20456947, "Carlos", 10, 5);
            if (boca + tevez)
            {
                Console.WriteLine("Se agrego");
            }
            else
                Console.WriteLine("No se pudo agregar");
            if (boca + tevez)
            {
                Console.WriteLine("Se agrego");
            }
            else
                Console.WriteLine("No se pudo agregar");
            if (tevez == pavon)
                Console.WriteLine("Son iguales");
            else
                Console.WriteLine("Son diferentes");
            Console.ReadKey();
        }
    }
}
