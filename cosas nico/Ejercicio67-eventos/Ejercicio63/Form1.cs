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
using _Temporizador;
namespace Ejercicio63
{
    public partial class Form1 : Form
    {
        Thread t;
        Temporizador temporizador;

        public Form1()
        {
            InitializeComponent();
            t = new Thread(Metodo);
            temporizador = new Temporizador();
            temporizador.Intervalo = 2000;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            t.Start();
            temporizador.EventTiempo += Mostrar;
            temporizador.Activo = true;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void Mostrar()
        {   
            if (this.label2.InvokeRequired)
            {
                this.label2.BeginInvoke((MethodInvoker)delegate ()
                {
                    this.label2.Text = Horario.AsignarHora();
                }
                );
            }
            else
            {
                this.label2.Text = Horario.AsignarHora();
            }
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
            if (temporizador.Activo)
                temporizador.Activo = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
