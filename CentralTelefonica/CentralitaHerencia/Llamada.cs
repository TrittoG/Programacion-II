using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    //enumerado
    enum TipoLlamada
    {
        Local,
        Provincial,
        Todas
    }

    public class Llamada
    {
        //atributos
        protected float duracion;
        protected string nroDestino;
        protected string nroOrigen;


        //propiedades
        public float Duracion
        {
            get
            {
                return this.duracion;
            }
        }

        public string NroDestino
        {
            get
            {
                return this.nroDestino;
            }
        }

        public string NroOrigen
        {
            get
            {
                return this.nroOrigen;
            }
        }


        public static int OrdenarPorDuracion(Llamada llamada1, Llamada llamada2)
        {
            if(!(llamada1 is null ||  llamada2 is null))
            {
                if(llamada1.duracion == llamada2.duracion)
                {
                    return 0;
                }
                else if(llamada1.duracion < llamada2.duracion)
                {
                    return -1;
                }
                else
                {
                    return 1;
                }

            }
            return 0;
        }


        public string Mostrar()
        {
          
            StringBuilder miString = new StringBuilder();
            miString.Append(Duracion);
            miString.Append(NroOrigen);
            miString.Append(NroDestino);

            
            return miString.ToString();
        }


        public Llamada(float duracion, string nroDestino, string nroOrigen)
        {
            this.duracion = duracion;
            this.nroDestino = nroDestino;
            this.nroOrigen = nroOrigen;
        }

    }
}
