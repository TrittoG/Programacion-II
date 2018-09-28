using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Curso
    {
        private List<Alumno> alumnos;
        private short anio;
        private Divisiones division;
        private Profesor profesor;

        //constructores
        private Curso()
        {
            this.alumnos = new List<Alumno>();
        }

        public Curso(short anio, Divisiones division, Profesor profesor) : this()
        {
            this.anio = anio;
            this.division = division;
            this.profesor = profesor;
        }

        //propiedades
        public string AnioDivision
        {
            get
            {
                return this.anio + "º" + this.division;
            }
        }

        /// <summary>
        /// El constructor privado será el único lugar donde se instanciará la lista de alumnos.
        /// </summary>
        /// <param name="c"></param>
        public static explicit operator string(Curso c)
        {
            StringBuilder st = new StringBuilder();

            st.AppendLine(c.profesor.ExponerDatos());

            st.AppendLine("datos del curso: " + c.AnioDivision);

            st.AppendLine("alumnos: ");
            
            foreach(Alumno al in c.alumnos)
            {
                st.AppendLine(al.ExponerDatos());
                
            }

            return st.ToString();
        }


        /// <summary>
        ///El operador == entre Curso y Alumno informará true si el alumno pertenece al mismo Año y División
        ///que el curso.
       /// </summary>
       /// <param name="c"></param>
       /// <param name="a"></param>
       /// <returns></returns>
        public static bool operator ==(Curso c, Alumno a)
        {
            if (c.AnioDivision == a.AnioDivision)
                return true;
            return false;
        }

        /// <summary>
        /// El operador != entre Curso y Alumno informará true si el alumno nopertenece al mismo Año y División
        ///que el curso.
        /// </summary>
        /// <param name="c"></param>
        /// <param name="a"></param>
        /// <returns></returns>
        public static bool operator !=(Curso c, Alumno a)
        {
            return !(c == a);
        }

        /// <summary>
        /// El operador + entre Curso y Alumno agregará al alumno al curso siempre y cuando su Año y División
        ///coincidan
        /// </summary>
        /// <returns></returns>
        public static Curso operator +(Curso c, Alumno a)
        {
            if(c==a)
            {
                c.alumnos.Add(a);
            }
            return c;
        }

    }
}
