using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio40
{
	public class Local	:Llamada
	{
		protected float costo;

		public override float CostoLlamada
		{
			get
			{
				return costo;
			}
		}

		protected override string Mostrar()
		{
			return base.Mostrar() + ", Costo: " + this.CostoLlamada; 
		}

		private float CalcularCosto()
		{
			return this.CostoLlamada * this.Duracion;
		}

		public Local(Llamada llamada, float costo)	:this(llamada.NroOrigen, llamada.Duracion, llamada.NroDestino, costo)
		{}

		public Local(string origen, float duracion, string destino, float costo)	:base(duracion, destino, origen)
		{
            this.costo = costo;
		}

        public override bool Equals(object obj)
        {
            if(obj is Local)
            {
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            return Mostrar();
        }

    }
}
