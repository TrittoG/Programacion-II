using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio37
{
	class Centralita
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

		public string Mostrar()
		{
			string dato = "";
			foreach(Llamada l in this.listaDeLlamadas)
			{
				if (l is Local)
					dato = dato + "\n" + ((Local)l).Mostrar();
				else
					dato = dato + "\n" + ((Provincial)l).Mostrar();
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
	}
}
