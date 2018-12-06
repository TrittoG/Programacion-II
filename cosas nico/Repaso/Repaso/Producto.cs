using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso
{
    class Producto
    {
        private string CodigoDeBarra;
        private string Marca;
        private float Precio;

        public string GetMarca()
        {
            return this.Marca;
        }

        public float GetPrecio()
        {
            return this.Precio;
        }

        public static string MostrarProducto(Producto p)
        {
            return "Marca " + p.GetMarca() + ", Precio " + p.GetPrecio() + "Codigo de barras " + p.CodigoDeBarra;
        }

        public Producto(string Marca, string Codigo, float Precio)
        {
            this.Precio = Precio;
            this.CodigoDeBarra = Codigo;
            this.Marca = Marca;
        }

        public static explicit operator string(Producto p)
        {
            return p.CodigoDeBarra;
        }

        public static bool operator !=(Producto p, string Marca)
        {
            if (p.GetMarca() != Marca)
                return true;
            return false;
        }

        public static bool operator !=(Producto p1, Producto p2)
        {
            if (p1.GetMarca() != p2.GetMarca())
                return true;
            return false;
        }

        public static bool operator ==(Producto p, string Marca)
        {
            if (p.GetMarca() == Marca)
                return true;
            return false;
        }

        public static bool operator ==(Producto p1, Producto p2)
        {
            if (p1 is null || p2 is null)
                return false;
            else
                if (p1.Marca == p2.Marca && p1.CodigoDeBarra == p2.CodigoDeBarra)
                    return true;
                else
                    return false;
        }
    }
}
