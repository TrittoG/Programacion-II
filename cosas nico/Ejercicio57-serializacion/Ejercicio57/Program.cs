using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio57
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona uno = new Persona("Nico", "Mazzoconi");
            Persona.Guardar(uno, "Archivo.xml");

            Persona dos = Persona.Leer("Archivo.xml");
            Console.WriteLine(dos.Nombre);
            Console.ReadKey();
        }
    }
}
