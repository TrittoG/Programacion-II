using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Title = "Ejercicio Nro 4";
      int i=0,j,encontrados=0,suma = 0;
      do
      {
        i++;
        j = 1;
        suma = 0;
        while(j != i)
        {
          if((i % j) == 0)
          {
            suma = suma + j;
          }
          j++;
        }
        if(suma == i)
        {
          encontrados++;
          Console.WriteLine(i);
        }
      } while (encontrados != 4);
      Console.ReadKey();
    }
  }
}
