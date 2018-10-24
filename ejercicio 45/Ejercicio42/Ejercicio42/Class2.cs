using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio42
{
    public class Class2
    {
        private Class1 a;
        public Class2()
        {
            try
            {
                a = new Class1();
            }
            catch(DivideByZeroException ex)
            {
                throw new UnaException("Mensaje UnaException", ex);
            }
        }
    }
}
