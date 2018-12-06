using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio35
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio NRO 35";

            Jugador n1 = new Jugador(38364000, "Nico", 20, 10);
            Jugador n2 = new Jugador(25364123, "GGT", 01, 10);
            DirectorTecnico dt = new DirectorTecnico("Jorge", DateTime.MinValue);

            Equipo equipo1 = new Equipo("Sub 21", 2, dt);

            Console.WriteLine("Jugador uno\n" + n1.MostrarDatosJugador());
            Console.WriteLine("Jugador dos\n" + n2.MostrarDatosJugador());
            Console.WriteLine("Dt" + dt.MostrarDatosDT());

            Console.ReadKey();
        }
    }
}
