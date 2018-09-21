using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Local : Llamada
    {
        protected float costo;


        public Local(Llamada llamada, float costo) : base(llamada.Duracion, llamada.NroDestino, llamada.NroOrigen)
        {
            this.costo = costo;
        }

        public Local(string origen, float duracion, string destino, float costo) : this(new Llamada(duracion,destino,origen), costo) 
        {

        }

        private float CalcularCosto()
        {
            return this.costo * this.duracion;
        }


        public float CostoLlamada
        {
            get
            {
                return CalcularCosto();
            }
        }


        public string Mostrar()
        {
            StringBuilder nuevoString = new StringBuilder();
           

            nuevoString.Append("costo de la llamada "+this.CostoLlamada.ToString());
            nuevoString.Append(" duracion de la llamada "+this.Duracion.ToString());
            nuevoString.Append(" numero de destino " +this.NroDestino.ToString());
            nuevoString.Append(" numero de origen "+this.NroOrigen.ToString());

            
            return nuevoString.ToString();
        }
    }
}
