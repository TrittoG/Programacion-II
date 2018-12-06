using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio12
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Title = "Ejercicio Nro 12";
      int valor, suma = 0;
      char respuesta = 'n';
      string valorStr, respStr;
      do
      {
        Console.WriteLine("Ingrese un valor entero");
        valorStr = Console.ReadLine();
        if(int.TryParse(valorStr, out valor))
        {
          suma = valor + suma;
          Console.WriteLine("La suma es: " + suma);
        }
        else
        {
          Console.Write("Valor invalido");
        }
        
        Console.WriteLine("Ingrese s para seguir sumando, n para dejar de sumar");
        respStr = Console.ReadLine();
        char.TryParse(respStr, out respuesta);
        
      } while (ValidarRespuesta.ValidarS_N(respuesta));
    }
  }
}
