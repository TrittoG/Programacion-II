using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_39
{
    abstract class Sobreescrito
    {
        protected string miAtributo;


        public Sobreescrito()
        {
            this.miAtributo = "Probar abstracto";
        }

        //abstract = las clases derivadas tienen que sobreescribirla
        public abstract string MiPropiedad { get; }
        
       

        public override string ToString()
        {
            return "este es mi metodo toString";
        }

        public override bool Equals(object sobre)
        {
            if (sobre is Sobreescrito)
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
