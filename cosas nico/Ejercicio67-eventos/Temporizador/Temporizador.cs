using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace _Temporizador
{
    public delegate void encargadoTiempo();

    public sealed class Temporizador
    {
        Thread hilo;
        int intervalo;

        public bool Activo
        {
            get
            {
                return hilo.IsAlive;
            }
            set
            {
                if (value == true)
                { 
                    if (hilo != null && hilo.IsAlive)
                        hilo.Abort();
                    hilo = new Thread(Corriendo);
                    hilo.Start();
                }
                else if (value == false && hilo.IsAlive)
                    hilo.Abort();
            }
        }

        public int Intervalo
        {
            get
            {
                return intervalo;
            }

            set
            {
                intervalo = value;
            }
        }

        private void Corriendo()
        {
            while(true)
            {
                Thread.Sleep(intervalo);
                EventTiempo.Invoke();
            }
        }

        public event encargadoTiempo EventTiempo;
    }
}
