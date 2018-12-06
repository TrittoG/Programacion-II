using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio37;

namespace Ejercicio65
{
    public static class Simulador
    {
        static int id;


        public static void SimuladorCentralita(object c)
        {
            while (1 != 0)
            {
                System.Threading.Thread.Sleep(new Random().Next(500, 3000));
                id++;
                if (new Random().Next(0, 2) == 0)
                {
                    ((Centralita)c).listaDeLlamadas.Add(new Provincial("origen" + id, Franja.Franja_1, new Random().Next(1, 50), "destino" + id));
                }
                else
                    ((Centralita)c).listaDeLlamadas.Add(new Local("origen" + id, new Random().Next(1, 50), "destino" + id, new Random().Next(1, 5)));
            }
        }
    }
}
