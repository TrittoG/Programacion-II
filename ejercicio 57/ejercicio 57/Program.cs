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
            Person p = new Person("Giuliano", "Tritto");

            Person.Guardar(p,"archivoBinario.xml");

            Person q = Person.Leer("archivoBinario.xml");

            Console.WriteLine(q.Nombre);

            Console.ReadKey();

        }
    }
}
