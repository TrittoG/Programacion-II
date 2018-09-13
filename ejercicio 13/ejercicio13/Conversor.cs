using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio13
{
    class Conversor
    {
        public static string DecimalBinario(double doble)
        {
            string binario = "";

            while(doble > 0)
            {
                
                
                if(doble % 2 == 1)
                {
                    binario = '1' + binario;
                }
                else
                {
                    binario = '0' + binario ;
                }

                doble = (int)doble / 2;

            }
            return binario;
        }

        public static double BinarioDecimal(string binario)
        {
            double retorno = 0;
            int i,j = binario.Length;

            for (i = 0; i < binario.Length ; i++)
            {
                j--;
                if (binario[i] == '1')
                {
                    retorno = retorno + Math.Pow(2, j);
                }
                
            }

            return retorno;
        }
    }
}
