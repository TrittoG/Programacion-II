using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
	public class Contabilidad<T, U> where T : Recibo where U : Factura, new()
	{
		private List<T> egreso;
		private List<U> ingreso;

		public Contabilidad()
		{
			egreso = new List<T>();
			ingreso = new List<U>();
		}

		public static Contabilidad<T, U> operator +(Contabilidad<T, U> a, T b)
		{
			a.egreso.Add(b);
			return a;
		}

		public static Contabilidad<T, U> operator +(Contabilidad<T, U> a, U b)
		{
			a.ingreso.Add(b);
			return a;
		}

		public static string Mostrar(Contabilidad<T,U> a)
		{
			StringBuilder sb = new StringBuilder();
			sb.AppendLine("Egresos:");
			foreach (T b in a.egreso)
				sb.AppendLine("$" + b.Mostrar());
			sb.AppendLine("Ingresos:");
			foreach (U c in a.ingreso)
				sb.AppendLine("$" + c.Mostrar());

			return sb.ToString();
		}
	}
}
