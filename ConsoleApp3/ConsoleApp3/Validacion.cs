using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Validacion
    {
        public static bool Validar(int valor, int min, int max)
        {
            if(valor < max && valor > min)
            {
                return true;
            }
            return false;
        }
    }
}
