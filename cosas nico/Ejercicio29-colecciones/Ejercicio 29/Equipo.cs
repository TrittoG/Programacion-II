using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_29
{
    class Equipo
    {
        private short cantidadDeJugadores;
        private string nombre;
        private List<Jugador> jugadores;

        private Equipo()
        {
            this.jugadores = new List<Jugador>();
        }

        public Equipo(string nombre, short cantidadDeJugadores) :this()
        {
            this.nombre = nombre;
            this.cantidadDeJugadores = cantidadDeJugadores;
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
