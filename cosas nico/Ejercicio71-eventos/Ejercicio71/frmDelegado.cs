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
    public partial class frmDelegado : Form
    {
        public delegate void Delegado(string nombre, string path);
        public event Delegado Evento;
        OpenFileDialog ofd;

        public frmDelegado()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Evento.Invoke(textBox1.Text, ofd.FileName);
        }

        private void frmDelegado_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ofd = new OpenFileDialog();
            ofd.InitialDirectory = "C:\\Users\\Public\\Pictures\\Sample Pictures";
            ofd.ShowDialog();
        }
    }
}
