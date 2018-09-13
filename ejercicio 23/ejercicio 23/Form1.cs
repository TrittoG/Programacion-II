using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Monedas;

namespace ejercicio_23
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtEuro_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_euro_Click(object sender, EventArgs e)
        {
            Euros eur = new Euros(double.Parse(txtEuro.Text));            
            txtEuroEuro.Text = string.Format("{0}", eur.GetCantidad());
            txtEuroDolar.Text = string.Format("{0}", ((Dolares)eur).GetCantidad());
            txtEuroPesos.Text = string.Format("{0}", ((Pesos)eur).GetCantidad());
        }

        private void btn_dolar_Click(object sender, EventArgs e)
        {
            Dolares dol = new Dolares(double.Parse(txtDolar.Text));

            txtDolarDolar.Text = string.Format("{0}", dol.GetCantidad());
            txtDolarEuro.Text = string.Format("{0}", ((Euros)dol).GetCotizacion());
            txtDolarPesos.Text = string.Format("{0}", ((Pesos)dol).GetCotizacion());

        }

        private void btn_pesos_Click(object sender, EventArgs e)
        {
            Pesos pes = new Pesos(double.Parse(txtPesos.Text));

            txtPesosPesos.Text = string.Format("{0}", pes.GetCantidad());
            txtPesosDolar.Text = string.Format("{0}", ((Dolares)pes).GetCantidad());
            txtPesosEuro.Text = string.Format("{0}", ((Euros)pes).GetCantidad());
        }
    }
}
