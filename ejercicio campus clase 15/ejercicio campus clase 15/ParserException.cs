using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_campus_clase_15
{
    public class ParserException : Exception
    {
        public ParserException(string mensaje) :this(mensaje, null)
        {

        }
        public ParserException(string mensaje, Exception inner) :base(mensaje,inner)
        {

        }
    }
}
