using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio35
{
    class Persona
    {
        protected long dni;
        protected string nombre;

        public Persona(string nombre)
        {
            this.nombre = nombre;
        }

        public Persona(long dni, string nombre) :this(nombre)
        {
            this.dni = dni;
        }

        public string MostrarDatos()
        {
            if(this.dni > 0)
                return "DNI: " + this.dni + ", Nombre: " + this.nombre;
            return "Nombre: " + this.nombre;
        }

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

        public long Dni
        {
            get
            {
                return this.dni;
            }
            set
            {
                this.dni = value;
            }
        }
    }
}
