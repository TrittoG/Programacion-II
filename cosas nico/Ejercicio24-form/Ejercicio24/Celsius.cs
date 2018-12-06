using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio24
{
    public class Celsius
    {
        private double temp;

        public Celsius(double temp)
        {
            this.temp = temp;
        }

        public Celsius() : this(0)
        { }

        public double GetTemp()
        {
            return this.temp;
        }

        public static implicit operator Celsius(double d)
        {
            return new Celsius(d);
        }

        public static explicit operator Fahrenheit(Celsius c)
        {
            return new Fahrenheit((c.GetTemp() * 9/5) + 32);
        }

        public static explicit operator Kelvin(Celsius c)
        {
            Fahrenheit f = (Fahrenheit)c;
            return (Kelvin)f;
        }

        public static bool operator ==(Celsius c1, Celsius c2)
        {
            if (!(c1 is null) || !(c2 is null))
                if (c1.temp == c2.temp)
                    return true;
            return false;
        }

        public static bool operator !=(Celsius c1, Celsius c2)
        {
            return !(c1 == c2);
        }

        public static bool operator ==(Celsius c, Fahrenheit f)
        {
            if (!(c is null) || !(f is null))
                if (c.temp == ((Celsius)f).temp)
                    return true;
            return false;
        }

        public static bool operator !=(Celsius c, Fahrenheit f)
        {
            return !(c == f);
        }

        public static bool operator ==(Celsius c, Kelvin k)
        {
            if (!(c is null) || !(k is null))
                if (c.temp == ((Celsius)k).temp)
                    return true;
            return false;
        }

        public static bool operator !=(Celsius c, Kelvin k)
        {
            return !(c == k);
        }
    }
}
