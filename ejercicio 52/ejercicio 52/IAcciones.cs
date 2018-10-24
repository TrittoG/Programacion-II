using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_52
{
    interface IAcciones
    {
        EscrituraWrapper Escribir(string texto);

        bool Recargar(int unidades);

        ConsoleColor Color
        {
            get;
            set;
        }

        float UnidadesDeEscritura
        {
            get;
            set;
        }
     
    }
}
