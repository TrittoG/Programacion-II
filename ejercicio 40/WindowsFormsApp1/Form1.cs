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
            c = new Centralita("NICO");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("salir?", "salir", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Llamador lam = new Llamador(c);

            lam.Show();         


        }

        private void button2_Click(object sender, EventArgs e)
        {
            FacturacionTotal fatuTotal = new FacturacionTotal(c);

            fatuTotal.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FacturacionLocal factuLical = new FacturacionLocal(c);

            factuLical.Show();
        }
    }
}
