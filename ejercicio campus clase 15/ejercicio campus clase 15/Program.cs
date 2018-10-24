using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_campus_clase_15
{
    class Program
    {
        static void Main(string[] args)
        {
            string bueno = "222";
            string malo = "asd";
            string malo2 = "5555555555555555555555555555555555555555555555555555555555555555555555555555555555555";
            int i;

            try
            {
                i = Parser.Parse(bueno);
                Console.WriteLine(i);

               // i = Parser.Parse(malo);
                
                if(Parser.TryParse(malo2, out i))
                {

                }

            }
            catch(ParserException p)
            {
                Console.WriteLine(p.Message + p.InnerException.Message);
            }

            Console.ReadKey();
        }
    }
}
