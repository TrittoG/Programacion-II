using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio30
{
    class Competencia
    {
        private short cantidadCompetidores;
        private short cantidadVueltas;
        private List<AutoF1> competidores;

        private Competencia()
        {
            this.competidores = new List<AutoF1>();
        }

        public Competencia(short cantidadCompetidores, short cantidadVueltas)   :this()
        {
            this.cantidadCompetidores = cantidadCompetidores;
            this.cantidadVueltas = cantidadVueltas;
        }

        public string MostrarDatos()
        {
            string cad = string.Format("Cantidad Competidores: {0}, Cantidad Vueltas: {1}", this.cantidadCompetidores, this.cantidadVueltas);
            for(int i = 0; i < this.competidores.Count; i++)
            {
                cad = cad + "\n" + this.competidores[i].MostrarDatos();
            }
            return cad;
        }

        public static bool operator ==(Competencia c, AutoF1 a)
        {
            for(int i = 0; i < c.competidores.Count; i++)
            {
                if (c.competidores[i] == a)
                    return true;
            }
            return false;
        }

        public static bool operator !=(Competencia c, AutoF1 a)
        {
            return !(c == a);
        }

        public static bool operator +(Competencia c, AutoF1 a)
        {
            if (c != a && c.competidores.Count < c.cantidadCompetidores)
            {
                c.competidores.Add(a);
                Random nmRnd = new Random();
                a.CantidadCombustible = (short)nmRnd.Next(15, 100);
                a.VueltasRestantes = c.cantidadVueltas;
                a.EnCompetencia = true;
                return true;
            }
            return false;
        }

        public static bool operator -(Competencia c, AutoF1 a)
        {
            if(c == a)
            {
                c.competidores.Remove(a);
                a.CantidadCombustible = 0;
                a.VueltasRestantes = 0;
                a.EnCompetencia = false;
                return true;
            }
            return false;
        }
    }
}
