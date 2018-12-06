using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio42
{
    public class Class1
    {
        public Class1() 
        {
            try
            {
                MiException();
            }
            catch(DivideByZeroException ex)
            {
                throw ex;
            }
        }

        public static string MiException()
        {
            throw new DivideByZeroException("No se puede dividir por 0");
        }
    }
}
