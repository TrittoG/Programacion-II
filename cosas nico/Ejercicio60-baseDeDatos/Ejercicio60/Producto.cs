using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio60
{
    public class Producto
    {
        string nombre;
        string id;
        string serial;

        public Producto(string nombre, string serial, string id)
        {
            this.nombre = nombre;
            this.id = id;
            this.serial = serial;
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
            }
        }

        public string Serial
        {
            get
            {
                return serial;
            }
            set
            {
                serial = value;
            }
        }

        public string ID
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }
    }
}
