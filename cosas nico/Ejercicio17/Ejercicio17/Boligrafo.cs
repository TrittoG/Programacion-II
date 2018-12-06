using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boligrafos
{
    public class Boligrafo
    {
        private ConsoleColor color;
        private short tinta;
        const short cantidadTintaMaxima = 100;

        public ConsoleColor GetColor()
        {
            return this.color;
        }

        public short GetTinta()
        {
            return this.tinta;
        }

        private void SetTinta(short tinta)
        {
            if (tinta < 0)
            {
                if (this.tinta - tinta >= 0)
                    this.tinta = (short)(this.tinta + tinta);
                else
                    this.tinta = 0;
            }
            else if (tinta > 0)
            {
                if (this.tinta + tinta <= cantidadTintaMaxima)
                    this.tinta = (short)(this.tinta - tinta);
                else
                    this.tinta = 100;
            }
        }

        public void Recarga()
        {
            this.SetTinta(100);
        }

        public void Pintar(int gasto, out string dibujo)
        {
            short i;
            dibujo = "";
            if (gasto >= this.tinta)
            {
                if (this.tinta > 0)
                {
                    for (i = 0; i < tinta; i++)
                        dibujo = dibujo + "*";
                    dibujo = dibujo + "(" + i + ")";
                    short desc = (short)(-this.tinta);
                    this.SetTinta(desc);
                }
                else
                {
                    dibujo = dibujo + "(" + 0 + ")";
                }
            }
            else if (gasto < this.tinta)
            {
                if (tinta > 0)
                {
                    for (i = 0; i < gasto; i++)
                        dibujo = dibujo + "*";
                    dibujo = dibujo + "(" + i + ")";
                    short desc = (short)(0 - i);
                    this.SetTinta(desc);
                }else
                {
                    dibujo = dibujo + "(" + 0 + ")";
                }
            }
        }

        public void BoligrafoCreate(short tinta, ConsoleColor color)
        {
            
            if (tinta > 100)
                this.tinta = 100;
            else if (tinta < 0)
                this.tinta = 0;
            else
                this.tinta = tinta;
            this.color = color;
            
        }
    }
}
