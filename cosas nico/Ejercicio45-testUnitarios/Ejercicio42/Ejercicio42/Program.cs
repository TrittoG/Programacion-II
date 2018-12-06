using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio42
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro42";

            try
            {
                Class2 b = new Class2();
            }
            catch(UnaException ex)
            {
                if (ex.InnerException != null)
                    Console.WriteLine(ex.Message + ", " + ex.InnerException.Message);
                else
                    Console.WriteLine(ex.Message);
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}
