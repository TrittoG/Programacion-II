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
    public partial class frmMostrar : Form
    {
        Centralita ll;
        int obj;
        public frmMostrar(Centralita c)
        {
            InitializeComponent();
            this.ll = c;
        }

        public frmMostrar(Centralita c, int type)    :this(c)
        {
            obj = type;
        }

        private void frmMostrar_Load(object sender, EventArgs e)
        {
            if (obj == 0)
                richTextBox1.Text = ll.ToString();
            else
            {
                richTextBox1.Text = "Razon social: " + ll.RazonSocial + ", ganacia local: " + ll.GananciasPorLocal + ", ganancia provincial: " + ll.GananciasPorProvincial
                + ", ganancia total: " + ll.GananciasPorTotal;
                if (obj == 1)
                {
                    foreach(Llamada l in ll.listaDeLlamadas)
                    {
                        if (l is Local)
                            richTextBox1.Text = richTextBox1.Text + "\n\n" + l.ToString();
                    }
                }
                else
                    foreach (Llamada l in ll.listaDeLlamadas)
                    {
                        if (l is Provincial)
                            richTextBox1.Text = richTextBox1.Text + "\n" + l.ToString();
                    }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea Salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                this.Close();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
