using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio30
{
    class AutoF1
    {
        private short cantidadCombustible;
        private bool enCompetencia;
        private string escuderia;
        private short numero;
        private short vueltasRestantes;

        public AutoF1(short numero, string escuderia)
        {
            this.enCompetencia = false;
            this.vueltasRestantes = 0;
            this.cantidadCombustible = 0;
            this.numero = numero;
            this.escuderia = escuderia;
        }

        public string MostrarDatos()
        {
            return string.Format("Numero: {0}, Escuderia: {1}, En competencia: {2}, Cantidad de combustible: {3}, Vueltas restantes: {4}", this.numero, this.escuderia, this.enCompetencia, this.cantidadCombustible, this.vueltasRestantes);
        }

        public static bool operator ==(AutoF1 a, AutoF1 b)
        {
            if (a.numero == b.numero && a.escuderia == b.escuderia)
                return true;
            return false;
        }

        public static bool operator !=(AutoF1 a, AutoF1 b)
        {
            return !(a == b);
        }

        public short CantidadCombustible
        {
            get
            {
                return cantidadCombustible;
            }

            set
            {
                if (value >= 0 && value <= 100)
                    this.cantidadCombustible = value;
                else if (value < 0)
                    this.cantidadCombustible = 0;
                else if (value > 100)
                    this.cantidadCombustible = 100;
            }
        }

        public short VueltasRestantes
        {
            get
            {
                return vueltasRestantes;
            }

            set
            {
                this.vueltasRestantes = value;
            }
        }

        public bool EnCompetencia
        {
            get
            {
                return enCompetencia;
            }

            set
            {
                this.enCompetencia = value;
            }
        }
     }
}
