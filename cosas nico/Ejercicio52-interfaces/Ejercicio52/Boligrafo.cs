using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio52
{
    public class Boligrafo : IAcciones
    {

        private ConsoleColor colorTinta;
        private float tinta;

        public Boligrafo(int unidades, ConsoleColor color)
        {
            ((IAcciones)this).UnidadesDeEscritura = unidades;
            ((IAcciones)this).Color = color;
        }

        public ConsoleColor Color
        {
            get
            {
                return colorTinta;
            }
            set
            {
                colorTinta = value;
            }
        }

        public float UnidadesDeEscritura
        {
            get
            {
                return tinta;
            }
            set
            {
                if (tinta != 0)
                    tinta = tinta + value;
                else
                    tinta = value;
            }
        }

        public EscrituraWrapper Escribir(string texto)
        {
            StringBuilder escrito = new StringBuilder();
            int tamaño = texto.Length;
            int i = 0;
            while (UnidadesDeEscritura >= 0.3 && tamaño > i)
            {
                escrito.AppendFormat("{0}", texto[i]);
                i++;
                UnidadesDeEscritura =  (float)(-0.3);
            }
            return new EscrituraWrapper(escrito.ToString(), ((IAcciones)this).Color);
        }

        public bool Recargar(int unidades)
        {
            UnidadesDeEscritura = unidades;
            return true;
        }

        public override string ToString()
        {
            return "Es un Boligrafo, de color " + Color.ToString() + " y tiene un nivel de tinta de " + UnidadesDeEscritura;

        }
    }
}
