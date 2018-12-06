using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Ejercicio63
{
    public partial class Form1 : Form
    {
        Thread t;
        public Form1()
        {
            InitializeComponent();
            t = new Thread(Metodo);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            t.Start();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Metodo()
        {
            while (1 != 0)
            {
                Thread.Sleep(1000);
                if (this.label1.InvokeRequired)
                {
                    this.label1.BeginInvoke((MethodInvoker)delegate ()
                    {
                        this.label1.Text = Horario.AsignarHora();
                    }
                    );
                }
                else
                {
                    this.label1.Text = Horario.AsignarHora();
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (t.IsAlive)
                t.Abort();
        }
    }
}
