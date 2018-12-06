using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio47
{
    public class Torneo<T> where T : Equipo
    {
        private List<T> listaGenerica;
        private string nombre;

        private Torneo()
        {
            this.listaGenerica = new List<T>();
        }

        public Torneo(string nombre) : this()
        {
            this.nombre = nombre;
        }

        public string JugarPartido
        {
            get
            {
                Random index1 = new Random();
				int result1 = index1.Next(0, (listaGenerica.Count - 1));
				int result2 = index1.Next(0, (listaGenerica.Count - 1));
				while(result2 == result1)
				{
					System.Threading.Thread.Sleep(250);
					result2 = index1.Next(0, (listaGenerica.Count - 1));
				}
                return CalcularPartido(listaGenerica[result1], listaGenerica[result2]);
            }
        }

        private string CalcularPartido(T a, T b)
        {
            StringBuilder sb = new StringBuilder();
            Random resultado1 = new Random();
            int c = resultado1.Next(0, 4);
            System.Threading.Thread.Sleep(250);
            int d = resultado1.Next(0, 4);
            sb.AppendFormat("{0} {1}-{2} {3}", a.Nombre, c, d, b.Nombre);
            return sb.ToString();
        }
            
        public static bool operator ==(Torneo<T> t, T e)
        {
            foreach(Equipo a in t.listaGenerica)
            {
                if (a == e)
                    return true;
            }
            return false;
        }

        public static bool operator !=(Torneo<T> t, T e)
        {
            return !(t == e);
        }

        public static Torneo<T> operator +(Torneo<T> t, T e)
        {
            if (t != e)
                t.listaGenerica.Add(e);
            return t;
        }

        public static string Mostrar(Torneo<T> a)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Torneo " + a.nombre);
            foreach (Equipo e in a.listaGenerica)
                sb.AppendLine(e.Ficha());
            return sb.ToString();
        }
    }
}
