using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Persona
    {
        #region Atributos
        private string apellido;
        private string documento;
        private string nombre;
        #endregion

        #region Constructores
        /// <summary>
        /// Constructor publico recibe 3 parametros y los asigna
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="documento"></param>
        public Persona(string nombre, string apellido, string documento)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            Documento = documento;
        }
        #endregion

        #region Propiedades
        /// <summary>
        /// Propiedad public de solo lectura que retorna el apellido de la persona
        /// </summary>
        public string Apellido
        {
            get
            {
                return this.apellido;
            }
        }

        /// <summary>
        /// Propiedad public de solo lectura que retorna el nombre de la persona
        /// </summary>
        public string Nombre
        {
            get
            {
                return this.nombre;
            }
        }

        /// <summary>
        /// Propiedad public de lectura y escritura, get: devuelve el documento de la persona y en el set lo asigna
        /// </summary>
        public string Documento
        {
            get
            {
                return this.documento;
            }

            set
            {
                if(ValidarDocumentacion(value))
                    this.documento = value;
            }
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Genera una string con las datos de la persona
        /// </summary>
        /// <returns>String con los datos</returns>
        public virtual string ExponerDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Nombre: " + Nombre + ", Apellido: " + Apellido + ", Documento: " + Documento);
            return sb.ToString();
        }

        /// <summary>
        /// Methodo abstracto que valida un documento
        /// </summary>
        /// <param name="doc"></param>
        /// <returns></returns>
        protected abstract bool ValidarDocumentacion(string doc);

        #endregion

    }
}
