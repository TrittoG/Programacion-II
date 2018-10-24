using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_52
{
    public class Boligrafo : IAcciones
    {
        private ConsoleColor colorTinta;
        private float tinta;

        public Boligrafo(int unidades, ConsoleColor color)
        {
            this.colorTinta = color;
            this.tinta = unidades;
        }

        public ConsoleColor Color
        {
            get
            {
                return this.colorTinta;
            }
            set
            {
                this.colorTinta = value;
            }
        }

        public float UnidadesDeEscritura
        {
            get
            {
                return this.tinta;
            }

            set
            {
                this.tinta = value;
            }
          
        }


        public EscrituraWrapper Escribir(string texto)
        {
            float contador = 0;
            foreach(char c in texto)
            {
                contador += 1;
            }

            this.tinta = this.tinta - ((float)0.3 * contador);

            return new EscrituraWrapper(texto, colorTinta);
        }

        public bool Recargar(int unidades)
        {
            this.tinta = this.tinta + unidades;
            return true;
        }


        public override string ToString()
        {
            StringBuilder st = new StringBuilder();

            st.AppendLine("Boligrafo de color " + this.Color + " y con un nivel de tinta de: " + this.UnidadesDeEscritura);

            return st.ToString();
        }

    }
}
