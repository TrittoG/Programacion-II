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
    public partial class Form1 : Form
    {
        Centralita c;

        public Form1()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("salir?", "salir", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                this.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
