using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
	public class Factura :Documento
	{
        public Factura() :this(0)
        { }

		public Factura(int numero)	:base(numero)
		{ }

		public string Mostrar()
		{
			return this.Numero.ToString();
		}
	}
}
