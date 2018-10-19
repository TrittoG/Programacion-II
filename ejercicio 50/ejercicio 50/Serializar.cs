using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_50
{
    class Serializar<S,V> : IGuardar<S,V>
    {
        public bool Guardar(S obj)
        {
            return true;
        }

        public V Leer()
        {
            V v = (V)Convert.ChangeType("Objeto leido", typeof(V));
            return v;
        }
    }
}
