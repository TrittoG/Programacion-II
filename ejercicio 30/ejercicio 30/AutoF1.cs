using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_30
{
    class AutoF1
    {
        private short cantidadDeCombustible;
        private bool enCompetencia;
        private string escuderia;
        private short numero;
        private short vueltasRestantes;

        public AutoF1(short numero, string escuderia)
        {
            EnCompetencia = false;
            CantidadDeCombustible = 0;
            VueltasRestantes = 0;

            this.numero = numero;
            this.escuderia = escuderia;
        }

        public static bool operator ==(AutoF1 a1, AutoF1 a2)
        {
            if(!(a1 is null || a2 is null))
            {
                if((a1.escuderia == a2.escuderia) && (a1.numero == a2.numero))
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator !=(AutoF1 a1, AutoF1 a2)
        {
            return !(a1 == a2);
        }

        //propiedades si estan a la derecha del igual activa el get, si esta a la izquierda el set
        public short CantidadDeCombustible
        {
            set
            {
                this.cantidadDeCombustible = value;
            }

            get
            {
                return this.cantidadDeCombustible;
            }
        }

     



        public bool EnCompetencia
        {
            set
            {
                this.enCompetencia = value;
            }

            get
            {
                return this.enCompetencia;
            }
        }

        public short VueltasRestantes
        {
            set
            {
                this.vueltasRestantes = value;
            }

            get
            {
                return this.vueltasRestantes;
            }
        }

        public string MostrarDatos()
        {
            return VueltasRestantes + " " + this.numero + " " + this.escuderia + " " + EnCompetencia + " " + CantidadDeCombustible;
        }
    }
}
