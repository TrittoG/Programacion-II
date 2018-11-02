using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml;
using System.Xml.Serialization;

namespace ejercicio_57
{
    [Serializable]
    public class Person
    {
        private string nombre;
        private string apellido;

      public Person()
        {

        }

        public Person(string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
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

        public static void Guardar(Person p, string path)
        {
            //FileStream fs;
            //BinaryFormatter ser;
            //fs = new FileStream(path, FileMode.Create);
            //ser = new BinaryFormatter();
            //ser.Serialize(fs, p);
            //fs.Close();

            XmlTextWriter writer = null ;
            XmlSerializer ser;


            try
            {
                 writer = new XmlTextWriter(path, Encoding.UTF8);

                 ser = new XmlSerializer(typeof(Person));

                 ser.Serialize(writer, p);           
            }
            catch(InvalidOperationException e)
            {
                throw e;
            }
            finally
            {
                if(writer != null)
                    writer.Close();

            }


            
                    

        }


        public static Person Leer(string path)
        {
            //FileStream fs;
            //BinaryFormatter ser;
            //Person asd;

            //fs = new FileStream(path, FileMode.Open);
            //ser = new BinaryFormatter();

            //asd = (Person)ser.Deserialize(fs);
            //fs.Close();
            //return asd;

            XmlTextReader reader = null;
            XmlSerializer ser;
            Person aux;
            
            try
            {
                reader = new XmlTextReader(path);
                ser = new XmlSerializer(typeof(Person));
                aux = (Person)ser.Deserialize(reader);
            }
            catch(Exception e)
            {
                throw e;
            }
            finally
            {
                if(reader != null)
                    reader.Close();
            }
            return aux;
            
        }

        public override string ToString()
        {
            StringBuilder st = new StringBuilder();

            st.AppendLine("Nombre: " + this.Nombre);
            st.AppendLine("Apellido: " + this.Apellido);

            return st.ToString();
        }

    }
}
