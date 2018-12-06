using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Curso
    {
        #region Atributos
        private List<Alumno> alumnos;
        private short anio;
        private Divisiones division;
        private Profesor profesor;
        #endregion

        #region Constructores
        /// <summary>
        /// Constructor privado que inicializa la lista de alumnos
        /// </summary>
        private Curso()
        {
            this.alumnos = new List<Alumno>();
        }

        /// <summary>
        /// Constructor publico que llama al privado para inicializar la lista de alumnos y
        /// recibe 3 parametros para asignar a la clase
        /// </summary>
        /// <param name="anio"></param>
        /// <param name="division"></param>
        /// <param name="profesor"></param>
        public Curso(short anio, Divisiones division, Profesor profesor) :this()
        {
            this.anio = anio;
            this.division = division;
            this.profesor = profesor;
        }
        #endregion

        #region Propiedades
        /// <summary>
        /// Propiedad AnioDivision de solo lectura que retorna un string con el siguiente formato: XºZ
        /// siendo X el año que se encuentra cursando y Z la división
        /// </summary>
        public string AnioDivision
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendFormat("{0}º{1}", anio, division.ToString());
                return sb.ToString();
            }
        }
        #endregion

        #region Metodos
        /// <summary>
        /// retorna los datos del curso y todos sus alumnos, utilizando StringBuilder para
        /// compilar dicha información
        /// </summary>
        /// <param name="c"></param>
        public static explicit operator string(Curso c)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Profesor: {0}\n", c.profesor.ExponerDatos());
            sb.AppendFormat("Division: {0}\n", c.AnioDivision);
            sb.AppendLine("Alumnos:");
            foreach(Alumno a in c.alumnos)
            {
                sb.AppendLine(a.ExponerDatos());
            }
            return sb.ToString();
        }

        /// <summary>
        ///  informará true si el alumno pertenece al mismo Año y División
        /// que el curso
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
        /// informará false si el alumno pertenece al mismo Año y División
        /// que el curso
        /// </summary>
        /// <param name="c"></param>
        /// <param name="a"></param>
        /// <returns></returns>
        public static bool operator !=(Curso c, Alumno a)
        {
            return !(c == a);
        }

        /// <summary>
        ///  agregará al alumno al curso siempre y cuando su Año y División
        /// coincidan
        /// </summary>
        /// <param name="c"></param>
        /// <param name="a"></param>
        /// <returns></returns>
        public static Curso operator +(Curso c, Alumno a)
        {
            if (c == a)
                c.alumnos.Add(a);
            return c;
        }
        #endregion
    }
}
