using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    class Dolares
    {
        private double Cantidad;
        private static float CotizRespectoDolar;
        static Dolares()
        {
            CotizRespectoDolar = 1;
        }

        public Dolares(double cantidad)
        {
            this.Cantidad = cantidad;
        }

        public Dolares(double cantidad, float cotizacion) :this(cantidad)
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

        public static explicit operator Pesos(Dolares d)
        {
            Pesos p = new Pesos(d.GetCantidad());
            p = new Pesos(p.GetCantidad() / p.GetCotizacion());
            return p;
        }

        public static explicit operator Euros(Dolares d)
        {
            Euros e = new Euros(d.GetCantidad());
            e = new Euros(e.GetCantidad() * e.GetCotizacion());
            return e;
        }

        public static implicit operator Dolares(double d)
        {
            Dolares e = new Dolares(d);
            return e;
        }

        public static bool operator !=(Dolares d, Pesos p)
        {
            if(!(d is null) || !(p is null))
                if ((Dolares)p != d)
                    return true;
            return false;
        }

        public static bool operator ==(Dolares e, Pesos p)
        {
            return !(e != p);
        }

        public static bool operator !=(Dolares d, Euros p)
        {
            if ((Dolares)p != d)
                return true;
            return false;
        }

        public static bool operator ==(Dolares e, Euros p)
        {
            if (e == (Dolares)p)
                return true;
            return false;
        }

        public static bool operator !=(Dolares d, Dolares d2)
        {
            if (d != d2)
                return true;
            return false;
        }

        public static bool operator ==(Dolares d, Dolares d2)
        {
            if (d == d2)
                return true;
            return false;
        }

        public static Dolares operator +(Dolares d, Pesos p)
        {
            double suma = d.GetCantidad() + ((Dolares)p).GetCantidad();
            return new Dolares(suma);
        }

        public static Dolares operator +(Dolares d, Euros e)
        {
            double suma = d.GetCantidad() + ((Dolares)e).GetCantidad();
            return new Dolares(suma);
        }

        public static Dolares operator -(Dolares d, Pesos p)
        {
            double resta = d.GetCantidad() - ((Dolares)p).GetCantidad();
            return new Dolares(resta);
        }

        public static Dolares operator -(Dolares d, Euros e)
        {
            double resta = d.GetCantidad() - ((Dolares)e).GetCantidad();
            return new Dolares(resta);
        }
    }
}
