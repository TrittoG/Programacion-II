using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_29
{
    class Equipo
    {
        private short cantidadDeJugadores;
        private List<Jugador> jugadores;
        private string nombre;

        private Equipo()
        {
            jugadores = new List<Jugador>();
        }

        public Equipo(short cantidad, string nombre)
        {
            this.cantidadDeJugadores = cantidad;
            this.nombre = nombre;
        }

        public static bool operator +(Equipo e, Jugador j)
        {
            if(!(e.jugadores.Contains(j)) && e.jugadores.Count < e.cantidadDeJugadores)
            {
                e.jugadores.Add(j);
                return true;
            }

            return false;
        }





        //---------PARA EL TP-------------------------
        public string SetNumero
        {
            set
            {
                this.numero = validarNumero(value);
            }
        }
           


    }
}
