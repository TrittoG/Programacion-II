using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_6
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Title = "EJERCICIO 6";

      int anio;
      string anioString;
      string respuesta;
      respuesta = "s";

      do
      {
        Console.WriteLine("ingrese un año para ver si es biciesto... ");
        anioString = Console.ReadLine();

        if (int.TryParse(anioString, out anio))
        {

          if (anio % 4 == 0 && anio % 100 != 0 || anio % 400 == 0)
          {
            Console.WriteLine("el año {0} es biciesto", anio);
          }
          else
          {
            Console.WriteLine("el año {0} no es biciesto", anio);
          }
          Console.WriteLine("quiere probar con otro año? s/n.");
          respuesta = Console.ReadLine();
          Console.Clear();
        }
      } while (respuesta != "n");
    }
  }
}
