using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_29
{
    class Jugador
    {
        private long dni;
        private string nombre;
        private int partidosJugados;
        private float promedioGoles;
        private int totalGoles;

        private Jugador()
        {
            this.partidosJugados = 0;
            this.promedioGoles = 0;
            this.totalGoles = 0;
        }

        public Jugador(int dni, string nombre) : this()
        {
            this.dni = dni;
            this.nombre = nombre;
        }

        public Jugador(int dni, string nombre, int totalGoles, int partidosJugados) : this(dni, nombre)
        {
            this.totalGoles = totalGoles;
            this.partidosJugados = partidosJugados;
        }

        public float GetPromedioGoles()
        {
            if (this.partidosJugados > 0)
            {
                this.promedioGoles = this.totalGoles / this.partidosJugados;
                return this.promedioGoles;
            }
            this.promedioGoles = 0;
            return 0;
        }

        public string MostrarDatos()
        {
            return string.Format("Nombre: {0}, Dni: {1}, Partidos Jugados: {2}, Goles Totales: {3}, Promedio Goles: {4}", this.nombre, this.dni, this.partidosJugados, this.totalGoles, this.GetPromedioGoles());
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
    }
}
