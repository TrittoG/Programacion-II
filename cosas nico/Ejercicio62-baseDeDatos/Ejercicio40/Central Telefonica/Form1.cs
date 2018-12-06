using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ejercicio40;

namespace Central_Telefonica
{
    public partial class Form1 : Form
    {
        ProvincialDAO provincialDAO;
        private Centralita c;

        public Form1()
        {
            InitializeComponent();
            this.c = new Centralita("Central de Nico");
            provincialDAO = new ProvincialDAO();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea Salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*Local l1 = new Local("Bernal", 30, "Rosario", 2.65f);
            Provincial l2 = new Provincial("Morón", Franja.Franja_1, 21, "Bernal");
            Local l3 = new Local("Lanús", 45, "San Rafael", 1.99f);
            Provincial l4 = new Provincial(l2, Franja.Franja_3);
            // Las llamadas se irán registrando en la Centralita.
            // La centralita mostrará por pantalla todas las llamadas según las vaya registrando.
            c = c + l4;
            //  Console.WriteLine(c.Mostrar());
            c = c + l3;
            //  Console.WriteLine(c.Mostrar());
            c = c + l2;
            //  Console.WriteLine(c.Mostrar());
            c = c + l1;
            //Console.WriteLine(c.Mostrar());
            c.OrdenarLlamadas();*/
            provincialDAO.Leer(c);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GnrLlamada newLlamada = new GnrLlamada(c);
            newLlamada.Show();   
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmMostrar newMostrar = new frmMostrar(c, 0);
            newMostrar.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmMostrar newMostrar = new frmMostrar(c, 1);
            newMostrar.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmMostrar newMostrar = new frmMostrar(c, -1);
            newMostrar.Show();
        }
    }
}
