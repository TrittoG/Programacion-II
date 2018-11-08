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
    public partial class Borrar : Form
    {
        SQLConection cone;

        public Borrar(SQLConection con)
        {
            InitializeComponent();
            this.cone = con;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id;

            id = textBox1.Text;

            foreach(Producto p in cone.Mostrar())
            {
                if(p.Id == id)
                {
                    cone.Borrar(p);
                }
            }

            this.Close();
        }
    }
}
