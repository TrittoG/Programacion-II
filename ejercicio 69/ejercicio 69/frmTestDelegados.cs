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
    public partial class frmTestDelegados : Form
    {
        public delegate void Delegado(string str);

        public event Delegado Evento;
        public event Delegado Evento2;

        private string path;


        public frmTestDelegados()
        {
            InitializeComponent();

            
            openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);

        }

        private void frmTestDelegados_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Evento.Invoke(textBox1.Text);
            Evento2.Invoke(path);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            this.path = openFileDialog1.FileName;
        }
    }
}
