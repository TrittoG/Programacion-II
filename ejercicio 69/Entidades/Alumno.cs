using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Alumno
    {
        private string apellido;
        private string nombre;
        private int dni;
        private string fotoAlumno;
       

        public Alumno(string nombre, string apellido, int dni, string ruta)
        {
            this.Apellido = apellido;
            this.Nombre = nombre;
            this.Dni = dni;
            this.RutaDeLaFoto = ruta;
            
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

        public int Dni
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

        public string RutaDeLaFoto
        {
            get
            {
                return this.fotoAlumno;
            }
            set
            {
                this.fotoAlumno = value;
            }
        }

      


        
    }
}
