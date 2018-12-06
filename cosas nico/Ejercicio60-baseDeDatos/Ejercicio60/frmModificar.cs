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
    public partial class frmModificar : Form
    {
        private SqlConexion conexion;
        Producto producto;
        string tabla;
        public frmModificar(SqlConexion con, Producto seleccionado, string tabla)
        {
            InitializeComponent();
            conexion = con;
            producto = seleccionado;
            this.tabla = tabla;
        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            producto.Nombre = textBox1.Text;
            producto.Serial = textBox2.Text;
            conexion.Modificar(producto, tabla);
            this.Close();
        }

        private void frmModificar_Load(object sender, EventArgs e)
        {
            textBox1.Text = producto.Nombre;
            textBox2.Text = producto.Serial;
        }

    }
}
