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
    public partial class Form1 : Form
    {
        SQLConection coneccion;

        public Form1()
        {
            InitializeComponent();
            this.coneccion = new SQLConection("LAB3PC08\\SQLEXPRESS", "AdventureWorks2012");
        }

        private void btn_mostrar_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            
            foreach(Producto p in coneccion.Mostrar())
            {
                ListViewItem item = new ListViewItem(p.Id);
                item.SubItems.Add(p.Nombre);
                item.SubItems.Add(p.ProductNumber);
                listView1.Items.Add(item);
            }

            
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            //Producto pr = new Producto("COCALOCA", "adsdsa", "1");

            Agregar a = new Agregar(this.coneccion);
            a.Show();

        }

        private void btn_borrar_Click(object sender, EventArgs e)
        {
            Borrar br = new Borrar(coneccion);

            br.Show();
        }
    }
}
