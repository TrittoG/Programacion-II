using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio35
{
    class Equipo
    {
        private short cantidadDeJugadores;
        private string nombre;
        private List<Jugador> jugadores;
        private DirectorTecnico dt;

        private Equipo()
        {
            this.jugadores = new List<Jugador>();
        }

        public Equipo(string nombre, short cantidadDeJugadores, DirectorTecnico dt) :this()
        {
            this.nombre = nombre;
            this.cantidadDeJugadores = cantidadDeJugadores;
            this.dt = dt;
        }

        public static bool operator +(Equipo e, Jugador j)
        {
            if (!(e.jugadores.Contains(j)))
            {
                if (e.jugadores.Capacity < e.cantidadDeJugadores)
                {
                    e.jugadores.Add(j);
                    return true;
                }
            }
            return false;
        }
    }
}
