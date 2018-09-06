using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio19
{
    class Sumador
    {
        private int cantidadSumas;



        //metodos

        //conversion explicita del int , (int)objeto va a retornar la cantidad de sumas del objeto
        public static explicit operator int(Sumador s)
        {
            return s.cantidadSumas;
        }


        public static bool operator |(Sumador s1, Sumador s2)
        {
            if(s1.cantidadSumas == s2.cantidadSumas)
                return true;
            return false;
        }
        
        public static long operator +(Sumador s1, Sumador s2)
        {           
            return s1.cantidadSumas + s2.cantidadSumas;
        }




        public Sumador()
        {
            this.cantidadSumas = 0;
        }

        public Sumador(int cantidadSumas)
        {
            this.cantidadSumas = cantidadSumas;
        }

        public long Sumar(long a, long b)
        {
            this.cantidadSumas = this.cantidadSumas + 1;

            return a + b;

        }

        public string Sumar(string a, string b)
        {
            this.cantidadSumas = this.cantidadSumas + 1;

            return a + b;
        }


    }
}
