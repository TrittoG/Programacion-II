using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriasClase58
{
    public abstract class Archivo
    {
        protected bool ValidarArchivo(string ruta)
        {
            if(File.Exists(ruta))
            {
                return true;
            }
            else
            {
                throw new FileNotFoundException();
            }
        }
    }
}
