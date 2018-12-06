using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio NRO 16";
            byte nota1, nota2;
            string n1, n2;
            Alumno alumnoUno = new Alumno();
            alumnoUno.nombre = "Nicolas";
            alumnoUno.apellido = "Mazzoconi";
            alumnoUno.legajo = 5410;
            Console.WriteLine("Agregar notas alumno Uno");
            Console.WriteLine("Primer parcial:");
            n1 = Console.ReadLine();
            if(byte.TryParse(n1, out nota1))
            {
                Console.WriteLine("Segundo parcial:");
                n2 = Console.ReadLine();
                if(byte.TryParse(n2, out nota2))
                {
                    alumnoUno.Estudiar(nota1, nota2);
                }
            }
            Alumno alumnoDos = new Alumno();
            alumnoDos.nombre = "Giuliano";
            alumnoDos.apellido = "Tritto";
            alumnoDos.legajo = 1234;
            Console.WriteLine("Agregar notas alumno dos");
            Console.WriteLine("Primer parcial:");
            n1 = Console.ReadLine();
            if (byte.TryParse(n1, out nota1))
            {
                Console.WriteLine("Segundo parcial:");
                n2 = Console.ReadLine();
                if (byte.TryParse(n2, out nota2))
                {
                    alumnoDos.Estudiar(nota1, nota2);
                }
            }
            Alumno alumnoTres = new Alumno();
            alumnoTres.nombre = "Fabian";
            alumnoTres.apellido = "Gema";
            alumnoTres.legajo = 2341;
            Console.WriteLine("Agregar notas alumno tres");
            Console.WriteLine("Primer parcial:");
            n1 = Console.ReadLine();
            if (byte.TryParse(n1, out nota1))
            {
                Console.WriteLine("Segundo parcial:");
                n2 = Console.ReadLine();
                if (byte.TryParse(n2, out nota2))
                {
                    alumnoTres.Estudiar(nota1, nota2);
                }
            }
            alumnoUno.CalcularFianl();
            alumnoDos.CalcularFianl();
            alumnoTres.CalcularFianl();
            Console.WriteLine(alumnoUno.Mostrar());
            Console.WriteLine(alumnoDos.Mostrar());
            Console.WriteLine(alumnoTres.Mostrar());
            Console.ReadKey();

        }
    }
}
