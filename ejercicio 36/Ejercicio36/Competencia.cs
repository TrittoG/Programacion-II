using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio36
{
	enum TipoCompetencia
	{
		F1,
		MotoCross
	}
    class Competencia
    {
        private short cantidadCompetidores;
        private short cantidadVueltas;
        private List<VehiculoDeCarrera> competidores;
		private TipoCompetencia tipo;

        private Competencia()
        {
            this.competidores = new List<VehiculoDeCarrera>();
        }

        public Competencia(short cantidadCompetidores, short cantidadVueltas, TipoCompetencia tipo)   :this()
        {
            this.cantidadCompetidores = cantidadCompetidores;
            this.cantidadVueltas = cantidadVueltas;
        }

        public string MostrarDatos()
        {
            string cad = string.Format("Cantidad Competidores: {0}\nCantidad Vueltas: {1}", this.cantidadCompetidores, this.cantidadVueltas);
            for(int i = 0; i < this.competidores.Count; i++)
            {
                cad = cad + "\n" + this.competidores[i].MostrarDatosVC();
            }
            return cad;
        }

        public static bool operator ==(Competencia c, VehiculoDeCarrera a)
        {
            for(int i = 0; i < c.competidores.Count; i++)
            {
                if (c.competidores[i].Escuderia == a.Escuderia && c.competidores[i].Numero == a.Numero)
                    return true;
            }
            return false;
        }

        public static bool operator !=(Competencia c, VehiculoDeCarrera a)
        {
            return !(c == a);
        }

        public static bool operator +(Competencia c, VehiculoDeCarrera a)
        {
            if (c != a && c.competidores.Count < c.cantidadCompetidores && ((a is MotoCross && c.tipo == TipoCompetencia.MotoCross) || (a is AutoF1 && c.tipo == TipoCompetencia.F1)))
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

        public static bool operator -(Competencia c, VehiculoDeCarrera a)
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
