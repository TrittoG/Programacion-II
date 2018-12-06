using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio69
{
    public partial class frmPrincipal : Form
    {
        public delegate void Delegado(string nombre);
        public event Delegado Evento;
        frmDelegado delegado;
        frmDato dato;

        public frmPrincipal()
        {
            InitializeComponent();
            dato = new frmDato();
            delegado = new frmDelegado();
            delegado.Owner = this;
            delegado.MdiParent = this;
            dato.Owner = this;
            dato.MdiParent = this;
            delegado.Evento += dato.ActualizarNombre;
        }

        private void testDelegadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            delegado.Show();
        }

        private void mostrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dato.Show();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
