using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso
{
    class Estante
    {
        private int ubicacionEstante;
        private Producto[] productos;


        private Estante(int capacidad)
        {
            this.productos = new Producto[capacidad];
        }


        public Estante(int capacidad, int ubicacion) : this(capacidad)
        {
            this.ubicacionEstante = ubicacion;
        }

        public Producto[] GetProductos()
        {
            return this.productos;
        }


        public static string MostrarEstante(Estante e)
        {
            string asd = "";
            
            for(int i=0;i<e.productos.Length;i++)
            {
                asd = asd + "\n" + Producto.MostrarProducto(e.productos[i]);
            }

            return asd;
        }


        public static bool operator !=(Estante e, Producto p)
        {
            return !(e == p);
        }


        public static Estante operator -(Estante e, Producto p)
        {
            int i;

            for(i=0;i<e.GetProductos().Length;i++)
            {
                if(e == p )
                {
                    e.GetProductos()[i] = null;
                    return e;
                }
            }

            return null;
        }

        public static bool operator +(Estante e, Producto p)
        {
            int i;

            for(i=0;i < e.GetProductos().Length;i++)
            {
                if((e != p) && (e.GetProductos()[i] is null))
                {
                    e.GetProductos()[i] = p;
                    return true;
                }
            }

            return false;
        }

        public static bool operator ==(Estante e, Producto p)
        {
            int i;

            for(i=0;i< e.GetProductos().Length;i++)
            {
                if (e.GetProductos()[i] == p)
                {
                    return true;
                }
                
            }

            return false;
        }








    }
}
