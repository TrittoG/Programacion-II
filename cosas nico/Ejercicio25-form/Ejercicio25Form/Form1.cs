using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ejercicio25;

namespace Ejercicio25Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btonBinDec_Click(object sender, EventArgs e)
        {
            NumeroBinario nb = txtBin.Text;
            txtBinDec.Text = string.Format("{0}",Conversor.BinarioDecimal(nb.GetNumero()));
        }

        private void btonDecBin_Click(object sender, EventArgs e)
        {
            double d;
            if(double.TryParse(txtDec.Text, out d))
            {
                NumeroDecimal nd = d;
                txtDecBin.Text = string.Format("{0}", Conversor.DecimalBinario(nd.GetNumero()));
            }
        }
    }
}
