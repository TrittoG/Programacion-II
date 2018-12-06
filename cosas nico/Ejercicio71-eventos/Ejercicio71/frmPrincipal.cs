using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio71
{
    public partial class frmPrincipal : Form
    {
        frmDelegado delegado;
        frmDato dato;
        frmAltaAlumno altaAlumno;
        frmDatoAlumno datoAlumno;

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void testDelegadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            delegado = new frmDelegado();
            delegado.Owner = this;
            delegado.MdiParent = this;
            if (dato != null)
                delegado.Evento += dato.ActualizarNombre;
            delegado.Show();
        }

        private void mostrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dato = new frmDato();
            dato.Owner = this;
            dato.MdiParent = this;
            if(delegado != null)
                delegado.Evento += dato.ActualizarNombre;
            dato.Show();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void alumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            altaAlumno = new frmAltaAlumno();
            altaAlumno.Owner = this;
            altaAlumno.MdiParent = this;
            if (datoAlumno != null)
                altaAlumno.EventoAl += datoAlumno.ActualizarAlumno;
            altaAlumno.Show();
        }

        private void alumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            datoAlumno = new frmDatoAlumno();
            datoAlumno.Owner = this;
            datoAlumno.MdiParent = this;
            if(altaAlumno != null)
                altaAlumno.EventoAl += datoAlumno.ActualizarAlumno;
            datoAlumno.Show();
        }
    }
}
