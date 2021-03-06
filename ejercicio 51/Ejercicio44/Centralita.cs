﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio44
{
	public class Centralita : IGuardar<String>
	{
		public List<Llamada> listaDeLlamadas;
		protected string razonSocial;
		
		private Centralita()
		{
			this.listaDeLlamadas = new List<Llamada>();
		}

		public Centralita(string razonSocial)	:this()
		{
			this.razonSocial = razonSocial;
		}


        public string RazonSocial
        {
            get
            {
                return razonSocial;
            }
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

		private float CalcularGanancias(TipoLlamada tipo)
		{
			float ganancias = 0;
			foreach(Llamada l in listaDeLlamadas)
			{
				if((l is Local && tipo == TipoLlamada.Local) || (tipo == TipoLlamada.Todas && l is Local))
				{
					ganancias = ganancias + ((Local)l).CostoLlamada;
				}

				if((l is Provincial && tipo == TipoLlamada.Provincial) || (tipo == TipoLlamada.Todas && l is Provincial))
				{
					ganancias = ganancias + ((Provincial)l).CostoLlamada;
				}
			}
			return ganancias;
		}

		protected string Mostrar()
		{
			string dato = "";
            int n = 0;
			foreach(Llamada l in this.listaDeLlamadas)
			{
				if (l is Local)
					dato = dato + "\n\nLlamada "+n+": " + ((Local)l).ToString();
				else
					dato = dato + "\n\nLlamada "+n+": " + ((Provincial)l).ToString();
                n++;
			}
			return "Razon social: " + this.razonSocial + ", ganacia local: " + this.GananciasPorLocal + ", ganancia provincial: " + this.GananciasPorProvincial
				+ ", ganancia total: " + this.GananciasPorTotal + dato;
		}

		public void OrdenarLlamadas()
		{
			this.listaDeLlamadas.Sort(Llamada.OrdenarPorDuracion);
		}

		public List<Llamada> Llamadas
		{
			get
			{
				return this.listaDeLlamadas;
			}
		}

        public string RutaDeArchivo { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override string ToString()
        {
            return Mostrar();
        }

        private void AgregarLlamada(Llamada llamadaNueva)
        {
            this.listaDeLlamadas.Add(llamadaNueva);
        }

        public bool Guardar()
        {
            StringBuilder st = new StringBuilder();
            st.AppendLine(this.RazonSocial);
            st.AppendLine(this.RutaDeArchivo);
            st.AppendLine(this.GananciasPorLocal.ToString());
            st.AppendLine(this.GananciasPorProvincial.ToString());
            st.AppendLine(this.GananciasPorTotal.ToString());

            return true;
        }

        public string Leer()
        {
            throw new NotImplementedException();
        }

        public static bool operator ==(Centralita c, Llamada l)
        {
            foreach(Llamada s in c.listaDeLlamadas)
            {
                if (s == l)
                    return true;
            }
            return false;
        }

        public static bool operator !=(Centralita c, Llamada l)
        {
            return !(c == l);
        }

        public static Centralita operator +(Centralita c, Llamada l)
        {
            if (c == l)
            {
                throw new CentralitaException("La llamada se encuentra registrada", "Centralita", "Operador +");
            }
            else
            {
                c.AgregarLlamada(l);
                return c;
            }
        }
    }
}
