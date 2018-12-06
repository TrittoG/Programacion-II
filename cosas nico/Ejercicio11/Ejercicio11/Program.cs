using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio11
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Title = "Ejercicio Nro 11";
      int numero, max = -101, min = 101, suma = 0, i, error = 1;
      float promedio;
      string numeroStr;
      for(i = 0; i < 10; i++)
      {
        numeroStr = Console.ReadLine();
        if(int.TryParse(numeroStr, out numero))
        {
          if(Validacion.Validar(numero, -100, 100))
          {
            if(numero < min)
            {
              min = numero;
            }
            if(numero > max)
            {
              max = numero;
            }
            suma = suma + numero;
          }
          else
          {
            Console.WriteLine("Numero invalido");
            error = 0;
            break;
          }
        }
      }
      if(error == 1)
      {
        Console.WriteLine("El minimo es {0}", min);
        Console.WriteLine("El maximo es {0}", max);
        promedio = (float)suma / 10;
        Console.WriteLine("El promedio es {0:###,##.00}" , promedio);
      }
      Console.ReadKey();
    }
  }
}
