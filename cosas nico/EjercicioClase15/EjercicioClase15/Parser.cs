using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClase15
{
    public static class Parser
    {
        public static bool TryParse(string s, out int i)
        {
            try
            {
                i = Int32.Parse(s);
                return true;
            }
            catch(OverflowException ex)
            {
                throw new ParserException("El string no podrá ser convertido por:\n", ex);
            }
            catch(FormatException ex)
            {
                throw new FormatException("El string no podrá ser convertido por:\n", ex);
            }
       
        }
        public static int Parse(string s)
        {
            int i;
            try
            {
                TryParse(s, out i);
                return i;
            }
            catch(OverflowException ex)
            {
                throw ex;
            }
            catch(FormatException ex)
            {
                throw ex;
            }
        }


    }
}
