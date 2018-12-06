using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class PrestamoPesos: Prestamo
    {
        #region Variables
        private float porcentajeInteres;
        #endregion

        #region Constructores
        public PrestamoPesos(float monto, DateTime vencimiento, float interes) : base(monto, vencimiento)
        {
            this.porcentajeInteres = interes;
        }

        public PrestamoPesos(Prestamo prestamo, float interes) : this(prestamo.Monto, prestamo.Vencimiento, interes)
        { }
        #endregion

        #region Propiedades
        public float Interes
        {
            get
            {
                return CalcularInteres();
            }
        }
        #endregion

        #region Metodos

        private float CalcularInteres()
        {
            return base.Monto * (this.porcentajeInteres / 100 + 1);
        }

        public override void ExtenderPlazo(DateTime nuevoVencimiento)
        {
            DateTime viejito = base.Vencimiento;
            base.Vencimiento = nuevoVencimiento;
            TimeSpan dias = base.Vencimiento.Subtract(viejito);
            if(dias.Days > 0)
                this.porcentajeInteres = (float)(dias.Days * 1.025) + this.porcentajeInteres;
        }

        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("{0}, Porcentaje Interes: {1}, Interes Monto: {2}\n", base.Mostrar(), this.porcentajeInteres, Interes);
            return sb.ToString();
        }
        #endregion
    }
}
