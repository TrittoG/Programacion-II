using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Profesor  :Persona
    {
        #region Atributos
        private DateTime fechaIngreso;
        #endregion

        #region Constructores
        /// <summary>
        /// Constructor publico recibe los 3 atributos de persona y los manda a la base para cargarlos
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="documento"></param>
        public Profesor(string nombre, string apellido, string documento)   :base(nombre, apellido, documento)
        {}

        /// <summary>
        /// Constrcutor publico que recibe los 3 atributos de personas y los manda al su constructor por otra parte
        /// recibe un atributo de la clase Profesor y la asigna
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="documento"></param>
        /// <param name="fechaIngreso"></param>
        public Profesor(string nombre, string apellido, string documento, DateTime fechaIngreso) : this(nombre, apellido, documento)
        {
            this.fechaIngreso = fechaIngreso;
        }
        #endregion

        #region Propiedades
        /// <summary>
        /// Propiedad publica Antiguedad devuelve la cantidad de tiempo, en días, desde la fecha de 
        /// ingreso del profesor hasta la actualidad
        /// </summary>
        public int Antiguedad
        {
            get
            {
                DateTime now = DateTime.Now;
                TimeSpan tp = now.Subtract(fechaIngreso);
                return tp.Days;
            }
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Devuelve una string con los datos de la base mas lo de la clase alumno
        /// </summary>
        /// <returns></returns>
        public override string ExponerDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("{0}, antiguedad: {1}", base.ExponerDatos(), Antiguedad);
            return sb.ToString();
        }

        /// <summary>
        /// Valida que el documento tenga 8 digitos y que sea numerico
        /// </summary>
        /// <param name="doc"></param>
        /// <returns></returns>
        protected override bool ValidarDocumentacion(string doc)
        {
            if (doc.Length == 8)
            {
                for (int i = 0; i < doc.Length; i++)
                    if (doc[i] < '0' || doc[i] > '9')
                        return false;

                return true;
            }
            return false;
        }
        #endregion
    }
}
