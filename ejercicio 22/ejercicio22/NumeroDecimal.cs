using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio22
{
    public class NumeroDecimal
    {
        private double numero;

        private NumeroDecimal(double dbl)
        {
            this.numero = dbl;
        }

        public double getNumero()
        {
            return this.numero;
        }

        public static double operator +(NumeroDecimal nDec, NumeroBinario nBin)
        {
            double conv;

            conv = Conversor.BinarioDecimal(nBin.getNumero());

            return conv + nDec.getNumero();
        }

        public static double operator -(NumeroDecimal nDec, NumeroBinario nBin)
        {
            double conv;

            conv = Conversor.BinarioDecimal(nBin.getNumero());

            return conv - nDec.getNumero();
        }

        public static bool operator ==(NumeroDecimal nDec, NumeroBinario nBin)
        {
            double conv;

            conv = Conversor.BinarioDecimal(nBin.getNumero());

            if (conv == nDec.getNumero())
                return true;
            return false;
        }

        public static bool operator !=(NumeroDecimal nDec, NumeroBinario nBin)
        {
            return !(nDec == nBin);
        }

        public static implicit operator NumeroDecimal(double dbl)
        {
            return new NumeroDecimal(dbl);
        }

        public static explicit operator Double(NumeroDecimal nDec)
        {
            return nDec.getNumero();
        }

        
    }
}
