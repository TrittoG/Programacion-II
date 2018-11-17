using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ejercicio_67
{
    public sealed class Temporizador
    {
        private Thread hilo;
        private int intervalo;

        //
        public delegate void encargadoTiempo();

        public event encargadoTiempo EventoTiempo;

        public bool Activo
        {
            get
            {
                return hilo.IsAlive;
            }
            set
            {
                if (value == true )
                {
                    if(hilo != null && hilo.IsAlive)
                    {
                        hilo.Abort();
                    }
                    hilo = new Thread(Corriendo);
                    hilo.Start();
                }                  
                else if(value == false && hilo.IsAlive)
                {
                    hilo.Abort();
                }               
            }                           
        }

        public int Intervalo
        {
            get
            {
                return this.intervalo;
            }
            set
            {
                this.intervalo = value;
            }
        }

        private void Corriendo()
        {
            while(true)
            {
                Thread.Sleep(this.intervalo);
                EventoTiempo.Invoke();
            }

            
        }
    }
}
