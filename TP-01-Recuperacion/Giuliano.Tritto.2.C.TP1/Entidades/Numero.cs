using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
  public class Numero
  {
    private double numero;

    public string SetNumero
    {
      set
      {
        this.numero = ValidarNumero(value);
      }
    }

    public Numero()
    {
      this.numero = 0;
    }

    public Numero(double numero)
    {
      this.numero = numero;
    }

    public Numero(string strNumero)
    {
      this.SetNumero = strNumero;
    }

    private double ValidarNumero(string strNumero)
    {

      foreach(char c in strNumero)
      {
        if(c < 0 || c > 9)
        {
          return 0;
        }
      }

      return double.Parse(strNumero);
    }



    public static double operator +(Numero n1, Numero n2)
    {
         return n1.numero + n2.numero;
    }

    public static double operator -(Numero n1, Numero n2)
    {
      return n1.numero - n2.numero;
    }

    public static double operator *(Numero n1, Numero n2)
    {
      return n1.numero * n2.numero;
    }

    public static double operator /(Numero n1, Numero n2)
    {
      return n1.numero / n2.numero;
    }


    public string BinarioDecimal(string binario)
    {
        
    }

    public string DecimalBinario(string numero)
    {

    }

    public string DecimalBinario(double numero)
    {

    }
  }
}
