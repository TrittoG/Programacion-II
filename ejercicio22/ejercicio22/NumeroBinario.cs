using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio22
{
    public class NumeroBinario
    {
        public string numero;

        private NumeroBinario(string str)
        {
            this.numero = str;
        }

        public string getNumero()
        {
            return this.numero;
        }


        public static string operator +(NumeroBinario nBin, NumeroDecimal nDec)
        {
            double convertido;
            string resultado;

            convertido = Conversor.BinarioDecimal(nBin.getNumero());
            convertido = convertido + nDec.getNumero();
            resultado = Conversor.DecimalBinario(convertido);

            return resultado;

        }

        public static string operator -(NumeroBinario nBin, NumeroDecimal ndec)
        {
            double convertido;
            string resultado;

            convertido = Conversor.BinarioDecimal(nBin.getNumero());
            convertido = convertido - ndec.getNumero();
            resultado = Conversor.DecimalBinario(convertido);

            return resultado;
        }
        
        public static bool operator ==(NumeroBinario nBin, NumeroDecimal nDec)
        {
            double conv;

            conv = Conversor.BinarioDecimal(nBin.getNumero());

            if (conv == nDec.getNumero())
                return true;
            return false;
        }

        public static bool operator !=(NumeroBinario nBin, NumeroDecimal nDec)
        {
            return !(nBin == nDec);
        }

        public static implicit operator NumeroBinario(string str)
        {
            return new NumeroBinario(str);
        }

        public static explicit operator string(NumeroBinario nBin)
        {
            return nBin.getNumero();
        }
    }
}
