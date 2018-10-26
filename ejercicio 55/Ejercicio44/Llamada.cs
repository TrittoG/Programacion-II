using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio44
{
	enum TipoLlamada
	{
		Local,
		Provincial,
		Todas
	}

	public abstract class Llamada
	{
		protected float duracion;
		protected string nroDestino;
		protected string nroOrigen;

        public abstract float CostoLlamada
        {
            get;
        }

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

		protected virtual string Mostrar()
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

        public static bool operator ==(Llamada l1, Llamada l2)
        {
            if(l1.Equals(l2) && l1.NroDestino == l2.NroDestino && l1.NroOrigen == l2.NroOrigen)
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(Llamada l1, Llamada l2)
        {
            return !(l1 == l2);
        }
	}
}
