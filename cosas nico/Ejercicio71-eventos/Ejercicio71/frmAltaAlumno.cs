using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Ejercicio71
{
    public partial class frmAltaAlumno : Form
    {
        public delegate void DelegadoAl(Alumno a);
        public event DelegadoAl EventoAl;

        public frmAltaAlumno()
        {
            InitializeComponent();
        }

        private void frmAltaAlumno_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            textBox4.Text = ofd.FileName;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox3.Text, out int d))
            {
                Alumno al = new Alumno(textBox1.Text, textBox2.Text, textBox4.Text, d);
                EventoAl.Invoke(al);
            }
            else
            {
                MessageBox.Show("DNI invalido");
            }
        }

        private void frmAltaAlumno_Load(object sender, EventArgs e)
        {

        }
    }
}
