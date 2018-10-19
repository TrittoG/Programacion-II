using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Biblioteca
{
    public class Torneo<T> where T : Equipo
    {
        private string nombre;
        private List<T> equipos;

        public Torneo( string nombre)
        {
            this.equipos = new List<T>();
            
            this.nombre = nombre;

        }

        public static bool operator ==(Torneo<T> torneo, T equipo)
        {
            
                foreach(T equi in torneo.equipos)
                {
                    if(equi == equipo)
                    {
                        return true;
                    }
                }
                return false;
            
            
        }

        public static bool operator !=(Torneo<T> torneo, T equipo)
        {
            return !(torneo == equipo);
        }

        public static Torneo<T> operator +(Torneo<T> torneo, T equipo)
        {
            if(torneo != equipo)
            {
                
                torneo.equipos.Add(equipo);
            }

            return torneo;
        }
        
        public string Mostrar()
        {
            StringBuilder st = new StringBuilder();

            st.AppendLine("NOMBRE DEL TORNEO: " + this.nombre);
            st.AppendLine("PARTICIPANTES: ");

            foreach(T t in this.equipos)
            {
                st.AppendLine("EQUIPO: " + t.Ficha());
            }

            return st.ToString();
        }


        private string CalcularPartido(T t, T s)
        {
            Random rnd = new Random();
            Random rnd2 = new Random();

            int i, j;
            i = rnd.Next(0, 10);
            Thread.Sleep(250);
            j = rnd2.Next(0, 10);

            StringBuilder st = new StringBuilder();

            st.AppendLine(t.Nombre + " " + i + " - " + j + " " + s.Nombre);
            return st.ToString();

        }

        public string JugarPartido
        {
            get
            {
                Random rnd = new Random();
                Random rnd2 = new Random();
                int rando, rando2;
                rando = rnd.Next(0, (this.equipos.Count));
                Thread.Sleep(147);
               
                rando2 = rnd2.Next(0, this.equipos.Count);
                while(rando == rando2)
                {
                    rando2 = rnd2.Next(0, this.equipos.Count);

                }

                return this.CalcularPartido(this.equipos[rando], this.equipos[rando2]);
            }
        }

    }
}
