using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClase17
{
    public class MiLista<T> : IEnumerable<T>
    {
        private T[] list;
        private int tamaño;

        public MiLista()
        {
            this.tamaño = 0;
        }

        public void Add(T a)
        {
            if (list is null)
            {
                list = new T[1];
                list[tamaño] = a;
                tamaño++;
            } 
            else
            {
                Array.Resize<T>(ref list, tamaño + 1);
                list[tamaño] = a;
                tamaño++;
            }
        }

        public void Remove(T a)
        {
            for(int i = 0; i < tamaño; i++)
            {
                if(list[i].Equals(a))
                {
                    list[i] = default(T);
                    Acomodar(this, i);
                    tamaño--;
                }
            }
        }
        public static void Acomodar(MiLista<T> a, int i)
        {
            for(int b = i; b < a.Count; b++)
            {
                a.list[i] = a.list[i + 1];
            }
        }

        public int Count
        {
            get
            {
                return tamaño;
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (T item in this.list)
            {
                yield return item;
            }
        }

         System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            for (int index = 0; index < this.list.Length; index++)
            {
                yield return this.list[index];
            }
        }

    }
}
