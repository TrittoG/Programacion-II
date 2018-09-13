using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Monedas
{
    public class Pesos
    {
        private double Cantidad;
        private static float CotizRespectoDolar;

        public Pesos(double cantidad, float cotizacion) : this(cantidad)
        {
            CotizRespectoDolar = cotizacion;
        }

        public Pesos(double cantidad)
        {
            this.Cantidad = cantidad;
        }

        static Pesos()
        {
            CotizRespectoDolar = (float)17.55;
        }

        public double GetCantidad()
        {
            return this.Cantidad;
        }

        public float GetCotizacion()
        {
            return CotizRespectoDolar;
        }

        public static explicit operator Dolares(Pesos p)
        {
            Dolares a = new Dolares(p.GetCantidad() / p.GetCotizacion());
            return a;
        }

        public static explicit operator Euros(Pesos p)
        {
            Dolares d = (Dolares)p;
            Euros e = (Euros)d;
            return e;
        }

        public static implicit operator Pesos(double p)
        {
            Pesos d = new Pesos(p);
            return d;
        }

        public static bool operator !=(Pesos e, Dolares d)
        {
            if (e != (Pesos)d)
                return true;
            return false;
        }

        public static bool operator ==(Pesos e, Dolares d)
        {
            if(e == (Pesos)d)
                return true;
            return false;
        }

        public static bool operator !=(Pesos e, Euros d)
        {
            if (e != (Pesos)d)
                return true;
            return false;
        }

        public static bool operator ==(Pesos e, Euros d)
        {
            if (e == (Pesos)d)
                return true;
            return false;
        }

        public static bool operator !=(Pesos p, Pesos p2)
        {
            if (p != p2)
                return true;
            return false;
        }

        public static bool operator ==(Pesos p, Pesos p2)
        {
            if (p == p2)
                return true;
            return false;
        }

        public static Pesos operator +(Pesos p, Dolares d)
        {
            double suma = p.GetCantidad() + ((Pesos)d).GetCantidad();
            return new Pesos(suma);
        }

        public static Pesos operator +(Pesos p, Euros e)
        {
            double suma = p.GetCantidad() + ((Pesos)e).GetCantidad();
            return new Pesos(suma);
        }

        public static Pesos operator -(Pesos p, Dolares d)
        {
            double resta = p.GetCantidad() - ((Pesos)d).GetCantidad();
            return new Pesos(resta);
        }

        public static Pesos operator -(Pesos p, Euros e)
        {
            double resta = p.GetCantidad() - ((Pesos)e).GetCantidad();
            return new Pesos(resta);
        }
    }
}
