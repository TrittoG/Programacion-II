using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_campus_clase_15
{
    public static class Parser
    {

        public static bool TryParse(string st, out int entero)
        {
            try
            {
                entero = Int32.Parse(st);
                return true;

            }
            catch (FormatException f)
            {
                throw new ParserException("El string no podrá ser convertido", f);
            }
            catch (OverflowException o)
            {
                throw new ParserException("El string no podrá ser convertido", o);
            }
        }



        public static int Parse(string st)
        {
            int entero;
            try
            {
                TryParse(st, out entero);
                return entero;

            }
            catch (FormatException f)
            {
                throw f;
            }
            catch(OverflowException o)
            {
                throw o;
            }
        }

    }
}
