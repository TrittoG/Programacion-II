using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_7
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Title = "EJERCICIO 7";

      int dia,mes,anio,diaActual,mesActual,anioActual,diav,mesv,aniov, total;
      DateTime actual = DateTime.Now;
      string respuesta, diaString, mesString, anioString;
      respuesta = "s";

      do
      {
        Console.WriteLine("ingrese el dia: ");
        diaString = Console.ReadLine();
        if(int.TryParse(diaString, out dia) && dia< 32)
        {

          Console.WriteLine("ingrese el mes: ");
          mesString = Console.ReadLine();
          if (int.TryParse(mesString, out mes) && mes < 13)
          {

            Console.WriteLine("ingrese el añño: ");
            anioString = Console.ReadLine();
            if (int.TryParse(anioString, out anio) && anio <= actual.Year)
            {
              Console.WriteLine("{0}", actual);
              anioActual = actual.Year;
              mesActual = actual.Month;
              diaActual = actual.Day;

              if(mes == 4 || mes == 6 || mes == 9 || mes == 11)
              {
                aniov = anioActual - anio;
                mesv = mesActual - mes;
                diav = diaActual - dia;

                total = diav + (mesv * 30) + (aniov * 365);
                Console.WriteLine("usted vivio {0} dias.", total);
              }
              else if(mes == 2)
              {
                
                aniov = anioActual - anio;
                mesv = mesActual - mes;
                diav = diaActual - dia;

                total = diav + (mesv * 28) + (aniov * 365);
                Console.WriteLine("usted vivio {0} dias.", total);
              }
              else
              {
                aniov = anioActual - anio;
                mesv = mesActual - mes;
                diav = diaActual - dia;
                total = diav + (mesv * 31) + (aniov * 365);
                Console.WriteLine("usted vivio {0} dias.", total);

              }

           

              

            }

          }


        }
        Console.WriteLine("desea volver a ver... s/n ");
        respuesta = Console.ReadLine();

      } while (respuesta != "n");
      Console.ReadKey();

    }


  }
}
