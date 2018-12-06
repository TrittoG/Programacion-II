using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio51
{
    class Program
    {
        static void Main(string[] args)
        {
			Centralita cen = new Centralita("Nico");
			Local asd = new Local("Pehua", 12, "asd", 12);
			Provincial dsa = new Provincial("asdsad", Franja.Franja_1, 231, "asdas");

			try
			{
				cen += asd;
				cen += dsa;
				cen += asd;
			}
			catch(Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
			Console.ReadKey();
        }
    }
}
