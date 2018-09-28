using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Alumno : Persona
    {
        //Fields
        private short anio;
        private Divisiones division;

        public Alumno(string nombre, string apellido, string documento, short anio, Divisiones division) :base(nombre,apellido,documento)
        {
            this.anio = anio;
            this.division = division;
        }

        public override string ExponerDatos()
        {
            StringBuilder stri = new StringBuilder();

            stri.AppendLine(base.ExponerDatos());
            stri.AppendLine("año: " + this.AnioDivision);

            return stri.ToString();
        }

        protected override bool ValidarDocumentacion(string doc)
        {
            if(doc.Length == 9 && doc[2] == '-' && doc[7] == '-')
            {
                doc = doc.Replace("-","");
                for(int i = 0; i<doc.Length; i++)
                {
                    
                    if ((doc[i] < '0' || doc[i] > '9'))
                    {
                        return false;
                    }

                }
                return true;
            }
            return false;
        }

        public string AnioDivision
        {
            get
            {
                return this.anio + "º" + this.division;
            }
        }
    }
}
