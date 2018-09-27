﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_40
{
    public class Centralita
    {
        private List<Llamada> listaDeLlamadas;
        protected string razonSocial;

        public Centralita()
        {
            this.listaDeLlamadas = new List<Llamada>();
        }

        public Centralita(string nombreEmpresa) : this()
        {
            razonSocial = nombreEmpresa;
        }


        private float CalcularGanancias(TipoLlamada tipo)
        {
            float gananciasLocal = 0;
            float gananciasProvin = 0;
            float gananciaTotal = 0;

            foreach(Llamada llam in listaDeLlamadas)
            {
                    if(llam is Local)
                    {
                        gananciasLocal = gananciasLocal + ((Local)llam).CostoLlamada;
                    }
                    else if (llam is Provincial)
                    {
                        gananciasProvin = gananciasProvin + ((Provincial)llam).CostoLlamada;
                    }                                  
            }

            if (tipo == TipoLlamada.Local)
            {
                return gananciasLocal;
            }
            else if (tipo == TipoLlamada.Provincial)
            {
                return gananciasProvin;
            }
            else if(tipo == TipoLlamada.Todas)
            {
                gananciaTotal =  gananciasProvin + gananciasLocal;
                return gananciaTotal;
            }

            return 0;
        }


        public float GananciasPorLocal
        {
            get
            {
                return CalcularGanancias(TipoLlamada.Local);
            }
        }

        public float GananciasPorProvincial
        {
            get
            {
                return CalcularGanancias(TipoLlamada.Provincial);
            }
        }

        public float GananciasPorTotal
        {
            get
            {
                return CalcularGanancias(TipoLlamada.Todas);
            }
        }

        public List<Llamada> Llamadas
        {
            get
            {
                return this.listaDeLlamadas;
            }
        }

        public override string ToString()
        {
            return Mostrar();
        }

        private string Mostrar()
        {

            


            StringBuilder nuevoString = new StringBuilder();


            nuevoString.AppendLine("razon social: "+this.razonSocial);
            nuevoString.AppendLine("ganancias totales: "+GananciasPorTotal.ToString());
            nuevoString.AppendLine("ganancias por llamadas Locales: " +GananciasPorLocal.ToString());
            nuevoString.AppendLine("ganancias por llamadas provinciales: "+GananciasPorProvincial.ToString());

            foreach(Llamada l in listaDeLlamadas)
            {
                nuevoString.AppendLine(l.ToString());
            }


            return nuevoString.ToString();
        }

        public void OrdenarLlamadas()
        {
            listaDeLlamadas.Sort(Llamada.OrdenarPorDuracion);
        }

        private void AgregarLlamada(Llamada nuevaLlamada)
        {
            listaDeLlamadas.Add(nuevaLlamada);
        }

        public static bool operator ==(Centralita c, Llamada l)
        {
            foreach(Llamada llam in c.listaDeLlamadas)
            {
                if(llam == l)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator !=(Centralita c, Llamada l)
        {
            return !(c == l);
        }

        public static Centralita operator +(Centralita c, Llamada nuevaLlamada)
        {
            if(c != nuevaLlamada)
            {
                 c.AgregarLlamada(nuevaLlamada);
                
            }
            return c;
        }
    }
}
