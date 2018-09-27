using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_39
{
    class SobreSobreescrito : Sobreescrito
    {
        public override string MiPropiedad
        {
            get
            {
                return this.miAtributo;
            }
        }


    }
}
