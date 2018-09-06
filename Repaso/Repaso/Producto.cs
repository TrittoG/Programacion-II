using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso
{
    class Producto
    {
        private string codigoDeBarra;
        private string marca;
        private float precio;




        public static explicit operator string(Producto p)
        {
            return p.codigoDeBarra;
        }




        public string GetMarca()
        {
            return this.marca;
        }



        public float GetPrecio()
        {
            return this.precio;
        }



        public static string MostrarProducto(Producto p)
        {
            if(!(p is null))
                return " marca " + p.GetMarca() + " precio " + p.GetPrecio() + " codigo " + p.codigoDeBarra;
            return " nulo!"; 
        }





        public static bool operator !=(Producto p, string marca)
        {
            /*if (p.GetMarca() != marca)
                return true;
            return false;*/
            return !(p == marca);
        }




        public static bool operator !=(Producto p1, Producto p2)
        {
            return !(p1==p2);
        }





        public static bool operator ==(Producto p, string marca)
        {
            if (p.GetMarca() == marca)
                return true;
            return false;
        }




        public static bool operator ==(Producto p1, Producto p2)
        {
            if (!(p1 is null) && !(p2 is null))
            {
                if (p1.GetMarca() == p2.GetMarca())
                {
                    if ((string)p1 == (string)p2)
                    {
                        return true;
                    }
                }
            }
            return false;
        }




        public Producto(string marca, string codigo, float precio)
        {
            this.marca = marca;
            this.codigoDeBarra = codigo;
            this.precio = precio;
        }





    }
}
