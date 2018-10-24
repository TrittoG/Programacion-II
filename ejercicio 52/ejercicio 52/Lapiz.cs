using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_52
{
    public class Lapiz : IAcciones
    {
        private float tamanioMina;

        public Lapiz(int unidades)
        {
            this.tamanioMina = unidades;
        }

        ConsoleColor IAcciones.Color
        {
            get
            {
                return ConsoleColor.Gray;
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        float IAcciones.UnidadesDeEscritura
        {
            get
            {
                return this.tamanioMina;
            }
            set
            {
                this.tamanioMina = value;
            }
        }


        public bool Recargar(int unidades)
        {
            throw new NotImplementedException();
        }

        public EscrituraWrapper Escribir(string texto)
        {
            float gastado = 0;

            foreach(char c in texto)
            {
                gastado += 1;
            }

            this.tamanioMina = tamanioMina - ((float)0.1 * gastado);

            return new EscrituraWrapper(texto, ((IAcciones)this).Color);
        }

        public override string ToString()
        {
            StringBuilder st = new StringBuilder();
            st.AppendLine("Lapiz de color " + ((IAcciones)this).Color + " y con un nivel de tinta de: " + ((IAcciones)this).UnidadesDeEscritura);

            return st.ToString();
        }
    }
}
