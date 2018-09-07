using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practicaForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int cont = 0;

        private void button2_Click(object sender, EventArgs e)
        {
            label3.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label3.Text = label3.Text + "*";

            cont = cont + 1;
            textBox2.Text = "" + cont;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
