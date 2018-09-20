using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_29
{
    class Jugador
    {
        private long dni;
        private string nombre;
        private int partidosJugados;
        private float promedioGoles;
        private int totalGoles;

        
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
                this.promedioGoles = this.partidosJugados / this.totalGoles;
                return this.promedioGoles;
            }
        }

        public string Nombre
        {
            set
            {
                this.nombre = value;
            }
            get
            {
                return this.nombre;
            }
        }

        public long Dni
        {
            set
            {
                this.dni = value;
            }
            get
            {
                return this.dni;
            }
        }


        private Jugador()
        {
            this.partidosJugados = 0;
            this.promedioGoles = 0;
            this.totalGoles = 0;
        }

        public Jugador(int dni, string nombre)
        {
            this.dni = dni;
            this.nombre = nombre;
        }

        public Jugador(int dni, string nombre, int totalGoles, int totalPartidos)
        {
            this.dni = dni;
            this.nombre = nombre;
            this.totalGoles = totalGoles;
            this.partidosJugados = totalPartidos;
            this.promedioGoles = PromedioGoles;
        }

        public string mostrarDatos()
        {
            return string.Format("{0} {1} {2} {3} {4}", this.dni, this.nombre, this.totalGoles, this.partidosJugados, this.promedioGoles);
        }

        public static bool operator ==(Jugador j1, Jugador j2)
        {
            if(j1.dni == j2.dni)
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(Jugador j1, Jugador j2)
        {
            return !(j1 == j2);
        }
    }
}
