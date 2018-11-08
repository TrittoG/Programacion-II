using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio_60
{
    public partial class Agregar : Form
    {
        SQLConection cone;

        public Agregar(SQLConection cone)
        {
            InitializeComponent();
            this.cone = cone;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Producto p = new Producto(textBox1.Text,textBox2.Text, "2");
            cone.Agregar(p);
            this.Close();
        }
    }
}
