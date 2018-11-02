using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_57
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Person p = new Person("Giuliano", "Tritto");

                Person.Guardar(p, "archivo.xml");

                Person q;
                q = Person.Leer("archivo.xml");

                Console.WriteLine(q.Nombre);
                Console.WriteLine(q.ToString());

            }
            catch(InvalidOperationException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(ArgumentException e)
            {
                Console.WriteLine(e.Message);

            }

            Console.ReadKey();

        }
    }
}
