using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClase15
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            string s = "ssss21";
            string l = "1111";
            string o = "11111111111";

            try
            {
                Parser.TryParse(o, out a);
                Console.WriteLine(a);
            }
            catch(ParserException ex)
            {
                Console.WriteLine(ex.Message + ex.InnerException.Message);
            }
            
            Console.ReadKey();
            
        }
    }
}
