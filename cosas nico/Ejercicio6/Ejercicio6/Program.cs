using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Title = "Ejercicio Nro 6";
      int numero;
      string numeroStr;
      numeroStr = Console.ReadLine();
      if(int.TryParse(numeroStr, out numero))
      {
        if(numero >= 0)
        {
          if (numero % 4 == 0 && (numero % 100 != 0) || (numero % 400 == 0))
            Console.WriteLine("Es biciesto");
          else
            Console.WriteLine("No es biciesto");
        }
      }
      Console.ReadKey();
    }
  }
}
