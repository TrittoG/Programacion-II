using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monedas
{
    public class Euros
    {
        private double Cantidad;
        private static float CotizRespectoDolar;
        static Euros()
        {
            CotizRespectoDolar = (float)0.733;
        }

        public Euros(double cantidad)
        {
            this.Cantidad = cantidad;
        }

        public Euros(double cantidad, float cotizacion) :this(cantidad)
        {
            CotizRespectoDolar = cotizacion;
        }

        public double GetCantidad()
        {
            return this.Cantidad;
        }

        public float GetCotizacion()
        {
            return CotizRespectoDolar;
        }

        public static explicit operator Dolares(Euros e)
        {
            Dolares d = new Dolares(e.Cantidad * CotizRespectoDolar);
            return d;
        }

        public static explicit operator Pesos(Euros e)
        {
            Dolares d = (Dolares)e;
            Pesos p = new Pesos(d.GetCantidad());
            p = new Pesos(p.GetCantidad() / p.GetCotizacion());
            return p;
        }

        public static implicit operator Euros(double d)
        {
            Euros e = new Euros(d);
            return e;
        }

        public static bool operator !=(Euros e, Dolares d)
        {
            if (e != (Euros)d)
                return true;
            return false;
        }

        public static bool operator ==(Euros e, Dolares d)
        {
            if (e == (Euros)d)
                return true;
            return false;
        }

        public static bool operator !=(Euros e, Pesos d)
        {
            if (e != (Euros)d)
                return true;
            return false;
        }

        public static bool operator ==(Euros e, Pesos d)
        {
            if (e == (Euros)d)
                return true;
            return false;
        }

        public static bool operator !=(Euros e, Euros e2)
        {
            if (e != e2)
                return true;
            return false;
        }

        public static bool operator ==(Euros e, Euros e2)
        {
            if(e == e2)
                return true;
            return false;
        }

        public static Euros operator +(Euros e, Pesos p)
        {
            double suma = e.GetCantidad() + ((Euros)p).GetCantidad();
            return new Euros(suma);
        }

        public static Euros operator +(Euros e, Dolares d)
        {
            double suma = e.GetCantidad() + ((Euros)d).GetCantidad();
            return new Euros(suma);
        }

        public static Euros operator -(Euros e, Pesos p)
        {
            double resta = e.GetCantidad() - ((Euros)p).GetCantidad();
            return new Euros(resta);
        }

        public static Euros operator -(Euros e, Dolares d)
        {
            double resta = e.GetCantidad() - ((Euros)d).GetCantidad();
            return new Euros(resta);
        }
    }
}
