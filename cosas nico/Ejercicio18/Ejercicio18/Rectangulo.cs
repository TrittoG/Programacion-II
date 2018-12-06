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
        public float Area()
        {
            int x1 = this.vertice1.GetX();
            int y1 = this.vertice1.GetY();
            int y2 = this.vertice2.GetY();
            int x4 = this.vertice4.GetX();
            int basee = Math.Abs(x4) - Math.Abs(x1);
            int altura = Math.Abs(y2) - Math.Abs(y1);
            return basee * altura;
        }
        public float Perimetro()
        {
            int x1 = this.vertice1.GetX();
            int y1 = this.vertice1.GetY();
            int y2 = this.vertice2.GetY();
            int x4 = this.vertice4.GetX();
            int basee = Math.Abs(x4) - Math.Abs(x1);
            int altura = Math.Abs(y2) - Math.Abs(y1);
            return ((basee + altura) * 2);
        }
        public Rectangulo(Punto vertice1, Punto vertice3)
        {
            this.vertice1 = vertice1;
            this.vertice3 = vertice3;
            int xVer1 = vertice1.GetX();
            int yVer1 = vertice1.GetY();
            int xVer3 = vertice3.GetX();
            int yVer3 = vertice3.GetY();
            Punto vert2 = new Punto(xVer1, yVer3);
            this.vertice2 = vert2;
            Punto vert4 = new Punto(xVer3, yVer1);
            this.vertice4 = vert4;
        }
        public static string Mostrar(Rectangulo rec)
        {
            string datos;
            int x1 = rec.vertice1.GetX(), x2 = rec.vertice2.GetX(), x3 = rec.vertice3.GetX(), x4 = rec.vertice4.GetX();
            int y1 = rec.vertice1.GetY(), y2 = rec.vertice2.GetY(), y3 = rec.vertice3.GetY(), y4 = rec.vertice4.GetY();
            float area = rec.Area();
            float perimetro = rec.Perimetro();
            datos = "Vertice 1 = (" + x1 + "," + y1 + "), Vertice 2 = (" + x2 + "," + y2 + "), Vertice 3 = (" + x3 + "," + y3 + "), Vertice 4 = (" + x4 + "," + y4 + "), Area = " + area + ", Perimetro = " + perimetro;
            return datos;
        }
    }
}
