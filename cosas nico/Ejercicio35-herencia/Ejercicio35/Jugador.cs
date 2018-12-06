using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio35
{
    class Jugador :Persona
    {
        private int partidosJugados;
        private int totalGoles;

        public Jugador(int dni, string nombre, int totalGoles, int partidosJugados) :base(dni, nombre)
        {
            this.totalGoles = totalGoles;
            this.partidosJugados = partidosJugados;
        }

        public string MostrarDatosJugador()
        {
            return string.Format("{0}, Partidos Jugados: {1}, Goles Totales: {2}, Promedio Goles: {3}", this.MostrarDatos(), this.partidosJugados, this.totalGoles, this.PromedioGoles);
        }

        public static bool operator !=(Jugador a, Jugador b)
        {
            if (a.dni == b.dni)
                return false;
            return true;
        }

        public static bool operator ==(Jugador a, Jugador b)
        {
            return !(a != b);
        }

        public int PartidosJugados
        {
            get
            {
                return this.partidosJugados;
            }
        }

        public int TotalGoles
        {
            get
            {
                return this.totalGoles;
            }
        }

        public float PromedioGoles
        {
            get
            {
                if (this.partidosJugados > 0)
                {
                    return this.totalGoles / this.partidosJugados;
                }
                return 0;
            }
        }

    }
}
