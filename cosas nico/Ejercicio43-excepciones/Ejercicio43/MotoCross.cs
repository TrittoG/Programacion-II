using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio43
{
	class MotoCross	:VehiculoDeCarrera
	{
		private short cilindrada;

		public MotoCross(short numero, string escuderia)	:base(numero, escuderia)
		{
			this.CantidadCombustible = 0;
			this.EnCompetencia = false;
			this.VueltasRestantes = 0;
		}

		public MotoCross(short numero, string escuderia, short cilindrada)	:this(numero, escuderia)
		{
			this.Cilindrada = cilindrada;
		}

		public short Cilindrada
		{
			get
			{
				return cilindrada;
			}
			set
			{
				cilindrada = value;
			}
		}

		public string MostrarDatos()
		{
			return this.MostrarDatosVC() + "\nCilindrada: " + this.cilindrada;
		}

		public static bool operator ==(MotoCross m1, MotoCross m2)
		{
			if (m1.Numero == m2.Numero && m1.Escuderia == m2.Escuderia)
				return true;
			return false;
		}

		public static bool operator !=(MotoCross m1, MotoCross m2)
		{
			return !(m1 == m2);
		}
	}
}
