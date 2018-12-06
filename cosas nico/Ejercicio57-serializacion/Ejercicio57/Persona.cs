using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
namespace Ejercicio57
{
    [Serializable]
    public class Persona
    {
        private string nombre;
        private string apellido;

        public Persona(string n, string a)
        {
            nombre = n;
            apellido = a;
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }
        }
        public static void Guardar(Persona p, string path)
        {
            FileStream fs;
            BinaryFormatter ser;
            fs = new FileStream(path, FileMode.Create);
            ser = new BinaryFormatter();
            ser.Serialize(fs, p);
            fs.Close();
        }

        public static Persona Leer(string path)
        {
            Persona aux;
            FileStream fs;
            BinaryFormatter ser;
            fs = new FileStream(path, FileMode.Open);
            ser = new BinaryFormatter();
            aux = (Persona)ser.Deserialize(fs);
            fs.Close();
            return aux;
        }
    }
}
