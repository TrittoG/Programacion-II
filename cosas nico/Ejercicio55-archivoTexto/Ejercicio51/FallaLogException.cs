using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio51
{
	public class FallaLogException	:Exception
	{
		#region Constructores
		public FallaLogException(string mensaje) : this(mensaje, null)
		{
		}

		public FallaLogException(string mensaje, Exception innerException) : base(mensaje, innerException)
		{
			
		}
		#endregion
	}
}
