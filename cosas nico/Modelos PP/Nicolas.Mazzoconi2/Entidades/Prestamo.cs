using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Prestamo
    {
        #region Variables
        protected float monto;
        protected DateTime vencimiento;
        #endregion

        #region Constructores
        public Prestamo(float monto, DateTime vencimiento)
        {
            this.monto = monto;
            Vencimiento = vencimiento;
        }
        #endregion

        #region Propiedades
        public float Monto
        {
            get
            {
                return monto;
            }
        }
        public DateTime Vencimiento
        {
            get
            {
                return vencimiento;
            }

            set
            {
                if(value > DateTime.Now)
                {
                    vencimiento = value;
                }
                else
                    vencimiento = DateTime.Now;
            }
        }
        #endregion

        #region Metodos
        public static int OrdenPorFecha(Prestamo n1, Prestamo n2)
        {
            return DateTime.Compare(n1.Vencimiento, n2.Vencimiento);
        }

        public abstract void ExtenderPlazo(DateTime nuevoVencimiento);

        public virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Monto: " + Monto + ", Vencimiento: " + Vencimiento.ToString());
            return sb.ToString();
        }
        #endregion
    }
}
