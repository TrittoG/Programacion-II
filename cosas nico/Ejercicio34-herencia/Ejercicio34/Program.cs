using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio34
{
    class Program
    {
        static void Main(string[] args)
        {
            Moto zanella = new Moto(50, 2, 0, Colores.Azul);
            Automovil gol = new Automovil(5, 4, 4, 5, Colores.Rojo);
            Camion mercedez = new Camion(6, 20000, 6, 3, Colores.Negro);

            Console.WriteLine(Moto.Mostrar(zanella));
            Console.WriteLine(Automovil.Mostrar(gol));
            Console.WriteLine(Camion.Mostrar(mercedez));
            Console.ReadKey();
        }
    }
}
