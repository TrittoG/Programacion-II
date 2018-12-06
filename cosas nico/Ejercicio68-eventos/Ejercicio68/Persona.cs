using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio68
{
    public delegate void DelegadoString(string msg);

    public class Persona
    {
        string nombre;
        string apellido;

        public Persona(string nom, string ape)
        {
            nombre = nom;
            apellido = ape;
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
            }
        }

        public string Apellido
        {
            get
            {
                return apellido;
            }
            set
            {
                apellido = value;
            }
        }

        public string Mostrar()
        {
            return nombre + " " + apellido;
        }
    }
}
