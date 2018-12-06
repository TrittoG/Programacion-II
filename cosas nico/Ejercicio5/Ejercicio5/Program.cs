using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Title = "Ejercicio Nro 5";
      int numero;
      string numeroStr;

      numeroStr = Console.ReadLine();
      if (int.TryParse(numeroStr, out numero))
      {
        if (numero > 1)
        {
          int i, j, y, sumaIzq = 0, sumaDer = 0;
          for(i = 2; i <= numero; i++)
          {
            sumaIzq = 0;
            sumaDer = 0;
            for(j = 1; j < i; j++)
            {
              sumaIzq = sumaIzq + j;
            }
            for(y = i+1; sumaIzq > sumaDer; y++)
            {
              sumaDer = sumaDer + y;
              if(sumaIzq == sumaDer)
              {
                Console.WriteLine("Es centro numerico: "+ i);
                break;
              }
            }
          }
        }
      }
      Console.ReadKey();
    }
  }
}
