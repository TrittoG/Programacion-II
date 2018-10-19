using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_50
{
    public class GuardarTexto<T,V> : IGuardar<T,V>
    {
        public bool Guardar(T ojb)
        {
            return true;
        }

        public V Leer()
        {
            V v = (V)Convert.ChangeType("Texto leido", typeof(V));
            return v;
        }
    }
}
