using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libreria
{
    public class Contabilidad<T,U> where T : Documento where U : Documento, new()
    {
        private List<T> egresos;
        private List<U> ingresos;

        public Contabilidad()
        {
            egresos = new List<T>();
            ingresos = new List<U>();
        }


        public static Contabilidad<T,U> operator +(Contabilidad<T,U> c, T egreso)
        {
            foreach(T egre in c.egresos)
            {
                if(egre == egreso)
                {
                    return c;
                }
            }

            c.egresos.Add(egreso);
            return c;
        }
        public static Contabilidad<T, U> operator +(Contabilidad<T, U> c, U ingreso)
        {
            foreach (U ingre in c.ingresos)
            {
                if (ingre == ingreso)
                {
                    return c;
                }
            }

            c.ingresos.Add(ingreso);
            return c;
        }
    }
}
