using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_40
{
    //enumerado
    enum TipoLlamada
    {
        Local,
        Provincial,
        Todas
    }



    public abstract class Llamada
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

        public abstract float CostoLlamada
        {
            get;
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


        protected virtual string Mostrar()
        {
          
            StringBuilder miString = new StringBuilder();
            miString.AppendLine("--------------------------");
            miString.AppendLine("Duracion: " + Duracion);
            miString.AppendLine("Numero Origen" + NroOrigen);
            miString.AppendLine("Numero Destino" + NroDestino);

            
            return miString.ToString();
        }


        public Llamada(float duracion, string nroDestino, string nroOrigen)
        {
            this.duracion = duracion;
            this.nroDestino = nroDestino;
            this.nroOrigen = nroOrigen;
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
