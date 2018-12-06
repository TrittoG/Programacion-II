using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Alumno
    {
        string _apellido;
        string _nombre;
        string _fotoAlumno;
        int _dni;

        public string Apellido
        {
            get
            {
                return _apellido;
            }
            set
            {
                _apellido = value;
            }
        }

        public string Nombre
        {
            get
            {
                return _nombre;
            }
            set
            {
                _nombre = value;
            }
        }

        public string FotoAlumno
        {
            get
            {
                return _fotoAlumno;
            }
            set
            {
                _fotoAlumno = value;
            }
        }

        public int Dni
        {
            get
            {
                return _dni;
            }
            set
            {
                _dni = value;
            }
        }

        public Alumno(string nombre, string apellido, string foto, int dni)
        {
            _nombre = nombre;
            _apellido = apellido;
            _fotoAlumno = foto;
            _dni = dni;
        }
    }
}
