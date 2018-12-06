using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Title = "Ejercicio Nro 3";

      int numero;
      string numeroStr;

      Console.WriteLine("Ingrese un numero");
      numeroStr = Console.ReadLine();
      if(int.TryParse(numeroStr, out numero))
      {
        if(numero > 1)
        {
          int i,j,cont;
          for(i = 1; i <= numero; i++)
          {
            cont = 0;
            for(j = 1; j <= i; j++)
            {
              if((i % j) == 0)
              {
                cont++;
              }
            }
            if(cont == 2)
            {
              Console.WriteLine(i);
            }
          }
        }
      }
      Console.ReadKey();
    }
  }
}
