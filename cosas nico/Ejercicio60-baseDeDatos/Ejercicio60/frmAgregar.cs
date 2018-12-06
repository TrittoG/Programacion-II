using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio60
{
    public partial class frmAgregar : Form
    {
        private SqlConexion conexion;
        public frmAgregar(SqlConexion con)
        {
            InitializeComponent();
            conexion = con;
        }

        private void frmAgregar_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Producto prueba = new Producto(textBox1.Text, textBox2.Text, "0");
            conexion.Agregar(prueba);
            this.Close();
        }
    }
}
