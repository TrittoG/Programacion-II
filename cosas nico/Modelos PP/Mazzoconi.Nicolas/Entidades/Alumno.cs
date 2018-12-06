using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Alumno    :Persona
    {
        #region Atributos
        private short anio;
        private Divisiones division;
        #endregion

        #region Constructores
        /// <summary>
        /// Constructor publico de alumno que recibe 5 parametros y 3 los manda a la base para asignarlos y los otros dos los asigna el mismo
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="documento"></param>
        /// <param name="anio"></param>
        /// <param name="division"></param>
        public Alumno(string nombre, string apellido, string documento, short anio, Divisiones division)    :base(nombre, apellido, documento)
        {
            this.anio = anio;
            this.division = division;
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
        /// Devuelve una string con los datos de la base mas lo de la clase alumno
        /// </summary>
        /// <returns></returns>
        public override string ExponerDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("{0}, año: {1}", base.ExponerDatos(), AnioDivision);
            return sb.ToString();
        }

        /// <summary>
        /// ValidarDocumentacion dará como válido sólo documentos que tengan el siguiente formato XX-XXXX-X
        /// siendo las X números.Caso contrario retornará false 
        /// </summary>
        /// <param name="doc"></param>
        /// <returns></returns>
        protected override bool ValidarDocumentacion(string doc)
        {
            if (doc.Length == 9 && doc[2] == '-' && doc[7] == '-')
            {
                doc = doc.Replace("-", "");
                for(int i = 0; i < doc.Length; i++)
                {
                    if (doc[i] < '0' || doc[i] > '9')
                        return false;
                }
                return true;
            }
            return false;
        }


        #endregion
    }
}
