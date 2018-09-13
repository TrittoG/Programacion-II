using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "EJERCICIO 16";

            byte notaUno;
            byte notaDos;
            string notaUnoString;
            string notaDosString;

            Alumno alumnoUno = new Alumno() ;
            Alumno alumnoDos = new Alumno() ;
            Alumno alumnoTres = new Alumno() ;

           


            alumnoUno.nombre = "Nicolasa";
            alumnoUno.apellido = "mazzoconi";
            alumnoUno.legajo = 1234;

            alumnoDos.nombre = "Fabian";
            alumnoDos.apellido = "yema";
            alumnoDos.legajo = 2000;

            alumnoTres.nombre = "GGT";
            alumnoTres.apellido = "Tritto";
            alumnoTres.legajo = 1000;

            

            // ALUMNO UNO--------------------------
                Console.WriteLine("ingrese la primer nota de {0}", alumnoUno.nombre);
                notaUnoString = Console.ReadLine();

                if (byte.TryParse(notaUnoString, out notaUno))
                {
                    Console.WriteLine("ingrese la segunda nota de {0}", alumnoUno.nombre);
                    notaDosString = Console.ReadLine();

                if (byte.TryParse(notaDosString, out notaDos))
                    {
                        alumnoUno.Estudiar(notaUno, notaDos);
                        alumnoUno.CalcularFinal();
                    }
                }


            //ALUMNO DOS------------------------------------------
            Console.WriteLine("ingrese la primer nota de {0}", alumnoDos.nombre);
            notaUnoString = Console.ReadLine();

            if (byte.TryParse(notaUnoString, out notaUno))
            {
                Console.WriteLine("ingrese la segunda nota de {0}", alumnoDos.nombre);
                notaDosString = Console.ReadLine();

                if (byte.TryParse(notaDosString, out notaDos))
                {
                    alumnoDos.Estudiar(notaUno, notaDos);
                    alumnoDos.CalcularFinal();
                }
            }


            //ALUMNO TRES------------------------------------
            Console.WriteLine("ingrese la primer nota de {0}", alumnoTres.nombre);
            notaUnoString = Console.ReadLine();

            if (byte.TryParse(notaUnoString, out notaUno))
            {
                Console.WriteLine("ingrese la segunda nota de {0}", alumnoTres.nombre);
                notaDosString = Console.ReadLine();

                if (byte.TryParse(notaDosString, out notaDos))
                {
                    alumnoTres.Estudiar(notaUno, notaDos);
                    alumnoTres.CalcularFinal();
                }
            }



            Console.WriteLine("{0}",alumnoUno.Mostrar());
            Console.WriteLine("{0}", alumnoDos.Mostrar());
            Console.WriteLine("{0}", alumnoTres.Mostrar());

            Console.ReadKey();


        }
    }
}
