using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio16
{
    class Alumno
    {
        private byte _nota1; //atributos
        private byte _nota2;
        private float _notaFinal;
        public string apellido;
        public int legajo;
        public string nombre;

        public void CalcularFinal()
        {
            if(this._nota1 >= 4 && this._nota2 >= 4)
            {
                Random asd = new Random();
                this._notaFinal = asd.Next(0,10);
            }
            else
            {
                this._notaFinal = -1;
            }

        }

        public void Estudiar(byte notaUno, byte notaDos) //metodos
        {
            this._nota1 = notaUno;
            this._nota2 = notaDos;
        }

        public string Mostrar()
        {
            if (this._notaFinal != -1)
                return this._nota1 + "," + this._nota2 + "," + this._notaFinal + "," + this.nombre + "," + this.apellido + "," + this.legajo;
            else
                return "alumno desaprobado";
        }
    }
}
