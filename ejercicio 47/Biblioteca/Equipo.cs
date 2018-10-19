using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public abstract class Equipo 
    {
        private string nombre;
        private DateTime fechaCreacion;

        public Equipo(string nombre, DateTime fecha)
        {
            this.nombre = nombre;
            this.fechaCreacion = fecha;
        }



        public string Nombre
        {
            get
            {
                return this.nombre;
            }
        }


        public static bool operator ==(Equipo e1, Equipo e2)
        {
            if(e1.nombre == e2.nombre && e1.fechaCreacion == e2.fechaCreacion)
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(Equipo e1, Equipo e2)
        {
            return !(e1 == e2);
        }

        public string Ficha()
        {
            StringBuilder st = new StringBuilder();

            st.AppendLine(this.nombre + " fundado el " + this.fechaCreacion);

            return st.ToString();
        }
    }
}
