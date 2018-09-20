using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_33
{
    class Libro
    {
        List<string> paginas = new List<string>();

        //indexador
        public string this[int i]
        {
            get
            {
                if (this.paginas.Count > i)
                    return paginas[i];
                return "nope";
            }
            set
            {
                if (this.paginas.Count > i)
                    this.paginas[i] = value;
                else
                {
                    this.paginas.Add(value);
                }
            }
        }
    }
}
