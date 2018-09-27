using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_40
{
    public class Local : Llamada
    {
        protected float costo;


        public Local(Llamada llamada, float costo) : this(llamada.NroOrigen,llamada.Duracion, llamada.NroDestino,costo)
        {
            
        }

        public Local(string origen, float duracion, string destino, float costo) : base(duracion,destino,origen) 
        {
            this.costo = costo;
        }

        private float CalcularCosto()
        {
            return this.costo * this.duracion;
        }


        public override float CostoLlamada
        {
            get
            {
                return CalcularCosto();
            }
        }

        protected override string Mostrar()
        {
            StringBuilder nuevoString = new StringBuilder();


            nuevoString.AppendLine("costo de la llamada " + this.CostoLlamada.ToString());
            nuevoString.AppendLine(" duracion de la llamada " + this.Duracion.ToString());
            nuevoString.AppendLine(" numero de destino " + this.NroDestino.ToString());
            nuevoString.AppendLine(" numero de origen " + this.NroOrigen.ToString());


            //return nuevoString.ToString();
            
            return base.Mostrar() + nuevoString.ToString();

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
