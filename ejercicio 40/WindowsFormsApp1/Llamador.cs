using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ejercicio_40;

namespace WindowsFormsApp1
{
    public partial class Llamador : Form
    {
        Centralita cen;
       
        Provincial provin;
        Local loca;
        Franja franjas;

        public Llamador(Centralita c)
        {
            InitializeComponent();
            cen = c;
        }

        public Centralita centra
        {
            get
            {
                return cen;
            }
        }
            
        

        private void Llamador_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = Enum.GetValues(typeof(Franja));




        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 3;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 4;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 5;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 6;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 7;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 8;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 9;
        }

        private void button0_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 0;
        }

        private void buttonAsterisco_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + '*';
        }

        private void buttonNumeral_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + '#' ;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            Enum.TryParse<Franja>(comboBox1.SelectedValue.ToString(), out franjas);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (this.Text == "#")
            {
                comboBox1.Enabled = false;
            }
        }

        private void buttonLlamar_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            

            if(textBox1.Text.Contains('#'))
            {
                provin = new Provincial(textBox2.Text, franjas,rnd.Next(1,50), textBox1.Text);
                cen = cen+provin;
            }
            else
            {

                loca = new Local(textBox2.Text, rnd.Next(1, 50), textBox1.Text, rnd.Next(0, 6));
                cen = cen+loca;
            }


        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
