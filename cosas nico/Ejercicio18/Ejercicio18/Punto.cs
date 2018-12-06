using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    class Punto
    {
        private int y;
        private int x;
        public int GetY()
        {
            return this.y;
        }
        public int GetX()
        {
            return this.x;
        }
        public Punto(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
}
