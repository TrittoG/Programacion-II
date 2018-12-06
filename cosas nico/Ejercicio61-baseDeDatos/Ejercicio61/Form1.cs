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

namespace Ejercicio61
{
    public partial class Form1 : Form
    {
        PersonaDAO conexion;
        Persona seleccionada;

        public Form1()
        {
            InitializeComponent();
            conexion = new PersonaDAO();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            foreach(Persona p in conexion.Leer())
            {
                ListViewItem item = new ListViewItem(p.ID);
                item.SubItems.Add(p.Nombre);
                item.SubItems.Add(p.Apellido);
                listView1.Items.Add(item);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            conexion.Guardar(new Persona(textBox1.Text, textBox2.Text));
            textBox1.Text = "";
            textBox2.Text = "";
            button1_Click(sender, e);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listView1.SelectedItems.Count > 0)
            {
                seleccionada = new Persona(listView1.SelectedItems[0].SubItems[0].Text, listView1.SelectedItems[0].SubItems[1].Text, listView1.SelectedItems[0].SubItems[2].Text);
                textBox1.Text = seleccionada.Nombre;
                textBox2.Text = seleccionada.Apellido;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            conexion.Borrar(seleccionada);
            button1_Click(sender, e);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            conexion.Modificar(new Persona(seleccionada.ID, textBox1.Text, textBox2.Text));
            button1_Click(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Persona aux = conexion.LeerID(textBox3.Text);
            if (aux != null)
            {
                MessageBox.Show(aux.Nombre + " " + aux.Apellido);
            }
            else
                MessageBox.Show("No encontrado");
        }
    }
}
