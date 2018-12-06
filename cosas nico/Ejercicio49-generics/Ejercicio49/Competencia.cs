using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio49
{
	public enum TipoCompetencia
	{
		F1,
		MotoCross
	}
    public class Competencia<T> where T: VehiculoDeCarrera 
    {
        private short cantidadCompetidores;
        private short cantidadVueltas;
        private List<T> competidores;
		private TipoCompetencia tipo;

        private Competencia()
        {
            this.competidores = new List<T>();
        }

        public Competencia(short cantidadCompetidores, short cantidadVueltas, TipoCompetencia tipocomp)   :this()
        {
            this.cantidadCompetidores = cantidadCompetidores;
            this.cantidadVueltas = cantidadVueltas;
            this.tipo = tipocomp;
        }

        public List<T> ListaCompetidores
        {
            get
            {
                return competidores;
            }
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

        public static bool operator ==(Competencia<T> c, T a)
        {
            //for(int i = 0; i < c.competidores.Count; i++)
            //{
            //    if (c.competidores[i].Escuderia == a.Escuderia && c.competidores[i].Numero == a.Numero)
            //        return true;
            //}
            //return false;
            bool rta;
            try
            {
                rta = (c != a);
            } catch (CompetenciaNoDisponibleException)
            {
                rta = true;
            }
            if (!rta)
                throw new CompetenciaNoDisponibleException("El vehículo no corresponde a la competencia", "Competencia", "==");
            else
                return rta;
        }

        public static bool operator !=(Competencia<T> c, T a)
        {
            for (int i = 0; i < c.competidores.Count; i++)
            {
                if (c.competidores[i].Escuderia == a.Escuderia && c.competidores[i].Numero == a.Numero)
                    throw new CompetenciaNoDisponibleException("El vehículo no corresponde a la competencia", "Competencia", "!=");
            }
            return true;
        }

        public static bool operator +(Competencia<T> c, T a)
        {
            try
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
            catch(CompetenciaNoDisponibleException ex)
            {
                throw new CompetenciaNoDisponibleException("Competencia incorrecta", "Competencia", "+", ex);
            }
        }

        public static bool operator -(Competencia<T> c, T a)
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
