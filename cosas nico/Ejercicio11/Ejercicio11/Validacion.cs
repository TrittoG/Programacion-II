using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio11
{
  public class Validacion
  {
    public static bool Validar(int valor, int min, int max)
    {
      if (valor > max || valor < min)
        return false;
      else
        return true;
    }
  }
}
