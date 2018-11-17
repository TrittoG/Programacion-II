using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio_69
{
    public partial class FormPrincipal : Form
    {
        frmTestDelegados formtestdel;
        frmDatos datos;
        frmAltaAlumno alta;

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void testDelegadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formtestdel = new frmTestDelegados();
            formtestdel.MdiParent = this;
            formtestdel.Show();
        }

        private void mostarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            datos = new frmDatos();


            formtestdel.Evento += datos.ActualizarNombre;
            formtestdel.Evento2 += datos.ActualizarFoto;

            datos.MdiParent = this;
            datos.Show();
        }

        private void alumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            alta = new frmAltaAlumno();
            alta.MdiParent = this;
            alta.Show();
        }
    }
}
