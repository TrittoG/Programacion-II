using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio32
{
    class Jugador
    {
        private long dni;
        private string nombre;
        private int partidosJugados;
        private int totalGoles;

        private Jugador()
        {
            this.partidosJugados = 0;
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

        public string MostrarDatos()
        {
            return string.Format("Nombre: {0}, Dni: {1}, Partidos Jugados: {2}, Goles Totales: {3}, Promedio Goles: {4}", this.nombre, this.dni, this.partidosJugados, this.totalGoles, this.PromedioGoles);
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

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = value;
            }
        }

        public long Dni
        {
            get
            {
                return this.dni;
            }
            set
            {
                this.dni = value;
            }
        }
    }
}
