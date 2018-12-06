using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso
{
    class Estante
    {
        private int UbicacionEstante;
        private Producto[] Productos;

        private Estante(int capacidad)
        {
            this.Productos = new Producto[capacidad];
        }

        public Estante(int capacidad, int ubicacion) : this(capacidad)
        {
            this.UbicacionEstante = ubicacion;
        }

        public Producto[] GetProducto()
        {
            return this.Productos;
        }

        public static string MostrarEstante(Estante e)
        {
            StringBuilder sb = new StringBuilder();
            Producto[] aux = e.GetProducto();
            /*for(int i = 0; i < aux.Length; i++)
            {
                sb.AppendLine(Producto.MostrarProducto(aux[i]));
            }*/
            foreach(Producto producto in aux)
            {
                sb.AppendLine(Producto.MostrarProducto(producto));
            }
            return sb.ToString();
        }

        public static bool operator !=(Estante e, Producto p)
        {
            Producto[] aux = e.GetProducto();

            foreach(Producto producto in aux)
            {
                if (producto == p)
                    return false;
            }
            return true;
        }

        public static bool operator ==(Estante e, Producto p)
        {
            foreach (Producto producto in e.GetProducto())
            {
                if (producto == p)
                    return true;
            }
            return false;
        }

        public static bool operator +(Estante e, Producto p)
        {
            Producto[] aux = e.GetProducto();
            for(int i = 0; i < aux.Length; i++)
            {
                if (aux[i] is null && e != p)
                {
                    e.Productos[i] = p;
                    return true;
                }
            }
            return false;
        }

        public static Estante operator -(Estante e, Producto p)
        {
            Producto[] aux = e.GetProducto();
            Estante s = e;
            for(int i = 0; i < aux.Length; i++)
            {
                if(aux[i] == p)
                {
                    s.Productos[i] = null;
                    return s;
                }
            }
            return e;
        }
    }
}
