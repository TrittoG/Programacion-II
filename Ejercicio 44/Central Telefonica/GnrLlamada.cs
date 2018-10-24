using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ejercicio41;

namespace Central_Telefonica
{
    public partial class GnrLlamada : Form
    {
        Centralita cl;
        public GnrLlamada(Centralita c)
        {
            InitializeComponent();
            this.cl = c;
        }

        public Centralita MiCentralita
        {
            get
            {
                return cl;
            }
        }

        private void GnrLlamada_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = Enum.GetValues(typeof(Franja));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea Salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 1;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0 && textBox1.Text[0] != '#')
                comboBox1.Enabled = false;
            else
                comboBox1.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            comboBox1.Text = "Franja";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 2;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 3;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 4;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 5;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 6;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 7;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 8;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 9;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 0;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + '*';
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + '#';
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random duracion = new Random();
            Random costo = new Random();
            if (textBox1.Text[0] == '#')
            {
                Franja franjas;
                Enum.TryParse<Franja>(comboBox1.SelectedValue.ToString(), out franjas);
                Provincial newLlamada = new Provincial(textBox1.Text, franjas, duracion.Next(1, 50), textBox2.Text);
                try
                {
                    cl = cl + newLlamada;
                }
                catch(CentralitaException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                Local newLlamada = new Local(textBox1.Text, duracion.Next(1, 50), textBox2.Text, (float)(costo.NextDouble() * (5.6 - 0.5) + 0.5));
                try
                {
                    cl = cl + newLlamada;
                }
                catch (CentralitaException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
