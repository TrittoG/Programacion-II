using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio7
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Title = "Ejercicio Nro 7";
      int dia, mes, año, diaDif = 0, mesDif = 0, añoDif = 0, sumaTotal=0;
      int diaOk = 0, mesOk= 0, añoOk = 0;
      DateTime actual = DateTime.Now;
      string diaStr, mesStr, añoStr;

      Console.WriteLine("Ingrese el año de nacimiento");
      añoStr = Console.ReadLine();
      if (int.TryParse(añoStr, out año))
      {
        if (año > 0 && año < actual.Year)
        {
          añoDif = actual.Year - año;
          añoOk = 1;
        }
      }

      Console.WriteLine("Ingrese el mes de nacimiento");
      mesStr = Console.ReadLine();
      if (int.TryParse(mesStr, out mes))
      {
        if (mes > 0 && mes < 13)
        {
          mesDif = actual.Month - mes;
          mesOk = 1;
        }
      }

      Console.WriteLine("Ingrese el dia de nacimiento");
      diaStr = Console.ReadLine();
      if(int.TryParse(diaStr, out dia))
      {
        switch(mes)
        {
          case 4:
            if (dia > 0 && dia < 31)
            {
              diaOk = 1;
              diaDif = actual.Day - dia;
            }
            else
              Console.WriteLine("Dia invalido");
            break;
          case 6:
            if (dia > 0 && dia < 31)
            {
              diaOk = 1;
              diaDif = actual.Day - dia;
            }
            else
              Console.WriteLine("Dia invalido");
            break;
          case 9:
            if (dia > 0 && dia < 31)
            {
              diaOk = 1;
              diaDif = actual.Day - dia;
            }
            else
              Console.WriteLine("Dia invalido");
            break;
          case 11:
            if (dia > 0 && dia < 31)
            {
              diaOk = 1;
              diaDif = actual.Day - dia;
            }
            else
              Console.WriteLine("Dia invalido");
            break;
          case 2:
            if (año % 4 == 0 && año % 100 != 0 || año % 400 == 0)
              if (dia > 0 && dia < 30)
              {
                diaOk = 1;
                diaDif = actual.Day - dia;
              }
              else
                Console.WriteLine("Dia invalido");
            else
              if (dia > 0 && dia < 29)
            {
              diaOk = 1;
              diaDif = actual.Day - dia;
            }
            else
              Console.WriteLine("Dia invalido");
            break;
          default:
            if (dia > 0 && dia < 32)
            {
              diaOk = 1;
              diaDif = actual.Day - dia;
            }
            else
              Console.WriteLine("Dia invalido");
            break;
        }
      }
      if(diaOk == 1 && mesOk == 1 && añoOk == 1)
      {
        ///////////////////////////AÑO
        int i,bis = 0;
        for(i = año; i < actual.Year; i++)
        {
          if(i % 4 == 0 && i % 100 != 0 || i % 400 == 0)
          {
            bis++;
          }
        }
        ///////////////////////////////MEs
        if(mes >= actual.Month)
        {
          sumaTotal = (añoDif - 1) * 365 + bis;
          for (i = 1; i < actual.Month; i++)
          {
            sumaTotal = sumaTotal + Program.calcDiaMes(i, año);
            Console.WriteLine(sumaTotal);
          }
         for(i = mes; i <= 12; i++)
          {
            sumaTotal = sumaTotal + Program.calcDiaMes(i, año);
            Console.WriteLine(sumaTotal);
          }
        }
        else
        {
          if(mes < actual.Month)
            sumaTotal = (añoDif) * 365 + bis;
          {
            for(i = mes; i < actual.Month; i++)
            {
              sumaTotal = sumaTotal + Program.calcDiaMes(i, año);
              Console.WriteLine(sumaTotal);
            }

          }
        }
        ////////////////////////DIA
        sumaTotal = sumaTotal + diaDif;
        Console.WriteLine("Vivio {0}", sumaTotal);
      }
      else
      {
        Console.WriteLine("Datos invalidos");
      }
      Console.ReadKey();


    }

    public static int calcDiaMes(int i, int año)
    {
      switch (i)
      {
        case 4:
          return 30;
          
        case 6:
          return 30;
          
        case 9:
          return 30;
          
        case 11:
          return 30;
          
        case 2:
          if (año % 4 == 0 && año % 100 != 0 || año % 400 == 0)
            return 29;
          else
            return 28;
          
        default:
          return 31;
          
      }
    }
  }
}
