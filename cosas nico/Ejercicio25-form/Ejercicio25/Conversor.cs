using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio25
{
  public class Conversor
  {
    public static string DecimalBinario(double decim)
    {
      string binario = "";
      while(decim > 0)
      {
        if(decim % 2 == 0)
		{
			binario = "0" + binario;
		}
		else
		{
			binario = "1" + binario;
		}
        decim = (int)decim / 2;
      }
      return binario;
    }
    public static double BinarioDecimal(string binario)
    {
		char[] charArray = binario.ToCharArray();
		Array.Reverse(charArray);
		double decim = 0;
		int tam = binario.Length;
		int i;
		
		for(i = 0; i < tam; i++)
		{
			if(charArray[i] == '1')
			{
				decim = decim + Math.Pow(2, i);
			}
		}
		return decim;
    }

  }
}
