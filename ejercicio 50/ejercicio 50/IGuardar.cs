using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_50
{
    public interface IGuardar<T,V>
    {
        V Leer();
        bool Guardar(T obj);
       
    }
}
