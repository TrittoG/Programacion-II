using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio36
{
    class AutoF1	:VehiculoDeCarrera
    {
		private short caballosDeFuerza;

        public AutoF1(short numero, string escuderia)	:base(numero, escuderia)
        {
			this.EnCompetencia = false;
			this.CantidadCombustible = 0;
			this.VueltasRestantes = 0;
        }

		public AutoF1(short numero, string escuderia, short caballosDeFuerza)	:this(numero, escuderia)
		{
			this.caballosDeFuerza = caballosDeFuerza;
		}
        public string MostrarDatos()
        {
            return this.MostrarDatosVC() + "\nCaballos de fuerza: " + this.caballosDeFuerza;
        }

        public static bool operator ==(AutoF1 a, AutoF1 b)
        {
            if (a.Numero == b.Numero && a.Escuderia == b.Escuderia)
                return true;
            return false;
        }

        public static bool operator !=(AutoF1 a, AutoF1 b)
        {
            return !(a == b);
        }

       
     }
}
