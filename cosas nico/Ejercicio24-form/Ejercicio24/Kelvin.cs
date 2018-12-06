using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio24
{
    public class Kelvin
    {
        private double temp;

        public Kelvin(double temp)
        {
            this.temp = temp;
        }

        public Kelvin() : this(0)
        { }

        public double GetTemp()
        {
            return this.temp;
        }

        public static implicit operator Kelvin(double d)
        {
            return new Kelvin(d);
        }

        public static explicit operator Fahrenheit(Kelvin k)
        {
            return new Fahrenheit((k.GetTemp() * 9/5) - 459.67);
        }

        public static explicit operator Celsius(Kelvin k)
        {
            Fahrenheit f = (Fahrenheit)k;
            return (Celsius)f;
        }

        public static bool operator ==(Kelvin k1, Kelvin k2)
        {
            if (!(k1 is null) || !(k2 is null))
                if (k1.temp == k2.temp)
                    return true;
            return false;
        }

        public static bool operator !=(Kelvin k1, Kelvin k2)
        {
            return !(k1 == k2);
        }

        public static bool operator ==(Kelvin k, Fahrenheit f)
        {
            if (!(k is null) || !(f is null))
                if (k.temp == ((Kelvin)f).temp)
                    return true;
            return false;
        }

        public static bool operator !=(Kelvin k, Fahrenheit f)
        {
            return !(k == f);
        }

        public static bool operator ==(Kelvin k, Celsius c)
        {
            if (!(k is null) || !(c is null))
                if (k.temp == ((Kelvin)c).temp)
                    return true;
            return false;
        }

        public static bool operator !=(Kelvin k, Celsius c)
        {
            return !(k == c);
        }
    }
}
