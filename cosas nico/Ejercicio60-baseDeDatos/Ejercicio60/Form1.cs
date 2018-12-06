using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Ejercicio60
{
    public partial class Form1 : Form
    {
        private SqlConexion conexion;
        Producto seleccionado;
        string tabla;
        public Form1()
        {
            InitializeComponent();
            conexion = new SqlConexion();
            seleccionado = null;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Producto> productos = conexion.Mostrar("Production.Product");
            listView1.Items.Clear();
            tabla = "Production.Product";
            foreach (Producto p in productos)
            {
                ListViewItem items = new ListViewItem(p.ID);
                items.SubItems.Add(p.Nombre);
                items.SubItems.Add(p.Serial);
                listView1.Items.Add(items);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmAgregar agr = new frmAgregar(conexion);
            agr.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            List<Producto> productos = conexion.Mostrar("Product2");
            listView1.Items.Clear();
            tabla = "Product2";
            foreach (Producto p in productos)
            {
                ListViewItem items = new ListViewItem(p.ID);
                items.SubItems.Add(p.Nombre);
                items.SubItems.Add(p.Serial);
                listView1.Items.Add(items);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmModificar mod = new frmModificar(conexion, seleccionado, tabla);
            mod.Show();
        }

        private void listView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if(listView1.SelectedItems.Count > 0)
            {
                seleccionado = new Producto(listView1.SelectedItems[0].SubItems[1].Text, listView1.SelectedItems[0].SubItems[2].Text, listView1.SelectedItems[0].SubItems[0].Text);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            conexion.Borrar(seleccionado, tabla);
        }
    }
}
