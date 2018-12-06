using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio50
{
    public class Serializar<S, V> : IGuardar<S, V>
    {
        bool IGuardar<S,V>.Guardar(S obj)
        {
            return true;
        }

        V IGuardar<S,V>.Leer()
        {
            return (V)Convert.ChangeType("Objeto leido", typeof(V));
        }
    }
}
