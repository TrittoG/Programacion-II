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

namespace ejercicio_63
{
    public partial class Form1 : Form
    {
        Thread t;

        public Form1()
        {
            InitializeComponent();
            t = new Thread(MetodoTimer);
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           // label1.Text = Hora.AsignarHora().ToString();
        }

        private void MetodoTimer()
        {
            while(true)
            {
                Thread.Sleep(1000);
                if (this.label1.InvokeRequired)
                {
                    this.label1.BeginInvoke((MethodInvoker)delegate ()
                    {
                        label1.Text = Hora.AsignarHora().ToString();
                        label1.Refresh();
                    }
                    );
                }
                else
                {
                    label1.Text = Hora.AsignarHora().ToString();
                    label1.Refresh();
                }



                
            }
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            t.Start();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(t.IsAlive)
            {
                t.Abort();
            }
        }
    }
}
