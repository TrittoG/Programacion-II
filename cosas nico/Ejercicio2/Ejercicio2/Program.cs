using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Title = "Ejercicio Nro 2";

      int numero;
      string numeroStr;

      Console.WriteLine("Ingrese un numero");
      numeroStr = Console.ReadLine();
      numero = int.Parse(numeroStr);
      if(numero > 0)
      {
        Console.WriteLine("Eleveado a la 2: " + Math.Pow(numero, 2));
        Console.WriteLine("Eleveado a la 3: " + Math.Pow(numero, 3));
      }
      else
      {
        Console.WriteLine("ERROR. ¡Reingresar número!");
      }
      Console.ReadKey();
    }
  }
}
