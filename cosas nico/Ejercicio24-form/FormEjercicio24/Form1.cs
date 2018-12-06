using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ejercicio24;

namespace FormEjercicio24
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

        private void button3_Click(object sender, EventArgs e)
        {
            double d;
            if (double.TryParse(textBox3.Text, out d))
            {
                Celsius f = d;
                textBox12.Text = string.Format("{0,10:#,###0.00}", f.GetTemp());
                textBox6.Text = string.Format("{0,10:#,###0.00}", ((Fahrenheit)f).GetTemp());
                textBox9.Text = string.Format("{0,10:#,###0.00}", ((Kelvin)f).GetTemp());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double d;
            if(double.TryParse(textBox1.Text, out d))
            {
                Fahrenheit f = d;
                textBox4.Text = string.Format("{0,10:#,###0.00}", f.GetTemp());
                textBox7.Text = string.Format("{0,10:#,###0.00}", ((Kelvin)f).GetTemp());
                textBox10.Text = string.Format("{0,10:#,###0.00}", ((Celsius)f).GetTemp());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double d;
            if (double.TryParse(textBox2.Text, out d))
            {
                Kelvin f = d;
                textBox8.Text = string.Format("{0,10:#,###0.00}", f.GetTemp());
                textBox5.Text = string.Format("{0,10:#,###0.00}", ((Fahrenheit)f).GetTemp());
                textBox11.Text = string.Format("{0,10:#,###0.00}", ((Celsius)f).GetTemp());
            }
        }
    }
}
