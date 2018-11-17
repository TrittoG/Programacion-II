using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_68
{
    public delegate void DelegadoString(string msg);


    public class Persona
    {
        private string nombre;
        private string apellido;

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

        public string Apellido
        {
            get
            {
                return this.apellido;
            }
            set
            {
                this.apellido = value;
            }
        }

        public Persona(string nombre, string apellido)
        {
            this.Apellido = apellido;
            this.Nombre = nombre;
        }

        public string Mostrar()
        {
            StringBuilder st = new StringBuilder();

            st.AppendLine(this.Nombre + " , " + this.Apellido);

            return st.ToString();
        }
    }
}
