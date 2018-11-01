using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesAbstractas
{
    public abstract class Universitario : Persona
    {
        private int legajo;

        public Universitario()
        {

        }

        public Universitario(int legajo, string nombre, string apellido, string dni, ENacionalidad nacionalidad) : base(nombre,apellido,nacionalidad,dni)
        {
            this.legajo = legajo;
        }


        protected virtual string MostrarDatos()
        {
            StringBuilder st = new StringBuilder();

            st.AppendLine(base.ToString());
            st.AppendLine("Legajo: " + this.legajo);

            return st.ToString();
        }

        protected abstract string ParticiparEnClase();  

        public static bool operator ==(Universitario pg1, Universitario pg2)
        {
            if(pg1.GetType() == pg2.GetType() && (pg1.legajo == pg2.legajo || pg1.DNI == pg2.DNI))
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(Universitario pg1, Universitario pg2)
        {
            return !(pg1 == pg2);
        }

         
    }
}
