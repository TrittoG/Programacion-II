using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Entidades
{
    public class SerializarXML<T> : IArchivos<T>
    {
        public bool Guardar(string ruta, T obj)
        {
            XmlTextWriter writer = null;
            XmlSerializer ser;


            try
            {
                writer = new XmlTextWriter(ruta, Encoding.UTF8);

                ser = new XmlSerializer(typeof(T));

                ser.Serialize(writer, obj);
                return true;
            }
            catch (Exception e)
            {
                throw new ErrorArchivoException(e.Message);
            }
            finally
            {
                if (writer != null)
                    writer.Close();

            }

        }

        public T Leer(string ruta)
        {

            XmlTextReader reader = null;
            XmlSerializer ser;
            T aux;

            try
            {
                reader = new XmlTextReader(ruta);
                ser = new XmlSerializer(typeof(T));
                aux = (T)ser.Deserialize(reader);
            }
            catch (Exception e)
            {
                throw new ErrorArchivoException(e.Message);
            }
            finally
            {
                if (reader != null)
                    reader.Close();
            }
            return aux;

        }

    }
}
