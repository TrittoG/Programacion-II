using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio25
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NumeroBinario bin = bTod.Text;

            
            textBox3.Text = string.Format("{0}",Conversor.BinarioDecimal(bin.getNumero()));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NumeroDecimal dec = int.Parse(dTob.Text);

            textBox4.Text = Conversor.DecimalBinario(dec.getNumero());
        }

      
    }
}
