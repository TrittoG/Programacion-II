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

        public void ActualizarNombre(string nombre, string path)
        {
            label1.Text = nombre;
            pictureBox1.ImageLocation = path;
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
