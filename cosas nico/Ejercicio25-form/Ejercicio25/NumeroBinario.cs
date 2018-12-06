using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio25
{
    public class NumeroBinario
    {
        private string Numero;

        private NumeroBinario(string n)
        {
            this.Numero = n;
        }

        public string GetNumero()
        {
            return this.Numero;
        }

        public static string operator +(NumeroBinario nb, NumeroDecimal nd)
        {
            if(!(nb is null) || !(nd is null))
            {
                double nbb = Conversor.BinarioDecimal(nb.Numero);
                nbb = nbb + nd.GetNumero();
                return Conversor.DecimalBinario(nbb);
            }
            return null;
        }
        public static string operator -(NumeroBinario nb, NumeroDecimal nd)
        {
            if (!(nb is null) || !(nd is null))
            {
                double nbb = Conversor.BinarioDecimal(nb.Numero);
                nbb = nbb - nd.GetNumero();
                return Conversor.DecimalBinario(nbb);
            }
            return null;
        }

        public static bool operator ==(NumeroBinario nb, NumeroDecimal nd)
        {
            if (!(nb is null) || !(nd is null))
                if (Conversor.BinarioDecimal(nb.Numero) == nd.GetNumero())
                    return true;
            return false;
        }

        public static bool operator !=(NumeroBinario nb, NumeroDecimal nd)
        {
            return !(nb == nd);
        }

        public static implicit operator NumeroBinario(string n)
        {
            return new NumeroBinario(n);
        }

        public static implicit operator string(NumeroBinario nb)
        {
            return nb.Numero;
        }
    }
}
