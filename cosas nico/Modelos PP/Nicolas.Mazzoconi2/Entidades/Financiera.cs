using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Financiera
    {
        #region Variables
        private List<Prestamo> listaDePrestamos;
        private string razonSocial;
        #endregion

        #region Constructores
        private Financiera()
        {
            this.listaDePrestamos = new List<Prestamo>();
        }
        public Financiera(string razonSocial)   :this()
        {
            this.razonSocial = razonSocial;
        }
        #endregion

        #region Propiedades
        public float InteresesEnDolares
        {
            get
            {
                return CalcularInteresGanado(TipoDePrestamos.Dolares);
            }
        }

        public float InteresesEnPesos
        {
            get
            {
                return CalcularInteresGanado(TipoDePrestamos.Pesos);
            }
        }

        public float InteresesTotales
        {
            get
            {
                return CalcularInteresGanado(TipoDePrestamos.Todos);
            }
        }

        public List<Prestamo> ListaDePrestamos
        {
            get
            {
                return listaDePrestamos;
            }
        }

        public string RazonSocial
        {
            get
            {
                return razonSocial;
            }
        }
        #endregion

        #region Metodos
        private float CalcularInteresGanado(TipoDePrestamos tipoPrestamo)
        {
            float total = 0;
            if(tipoPrestamo == TipoDePrestamos.Dolares || tipoPrestamo == TipoDePrestamos.Todos)
                foreach(PrestamoDolar p in this.listaDePrestamos)
                    total = total + p.Interes;
            if (tipoPrestamo == TipoDePrestamos.Pesos || tipoPrestamo == TipoDePrestamos.Todos)
                foreach (PrestamoPesos p in this.listaDePrestamos)
                    total = total + p.Interes;
            return total;
        }

        public void OrdenarPrestamos()
        {
            listaDePrestamos.Sort(Prestamo.OrdenPorFecha);
        }

        public static string Mostrar(Financiera financiera)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Razon social: " + financiera.RazonSocial);
            foreach (Prestamo p in financiera.listaDePrestamos)
                sb.AppendLine(p.Mostrar());
            return sb.ToString();
        }

        public static bool operator ==(Financiera f, Prestamo p)
        {
            foreach(Prestamo n in f.listaDePrestamos)
            {
                if (n.Monto == p.Monto && n.Vencimiento == p.Vencimiento)
                    return true;
            }
            return false;
        }

        public static bool operator !=(Financiera f, Prestamo p)
        {
            return !(f == p);
        }

        public static Financiera operator +(Financiera f, Prestamo p)
        {
            if (f == p)
                return f;
            else
            {
                f.listaDePrestamos.Add(p);
                return f;
            }
        }

        public static explicit operator string(Financiera f)
        {
            return Mostrar(f);
        }
        #endregion

    }
}
