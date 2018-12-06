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
    public partial class frmDato : Form
    {
        public frmDato()
        {
            InitializeComponent();
        }

        private void frmDato_Load(object sender, EventArgs e)
        {

        }

        public void ActualizarNombre(string nombre)
        {
            label1.Text = nombre;
        }
    }
}
