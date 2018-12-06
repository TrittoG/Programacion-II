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
            StringBuilder path = new StringBuilder();
            path.AppendFormat("{0}{1}{2}-{3}{4}.txt", DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Hour, DateTime.Now.Minute);
            try
            {
                Class2 b = new Class2();
            }
            catch(UnaException ex)
            {
                if (ex.InnerException != null)
                    ArchivoTexto.Guardar(path.ToString() ,ex.Message + ", " + ex.InnerException.Message);
                else
                    ArchivoTexto.Guardar(path.ToString(), ex.Message);
            }
            catch(DivideByZeroException ex)
            {
                ArchivoTexto.Guardar(path.ToString(), ex.Message);
            }
            catch(Exception ex)
            {
                ArchivoTexto.Guardar(path.ToString(), ex.Message);
            }

            Console.WriteLine(ArchivoTexto.Leer(path.ToString()));
            Console.ReadKey();
        }
    }
}
