using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio33
{
    class Libro
    {
        private List<string> paginas = new List<string>();
        
        public string this[int i]
        {
            get
            {
                if (i < paginas.Count && i >= 0)
                    return paginas[i];
                return "";
            }
            set
            {
                if (i >= 0 && i < paginas.Count)
                {
                    paginas[i] = (value);
                }
                else
                    paginas.Add(value);
            }
        }
    }
}
