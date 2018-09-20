using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_31
{
    class Cliente
    {
        private string nombre;
        private int numero;

        public string Nombre
        {
            set
            {
                this.nombre = value;
            }

            get
            {
                return this.nombre;
            }
        }

        public int Numero
        {
            set
            {
                this.numero = value;
            }
            get
            {
                return this.numero;
            }
        }

        public Cliente(int numero)
        {
            this.Numero = numero;
        }

        public Cliente(int numero, string nombre)
        {
            this.Numero = numero;
            this.Nombre = nombre;
        }

        public static bool operator ==(Cliente c1, Cliente c2)
        {
            if(!(c1 is null || c2 is null))
            {
                if(c1.Numero == c2.Numero)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator !=(Cliente c1, Cliente c2)
        {
            return !(c1 == c2);
        }


    }
}
