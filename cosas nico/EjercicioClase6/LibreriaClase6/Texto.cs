using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaClase6
{
    public class Texto
    {
        string texto;

        public Texto()
        {
            this.texto = "";
        }

        public Texto(string txt)
        {
            this.texto = txt;
        }

        public string CantPalabras()
        {
            double palabras = 0;
            double palabrasLA = 0;
            this.texto.Trim();
            foreach(string s in this.texto.Split(' '))
            {
                if (!string.IsNullOrEmpty(s))
                    palabras++;
                if (s.Length >= 2)
                    if (s.ToLower().LastIndexOf("la") == s.Length - 2)
                        palabrasLA++;
            }
            return string.Format("{0}, {1}", palabras, palabrasLA);
        }
    }
}
