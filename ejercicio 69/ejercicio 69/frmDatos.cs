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
    public partial class frmDatos : Form
    {
        public frmDatos()
        {
            InitializeComponent();
        }

        private void frmDatos_Load(object sender, EventArgs e)
        {

        }

        public void ActualizarNombre(string str)
        {
            label1.Text = str;
        }

        public void ActualizarFoto(string str)
        {
            pictureBox1.ImageLocation = str;
        }
    }
}
