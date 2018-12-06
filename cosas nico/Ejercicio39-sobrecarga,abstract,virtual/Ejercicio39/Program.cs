using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio39
{
	class Program
	{
		static void Main(string[] args)
		{
            SobreSobreescrito newesc = new SobreSobreescrito();

            Console.WriteLine(newesc.MiMetodo());
            Console.ReadKey();
		}
	}
}
