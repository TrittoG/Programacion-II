using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio19
{
    class Sumador
    {
        private int CantidadSumas;
        public Sumador(int i)
        {
            this.CantidadSumas = i;
        }
        public Sumador() : this(0)
        { }
        public long Sumar(long a, long b)
        {
            this.CantidadSumas++;
            return a + b;
        }
        public string Sumar(string a, string b)
        {
            this.CantidadSumas++;
            return a + b;
        }
        public static explicit operator int(Sumador s)
        {
            return s.CantidadSumas;
        }
        public static long operator +(Sumador s1, Sumador s2)
        {
            return s1.CantidadSumas + s2.CantidadSumas;
        }
        public static bool operator |(Sumador s1, Sumador s2)
        {
            if (s1.CantidadSumas == s2.CantidadSumas)
                return true;
            else
                return false;
        }
    }
}
