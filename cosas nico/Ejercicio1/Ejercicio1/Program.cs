using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
  class Program
  {
    static void Main(string[] args)
    {
      int numero;
      string numeroStr;
      int minimo;
      int maximo;
      float promedio;
      Console.WriteLine("Ingrese el primer numero");
      numeroStr = Console.ReadLine();
      numero = int.Parse(numeroStr);
      minimo = numero;
      maximo = numero;
      promedio = numero;

      Console.WriteLine("Ingrese el segundo numero");
      numeroStr = Console.ReadLine();
      numero = int.Parse(numeroStr);
      if(numero < minimo)
        minimo = numero;
      if (numero > maximo)
        maximo = numero;
      promedio = promedio + numero;

      Console.WriteLine("Ingrese el tercer numero");
      numeroStr = Console.ReadLine();
      numero = int.Parse(numeroStr);
      if (numero < minimo)
        minimo = numero;
      if (numero > maximo)
        maximo = numero;
      promedio = promedio + numero;

      Console.WriteLine("Ingrese el cuarto numero");
      numeroStr = Console.ReadLine();
      numero = int.Parse(numeroStr);
      if (numero < minimo)
        minimo = numero;
      if (numero > maximo)
        maximo = numero;
      promedio = promedio + numero;

      Console.WriteLine("Ingrese el quinto numero");
      numeroStr = Console.ReadLine();
      numero = int.Parse(numeroStr);
      if (numero < minimo)
        minimo = numero;
      if (numero > maximo)
        maximo = numero;
      promedio = promedio + numero;

      Console.Write("El minimo es: ");
      Console.WriteLine(minimo);
      Console.Write("El maximo es: ");
      Console.WriteLine(maximo);
      promedio = promedio / 5;
      Console.Write("El promedio es: ");
      Console.WriteLine(promedio);
      Console.ReadKey();
    }
  }
}
