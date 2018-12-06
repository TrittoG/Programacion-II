using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio47;

namespace ConsoleTest
{
	class Program
	{
		static void Main(string[] args)
		{
			Torneo<EquipoFutbol> torneoFutbol = new Torneo<EquipoFutbol>("Super Liga");
			Torneo<EquipoBasket> torneoBasket = new Torneo<EquipoBasket>("Basket Argentina");

			EquipoFutbol boca = new EquipoFutbol("Boca");
			EquipoFutbol river = new EquipoFutbol("River");
			EquipoFutbol estu = new EquipoFutbol("Estudiantes");

			EquipoBasket laker = new EquipoBasket("Lakers");
			EquipoBasket spurs = new EquipoBasket("San Antonio");
			EquipoBasket nyx = new EquipoBasket("New York city");

			torneoFutbol += boca;
			torneoFutbol += river;
			torneoFutbol += estu;

			torneoBasket += laker;
			torneoBasket += spurs;
			torneoBasket += nyx;

			Console.WriteLine(Torneo<EquipoFutbol>.Mostrar(torneoFutbol));
			Console.WriteLine("--------------------------------------------");
			Console.WriteLine(Torneo<EquipoBasket>.Mostrar(torneoBasket));
			Console.WriteLine("--------------------------------------------");
			Console.WriteLine(torneoFutbol.JugarPartido);
			Console.WriteLine("--------------------------------------------");
			Console.WriteLine(torneoFutbol.JugarPartido);
			Console.WriteLine("--------------------------------------------");
			Console.WriteLine(torneoFutbol.JugarPartido);
			Console.WriteLine("--------------------------------------------");
			Console.WriteLine(torneoBasket.JugarPartido);
			Console.WriteLine("--------------------------------------------");
			Console.WriteLine(torneoBasket.JugarPartido);
			Console.WriteLine("--------------------------------------------");
			Console.WriteLine(torneoBasket.JugarPartido);

			Console.ReadKey();
		}
	}
}
