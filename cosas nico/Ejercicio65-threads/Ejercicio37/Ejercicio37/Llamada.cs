using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio37
{
	enum TipoLlamada
	{
		Local,
		Provincial,
		Todas
	}

	public class Llamada
	{
		protected float duracion;
		protected string nroDestino;
		protected string nroOrigen;

		public float Duracion
		{
			get
			{
				return duracion;
			}
		}

		public string NroDestino
		{
			get
			{
				return nroDestino;
			}
		}

		public string NroOrigen
		{
			get
			{
				return nroOrigen;
			}
		}

		public Llamada(float duracion, string nroDestino, string nroOrigin)
		{
			this.duracion = duracion;
			this.nroDestino = nroDestino;
			this.nroOrigen = nroOrigin;
		}

		public string MostrarLlamada()
		{
			StringBuilder datos = new StringBuilder();
			datos.AppendLine("Duracion: " + this.Duracion.ToString() + ", Numero destino: " + this.NroDestino + ", Numero origen: " + this.NroOrigen);
			return datos.ToString();
		}

		public static int OrdenarPorDuracion(Llamada l1, Llamada l2)
		{
			if (l1.Duracion > l2.Duracion)
				return 1;
			else
			{
				if (l1.Duracion < l2.Duracion)
					return -1;
			}
			return 0;
		}

	}
}
