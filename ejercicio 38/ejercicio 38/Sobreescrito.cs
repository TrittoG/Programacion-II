using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_38
{
     class Sobreescrito
    {
        public override string ToString()
        {
            return "este es mi metodo toString";
        }

        public override bool Equals(object sobre)
        {
            if(sobre.GetType() == this.GetType())
            {
                return true;              
            }
            return false;
        }

        public override int GetHashCode()
        {
            return 1142510187;
        }
    }
}
