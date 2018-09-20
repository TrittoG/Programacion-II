using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_30
{
    class Competencia
    {
        private short cantidadCompetidores;
        private short cantidadVueltas;
        private List<AutoF1> competidores;

        private Competencia()
        {
            List<AutoF1>competidores = new List<AutoF1>();
        }

        public Competencia(short cantidadCompetidores, short cantidadVueltas)
        {
            this.cantidadCompetidores = cantidadCompetidores;
            this.cantidadVueltas = cantidadVueltas;
        }

        public static bool operator ==(Competencia c, AutoF1 a)
        {
            foreach(AutoF1 aut in c.competidores)
            {
                if(aut == a)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator !=(Competencia c, AutoF1 a)
        {
            return !(c == a);
        }

        public static bool operator +(Competencia c, AutoF1 a)
        {
            if(!(c == a) && c.cantidadCompetidores< c.competidores.Capacity)
            {
                Random random = new Random();
                c.competidores.Add(a);
                a.EnCompetencia = true;
                a.VueltasRestantes = c.cantidadVueltas;
                a.CantidadDeCombustible = (short)random.Next(15, 100);
                return true;
            }
            return false;
        }
    }
}
