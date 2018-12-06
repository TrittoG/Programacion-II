using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio16
{
    class Alumno
    {
        private byte _nota1;
        private byte _nota2;
        private float _notaFinal;
        public string nombre;
        public string apellido;
        public int legajo;

        public void CalcularFianl()
        {
            if(this._nota1 >= 4 && this._nota2 >= 4)
            {
                Random objetoRandom = new Random();
                this._notaFinal = objetoRandom.Next(4, 10);
            }
            else
            {
                this._notaFinal = -1;
            }
        }
        public void Estudiar(byte nota1, byte nota2)
        {
            this._nota1 = nota1;
            this._nota2 = nota2;
        }
        public string Mostrar()
        {
            if(this._notaFinal != -1)
                return (this._nota1 + ","+ this._nota2 +","+ this._notaFinal +","+ this.nombre +","+ this.apellido +","+ this.legajo);
            else
                return (this._nota1 + "," + this._nota2 + "," + this.nombre + "," + this.apellido + "," + this.legajo);

        }
    }
}
