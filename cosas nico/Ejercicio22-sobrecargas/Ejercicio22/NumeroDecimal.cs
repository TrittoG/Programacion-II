using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio22
{
    class NumeroDecimal
    {
        private double Numero;

        private NumeroDecimal(double n)
        {
            this.Numero = n;
        }

        public double GetNumero()
        {
            return this.Numero;
        }

        public static double operator +(NumeroDecimal nd, NumeroBinario nb)
        {
            if (!(nb is null) || !(nd is null))
            {
                double nbb = Conversor.BinarioDecimal(nb.GetNumero());
                nbb = nbb + nd.GetNumero();
                return nbb;
            }
            return nd.Numero;
        }
        public static double operator -(NumeroDecimal nd, NumeroBinario nb)
        {
            if (!(nb is null) || !(nd is null))
            {
                double nbb = Conversor.BinarioDecimal(nb.GetNumero());
                nbb = nbb - nd.Numero;
                return nbb;
            }
            return nd.Numero;
        }

        public static bool operator ==(NumeroDecimal nd, NumeroBinario nb)
        {
            if (!(nb is null) || !(nd is null))
                if (Conversor.BinarioDecimal(nb.GetNumero()) == nd.Numero)
                    return true;
            return false;
        }

        public static bool operator !=(NumeroDecimal nd, NumeroBinario nb)
        {
            return !(nb == nd);
        }

        public static implicit operator NumeroDecimal(double d)
        {
            return new NumeroDecimal(d);
        }

        public static explicit operator double(NumeroDecimal d)
        {
            return d.Numero;
        }
    }
}
