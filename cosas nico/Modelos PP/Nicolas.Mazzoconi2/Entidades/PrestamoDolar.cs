using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class PrestamoDolar :Prestamo
    {
        #region Variables
        private PeriodicidadDePagos periodicidad;
        #endregion

        #region Constructores
        public PrestamoDolar(float monto, DateTime vencimiento, PeriodicidadDePagos periodicidad)   :base(monto, vencimiento)
        {
            this.periodicidad = periodicidad;
        }

        public PrestamoDolar(Prestamo prestamo, PeriodicidadDePagos periodicidad)   :this(prestamo.Monto, prestamo.Vencimiento, periodicidad)
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
        public PeriodicidadDePagos Periodicidad
        {
            get
            {
                return periodicidad;
            }
        }
        #endregion

        #region Metodos
        private float CalcularInteres()
        {
            switch(Periodicidad)
            {
                case PeriodicidadDePagos.Bimestral:
                    return (float)(Monto * 1.25);
                case PeriodicidadDePagos.Mensual:
                    return (float)(Monto * 1.35);
                default:
                    return (float)(Monto * 1.40); 
            }
        }

        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("{0}, Periodicidad: {1}, Interes: {2}\n", base.Mostrar(), Periodicidad, Interes);
            return sb.ToString();
        }

        public override void ExtenderPlazo(DateTime nuevoVencimiento)
        {
            DateTime viejito = base.Vencimiento;
            base.Vencimiento = nuevoVencimiento;
            TimeSpan dif = base.Vencimiento.Subtract(viejito);
            if(dif.Days > 0)
                base.monto = (float)(base.Monto + (2.5 * dif.Days));
        }
        #endregion
    }
}
