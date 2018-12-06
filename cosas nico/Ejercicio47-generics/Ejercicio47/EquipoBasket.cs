using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio47
{
    public class EquipoBasket  :Equipo
    {
        public EquipoBasket(string nombre, DateTime creacion) : base(nombre, creacion)
        { }
        public EquipoBasket(string nombre) : this(nombre, DateTime.Now)
        { }
    }
}
