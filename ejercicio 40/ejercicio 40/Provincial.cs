using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_40
{
    public enum Franja
    {
        Franja_1,
        Franja_2,
        Franja_3
    }

     public class Provincial : Llamada
    {
        protected Franja franjaHoraria;

        public Provincial(Franja miFranja, Llamada llamada) : this(llamada.NroOrigen,miFranja,llamada.Duracion, llamada.NroDestino)
        {
            this.franjaHoraria = miFranja;
        }

        public Provincial(string origen, Franja miFranja, float duracion, string destino) : base(duracion,destino,origen)
        {
            this.franjaHoraria = miFranja;
        }


        private float CalcularCosto()
        {
            if(this.franjaHoraria == Franja.Franja_1)
            {
                return (float)0.99 * this.Duracion;
            }
            else if(this.franjaHoraria == Franja.Franja_2)
            {
                return (float)1.25 * this.Duracion;
            }
            else if(this.franjaHoraria == Franja.Franja_3)
            {
                return (float)0.66 * this.Duracion;
            }

            return 0;
        }

        public override float CostoLlamada
        {
            get
            {
                return CalcularCosto();
            }
        }


        public override bool Equals(object obj)
        {
            if (obj is Provincial)
            {
                return true;
            }
            else return false;
        }



        protected override string Mostrar()
        {
            StringBuilder nuevoString = new StringBuilder();

            nuevoString.Append(" costo llamada: "+this.CostoLlamada.ToString());
            nuevoString.Append(" duracion: "+this.Duracion.ToString());
            nuevoString.Append(" destino: "+this.NroDestino.ToString());
            nuevoString.Append(" origen: "+this.NroOrigen.ToString());
            nuevoString.Append(" franja horaria: "+this.franjaHoraria.ToString());

          
            return base.Mostrar() + nuevoString.ToString();
        }

        public override string ToString()
        {
            return Mostrar();
        }
    }
}
