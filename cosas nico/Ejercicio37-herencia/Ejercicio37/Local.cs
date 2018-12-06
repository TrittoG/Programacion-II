using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio37
{
	class Local	:Llamada
	{
		protected float costo;

		public float CostoLlamada
		{
			get
			{
				return costo;
			}
		}

		public string Mostrar()
		{
			return this.MostrarLlamada() + ", Costo: " + this.CostoLlamada; 
		}

		private float CalcularCosto()
		{
			return this.CostoLlamada * this.Duracion;
		}

		public Local(Llamada llamada, float costo)	:base(llamada.Duracion, llamada.NroDestino, llamada.NroOrigen)
		{
			this.costo = costo;
		}

		public Local(string origen, float duracion, string destino, float costo)	:this(new Llamada(duracion, destino, origen), costo)
		{

		}

	}
}
