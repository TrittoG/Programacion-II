using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Profesor : Persona
    {
        //fields
        private DateTime fechaIngreso;

       
        //Constructores
        #region Constructores

        public Profesor(string nombre, string apellido, string documento) :base(nombre,apellido, documento)
        {

        }

        public Profesor(string nombre, string apellido, string documento, DateTime fechaIngreso) : this(nombre, apellido, documento)
        {
            this.fechaIngreso = fechaIngreso;
        }

        #endregion

        //propiedades

        /// <summary>
        /// Antigüedad devolverá la cantidad de tiempo, en días, desde la fecha de ingreso del profesor hasta la
        ///actualidad.
            /// </summary>
        public int Antiguedad
        {
            
            get
            {
                DateTime hoy = DateTime.Now;
                TimeSpan fecha = hoy.Subtract(fechaIngreso);

                return fecha.Days;
            }
        }

        public override string ExponerDatos()
        {
            StringBuilder st = new StringBuilder();

            st.AppendLine(base.ExponerDatos());
            st.AppendLine("Fecha de ingreso: " + this.Antiguedad);

            return st.ToString();
        }


        protected override bool ValidarDocumentacion(string doc)
        {
            for (int i = 0; i< doc.Length;i++)
            {
                if(doc.Length != 8 || (doc[i]<'0' || doc[i]>'9'))
                {
                    return false;
                }
            }
            return true;
        }


    }
}
