using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{


    public abstract class Persona
    {
        private string nombre;
        private string apellido;
        private string documento;

        //constructor
        /// <summary>
        /// constructor para persona con todos los parametros
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="document"></param>
        public Persona(string nombre, string apellido, string document)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.Documento = document;
        }

        //propiedades

            /// <summary>
            /// retorna el valor del parametro apellido
            /// </summary>
        public string Apellido
        {
            get
            {
                return this.apellido;
            }
        }

        /// <summary>
        /// retorna el valor del parametro documento
        /// </summary>
        public string Documento
        {
            get
            {
                return this.documento;
            }
            set
            {
                if (ValidarDocumentacion(value))
                    this.documento = value;          
            }
        }
        /// <summary>
        /// retorna el valor del parametro nombre
        /// </summary>
        public string Nombre
        {
            get
            {
                return this.nombre;
            }
        }


        //metodos

        public virtual string ExponerDatos()
        {
            StringBuilder str = new StringBuilder();
            str.AppendLine("nombre: " + this.Nombre);
            str.AppendLine("apellido: " + this.Apellido);
            str.AppendLine("Documento: " + this.Documento);

            return str.ToString();
        }

        protected abstract bool ValidarDocumentacion(string doc);
            //foreach(char c in doc)
            //{
            //    if(c<'a' || c> 'z')
            //}
        

    }
}
