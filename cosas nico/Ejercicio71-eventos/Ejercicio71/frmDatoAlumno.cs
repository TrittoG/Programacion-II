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
    public partial class frmDatoAlumno : frmAltaAlumno
    {
        public frmDatoAlumno()
        {
            InitializeComponent();
        }

        private void frmDatoAlumno_Load(object sender, EventArgs e)
        {
            button1.Enabled = false;
        }

        public void ActualizarAlumno(Alumno a)
        {
            pictureBox1.ImageLocation = a.FotoAlumno;
            textBox1.Text = a.Nombre;
            textBox2.Text = a.Apellido;
            textBox3.Text = a.Dni.ToString();
            textBox4.Text = a.FotoAlumno;
        }

    }
}
