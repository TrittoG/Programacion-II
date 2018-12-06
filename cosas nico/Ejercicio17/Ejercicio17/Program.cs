using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Boligrafos;

namespace Ejercicio17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio NRO 17";
            Boligrafo azul = new Boligrafo();
            Boligrafo rojo = new Boligrafo();
            azul.BoligrafoCreate(100, ConsoleColor.Blue);
            rojo.BoligrafoCreate(50, ConsoleColor.Red);
            int opcion, opcion2;
            short tinta;
            string opc,opc2,tin,dibujo;
            do
            {
                Console.WriteLine("1)Pintar");
                Console.WriteLine("2)Recargar");
                Console.WriteLine("3)Salir");
                opc = Console.ReadLine();
                if(int.TryParse(opc, out opcion))
                {
                    switch(opcion)
                    {
                        case 1:
                            do
                            {
                                Console.WriteLine("1)Azul");
                                Console.WriteLine("2)Rojo");
                                Console.WriteLine("3)Cancelar");
                                opc2 = Console.ReadLine();
                                if(int.TryParse(opc2, out opcion2))
                                {
                                    switch(opcion2)
                                    {
                                        case 1:
                                            Console.WriteLine("¿Cuanta tinta desea gastar?");
                                            tin = Console.ReadLine();
                                            if (short.TryParse(tin, out tinta))
                                            {
                                                if (tinta > 0)
                                                {
                                                    azul.Pintar(tinta, out dibujo);
                                                    Console.WriteLine("Se pudo dibujar: " + dibujo);
                                                    dibujo = "";
                                                    Console.WriteLine(azul.GetTinta());

                                                }
                                                else
                                                    Console.WriteLine("El valor de tinta debe ser positivo para pintar");
                                            }
                                            else
                                                Console.WriteLine("Valor de tinta invalida");
                                            break;
                                        case 2:
                                            Console.WriteLine("¿Cuanta tinta desea gastar?");
                                            tin = Console.ReadLine();
                                            if (short.TryParse(tin, out tinta))
                                            {
                                                if (tinta > 0)
                                                {
                                                    rojo.Pintar(tinta, out dibujo);
                                                    Console.WriteLine("Se pudo dibujar: " + dibujo);
                                                    dibujo = "";
                                                    Console.WriteLine(rojo.GetTinta());
                                                }
                                                else
                                                    Console.WriteLine("El valor de tinta debe ser positivo para pintar");
                                            }
                                            else
                                                Console.WriteLine("Valor de tinta invalida");
                                            break;
                                        case 3:
                                            break;
                                        default:
                                            opcion2 = 4;
                                            break;
                                    }
                                }
                            } while (opcion2 != 3);
                            break;
                        case 2:
                            do
                            {
                                Console.WriteLine("1)Recargar azul.");
                                Console.WriteLine("2)Recargar rojo.");
                                Console.WriteLine("3)Cancelar.");
                                opc2 = Console.ReadLine();
                                if(int.TryParse(opc2, out opcion2))
                                {
                                    switch(opcion2)
                                    {
                                        case 1:
                                            azul.Recarga();  
                                            break;
                                        case 2:
                                            rojo.Recarga();
                                            break;
                                        case 3:
                                            break;
                                        default:
                                            opcion2 = 4;
                                            break;
                                    }
                                }
                            } while (opcion2 != 3);
                                break;
                        case 3:
                            break;
                        default:
                            opcion = 4;
                            break;
                    }
                }
            } while (opcion != 3);
        }
    }
}
