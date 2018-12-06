using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Ejercicio63
{
    static class Horario
    {
        public static string AsignarHora()
        {
            return DateTime.Now.ToLongTimeString();
        }
    }
}
