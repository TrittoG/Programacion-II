using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    class Rectangulo
    {
        private float area;
        private float perimetro;
        private Punto vertice1;
        private Punto vertice2;
        private Punto vertice3;
        private Punto vertice4;

        //metodos

        public float Area()
        {
            return this.area;
        }

        public float Perimetro()
        {
            return this.perimetro;
        }

        public Rectangulo(Punto vertice1, Punto vertice3)
        {

        }


    }
}
