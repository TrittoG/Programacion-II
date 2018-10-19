using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca;

namespace Consolita
{
    class Program
    {
        static void Main(string[] args)
        {
            //Torneo<EquipoFutbol> = new Torneo<EquipoFutbol>()

            DateTime fecha = new DateTime(2012,4,12);

            EquipoBasquet basket = new EquipoBasquet("Estudiantes", fecha);
            EquipoBasquet basket2 = new EquipoBasquet("Deportivo", fecha);
            EquipoBasquet basquet3 = new EquipoBasquet("Calaveras", fecha);

            EquipoFutbol futbol = new EquipoFutbol("Boca", fecha);
            EquipoFutbol river = new EquipoFutbol("River", fecha);
            EquipoFutbol riber = new EquipoFutbol("River", fecha);
            EquipoFutbol Estudiantes = new EquipoFutbol("Estudiantes de la plata", fecha);

            Torneo<EquipoBasquet> torneoBasket = new Torneo<EquipoBasquet>("Torneo de Basket");
            Torneo<EquipoFutbol> torneoFutbol = new Torneo<EquipoFutbol>("torneo de futbol");

            torneoBasket += basket;
            torneoBasket += basket2;
            torneoBasket += basquet3;

            torneoFutbol += futbol;
            torneoFutbol += river;
            torneoFutbol += riber;
            torneoFutbol += Estudiantes;

            Console.WriteLine(torneoBasket.Mostrar());
            Console.WriteLine( torneoFutbol.Mostrar());

            Console.WriteLine( torneoFutbol.JugarPartido);


            Console.ReadKey();

        }
    }
}
