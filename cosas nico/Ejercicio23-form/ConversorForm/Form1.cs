using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Moneda;
using Billetes;

namespace ConversorForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double d;
            if(double.TryParse(textBox1.Text, out d))
            {
                Pesos p = new Pesos(d);
                textBox4.Text = string.Format("{0,10:#,###.00}", p.GetCantidad());
                textBox7.Text = string.Format("{0,10:#,###.00}",((Dolares)p).GetCantidad());
                textBox10.Text = string.Format("{0,10:#,###.00}",((Euros)p).GetCantidad());

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double d;
            if (double.TryParse(textBox2.Text, out d))
            {
                Dolares p = new Dolares(d);
                textBox12.Text = string.Format("{0,10:#,###.00}", p.GetCantidad());
                textBox5.Text = string.Format("{0,10:#,###.00}", ((Pesos)p).GetCantidad());
                textBox9.Text = string.Format("{0,10:#,###.00}", ((Euros)p).GetCantidad());

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double d;
            if (double.TryParse(textBox3.Text, out d))
            {
                Euros p = new Euros(d);
                textBox8.Text = string.Format("{0,10:#,###.00}", p.GetCantidad());
                textBox6.Text = string.Format("{0,10:#,###.00}", ((Pesos)p).GetCantidad());
                textBox11.Text = string.Format("{0,10:#,###.00}", ((Dolares)p).GetCantidad());

            }
        }
    }
}
