using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio51
{
	public enum Franja
	{
        Franja_1,
		Franja_2,
		Franja_3
	}
	public class Provincial	:Llamada, IGuardar<Provincial>
	{
		protected Franja franjaHoraria;

		public Provincial(Llamada llamada, Franja franja)	:base(llamada.Duracion, llamada.NroDestino, llamada.NroOrigen)
		{
			this.franjaHoraria = franja;
		}

		public Provincial(string origen, Franja franja, float duracion, string destino)	:base(duracion, destino, origen)
		{
            this.franjaHoraria = franja;
        }

		public override float CostoLlamada
		{
			get
			{
				return CalcularCosto();
			}
		}

        string IGuardar<Provincial>.RutaDeArchivo
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        private float CalcularCosto()
		{
			float costo = 0;
			if (this.franjaHoraria == Franja.Franja_1)
			{
				costo = this.Duracion * (float)0.99;
			}
			else if (this.franjaHoraria == Franja.Franja_2)
			{
				costo = this.Duracion * (float)1.25;
			}
			else if (this.franjaHoraria == Franja.Franja_3)
			{
				costo = this.Duracion * (float)0.66;
			}
			return costo;
		}

		protected override string Mostrar()
		{
			StringBuilder datos = new StringBuilder();
			datos.AppendLine(base.Mostrar() + ", costo: " + this.CostoLlamada + ", franja: " + this.franjaHoraria.ToString());
			return datos.ToString();
		}

        public override bool Equals(object obj)
        {
            if(obj is Provincial)
            {
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            return Mostrar();
        }

        bool IGuardar<Provincial>.Guardar()
        {
            throw new NotImplementedException();
        }

        Provincial IGuardar<Provincial>.Leer()
        {
            throw new NotImplementedException();
        }
    }
}
