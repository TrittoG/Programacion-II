using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Ejercicio_48
{
	class Program
	{
		static void Main(string[] args)
		{
			Contabilidad<Recibo, Factura> asd = new Contabilidad<Recibo, Factura>();
			int i = 0;
			Random a = new Random();
			while (i != 10)
			{
				Factura dos = new Factura(a.Next(1, 10000));
				System.Threading.Thread.Sleep(250);
				Recibo uno = new Recibo(a.Next(1, 10000));
				System.Threading.Thread.Sleep(250);
				
					asd += uno;
				
					asd += dos;
				i++;
				Console.WriteLine(i);
			}

			Console.WriteLine(Contabilidad<Recibo, Factura>.Mostrar(asd));
			Console.ReadKey();

		}
	}
}
