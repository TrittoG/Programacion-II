using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_60
{
    public class Producto
    {
        string nombre;
        string id;
        string productNumber;

        public Producto(string nombre, string producto, string id)
        {
            this.Nombre = nombre;
            this.Id = id;
            this.ProductNumber = producto;
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

        public string ProductNumber
        {
            get
            {
                return this.productNumber;
            }
            set
            {
                this.productNumber = value;
            }
        }

        public string Id
        {
            get
            {
                return this.id;
            }
            set
            {
                this.id = value;
            }
        }

        public override string ToString()
        {
            StringBuilder st = new StringBuilder();

            st.AppendLine("NOMBRE: " + this.Nombre);
            st.AppendLine("ID: " + this.Id);
            st.AppendLine("NUMERO DE PRODUCTO: " + this.ProductNumber);

            return st.ToString();
        }

    }
}
