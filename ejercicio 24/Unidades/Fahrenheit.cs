using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidades
{
    public class Fahrenheit
    {
        private double temp;

        public Fahrenheit(double temp)
        {
            this.temp = temp;
        }

        public Fahrenheit() :this(0)
        { }

        public double GetTemp()
        {
            return this.temp;
        }

        public static implicit operator Fahrenheit(double d)
        {
            return new Fahrenheit(d);
        }

        public static explicit operator Kelvin(Fahrenheit f)
        {
            return new Kelvin((f.GetTemp() + 459.67) * 5 / 9);
        }

        public static explicit operator Celsius(Fahrenheit f)
        {
            return new Celsius((f.GetTemp() - 32) * 5/9);
        }

        public static bool operator ==(Fahrenheit f1, Fahrenheit f2)
        {
            if(!(f1 is null) || !(f2 is null))
                if (f1.temp == f2.temp)
                    return true;
                else
                    return false;
            return false;
        }

        public static bool operator !=(Fahrenheit f1, Fahrenheit f2)
        {
            return !(f1 == f2);
        }

        public static bool operator ==(Fahrenheit f, Celsius c)
        {
            if (!(f is null) || !(c is null))
                if (f.temp == ((Fahrenheit)c).temp)
                    return true;
                else
                    return false;
            return false;
        }

        public static bool operator !=(Fahrenheit f, Celsius c)
        {
            return !(f == c);
        }

        public static bool operator ==(Fahrenheit f, Kelvin k)
        {
            if (!(f is null) || !(k is null))
                if (f.temp == ((Fahrenheit)k).temp)
                    return true;
                else
                    return false;
            return false;
        }

        public static bool operator !=(Fahrenheit f, Kelvin k)
        {
            return !(f == k);
        }
    }
}
