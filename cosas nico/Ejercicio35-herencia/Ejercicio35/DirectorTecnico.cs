using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio35
{
    class DirectorTecnico   :Persona
    {
        private DateTime fechaNaciomiento;

        private DirectorTecnico(string nombre)  :base(nombre)
        { }

        public DirectorTecnico(string nombre, DateTime fecha)  :this(nombre)
        {
            this.fechaNaciomiento = fecha;
        }

        public string MostrarDatosDT()
        {
            return this.MostrarDatos() + ", Fecha de nacimiento: " + this.fechaNaciomiento;
        }

        public static bool operator ==(DirectorTecnico dt1, DirectorTecnico dt2)
        {
            if ((dt1.fechaNaciomiento == dt2.fechaNaciomiento) && dt1.Nombre == dt2.Nombre)
                return true;
            return false;
        }

        public static bool operator !=(DirectorTecnico dt1, DirectorTecnico dt2)
        {
            return !(dt1 == dt2);
        }
    }
}
