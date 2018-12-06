using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio47
{
    public abstract class Equipo
    {
        private string nombre;
        private DateTime creacion;

        public Equipo(string nombre, DateTime creacion)
        {
            this.nombre = nombre;
            this.creacion = creacion;
        }

        public Equipo(string nombre)    :this(nombre, DateTime.Now)
        { }

        public string Nombre
        {
            get
            {
                return nombre;
            }
        }
        public static bool operator ==(Equipo a , Equipo b)
        {
            if (a.nombre == b.nombre && a.creacion == b.creacion)
                return true;
            return false;
        }

        public static bool operator !=(Equipo a, Equipo b)
        {
            return !(a == b);
        }

        public string Ficha()
        {
            return this.nombre + " fundado el " + creacion.ToString();
        }
    }
}
