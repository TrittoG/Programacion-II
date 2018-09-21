using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    enum Franja
    {
        Franja_1,
        Franja_2,
        Franja_3
    }

     class Provincial : Llamada
    {
        protected Franja franjaHoraria;

        public Provincial(Franja miFranja, Llamada llamada) : base(llamada.Duracion, llamada.NroDestino,llamada.NroOrigen)
        {
            this.franjaHoraria = miFranja;
        }

        public Provincial(string origen, Franja miFranja, float duracion, string destino) : this(miFranja, new Llamada(duracion,destino,origen))
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

            nuevoString.Append(" costo llamada: "+this.CostoLlamada.ToString());
            nuevoString.Append(" duracion: "+this.Duracion.ToString());
            nuevoString.Append(" destino: "+this.NroDestino.ToString());
            nuevoString.Append(" origen: "+this.NroOrigen.ToString());
            nuevoString.Append(" franja horaria: "+this.franjaHoraria.ToString());

          
            return nuevoString.ToString();
        }
    }
}
