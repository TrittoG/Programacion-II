using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace ejercicio_57
{
    [Serializable]
    public class Person
    {
        private string nombre;
        private string apellido;

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
        }



        public static void Guardar(Person p, string path)
        {      
            FileStream fs;
            BinaryFormatter ser;

            fs = new FileStream(path, FileMode.Create);
            ser = new BinaryFormatter();

            ser.Serialize(fs, p);
            fs.Close();

        }


        public static Person Leer(string path)
        {
            FileStream fs;
            BinaryFormatter ser;
            Person asd;

            fs = new FileStream(path, FileMode.Open);
            ser = new BinaryFormatter();

            asd = (Person)ser.Deserialize(fs);
            fs.Close();
            return asd;
        }

    }
}
