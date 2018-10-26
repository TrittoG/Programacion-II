using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IO;

namespace Ejercicio42
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro42";
            DateTime hoy = new DateTime();
            hoy = DateTime.Now;
        
            try
            {
                Class2 b = new Class2();
            }
            catch(UnaException ex)
            {
               

                if (ex.InnerException != null)
                    //Console.WriteLine(ex.Message + ", " + ex.InnerException.Message);
                    ArchivoTexto.Guardar("archivo.txt", ex.Message + " " + ex.InnerException.Message + hoy.Date.ToString());

                else
                    //Console.WriteLine(ex.Message);
                    ArchivoTexto.Guardar("archivo.txt", ex.Message + hoy.Date.ToString());
            }
            catch(DivideByZeroException ex)
            {
                //Console.WriteLine(ex.Message);
                ArchivoTexto.Guardar("archivo.txt", ex.Message + hoy.Date.ToString());
            }
            catch(Exception ex)
            {
                //Console.WriteLine(ex.Message);
                ArchivoTexto.Guardar("archivo.txt", ex.Message + hoy.Date.ToString());

            }

            Console.WriteLine( ArchivoTexto.Leer("archivo.txt"));
            Console.ReadKey();
        }
    }
}
