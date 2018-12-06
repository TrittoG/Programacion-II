using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio43
{
	public class VehiculoDeCarrera
	{
		private short cantidadCombustible;
		private bool enCompetencia;
		private string escuderia;
		private short numero;
		private short vueltasRestantes;

		public VehiculoDeCarrera(short numero, string escuderia)
		{
			this.Numero = numero;
			this.Escuderia = escuderia;
		}
		public short CantidadCombustible
		{
			get
			{
				return cantidadCombustible;
			}

			set
			{
				if (value >= 0 && value <= 100)
					this.cantidadCombustible = value;
				else if (value < 0)
					this.cantidadCombustible = 0;
				else if (value > 100)
					this.cantidadCombustible = 100;
			}
		}

		public short VueltasRestantes
		{
			get
			{
				return vueltasRestantes;
			}

			set
			{
				this.vueltasRestantes = value;
			}
		}

		public bool EnCompetencia
		{
			get
			{
				return enCompetencia;
			}

			set
			{
				this.enCompetencia = value;
			}
		}

		public string Escuderia
		{
			get
			{
				return escuderia;
			}
			set
			{
				escuderia = value;
			}
		}

		public short Numero
		{
			get
			{
				return numero;
			}
			set
			{
				numero = value;
			}
		}

		public string MostrarDatosVC()
		{
			return "Numero: " + this.Numero + "\nEscuderia: " + this.Escuderia + "\nCantidad de combustible: " + this.CantidadCombustible + "\nVueltas restantes: " + this.VueltasRestantes + "\nEn competencia: " + this.EnCompetencia;
		}


	}
}
