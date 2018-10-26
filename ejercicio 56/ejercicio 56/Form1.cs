using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ejercicio_56
{
    public partial class Form1 : Form
    {
        string str;



        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        public void richTextBox1_TextChanged(object sender, EventArgs e)
        {

            toolStripStatusLabel1.Text = "Caracteres :" + richTextBox1.Text.Length;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.ShowDialog();
            StreamReader sr = null ;

            try
            {
                 sr = new StreamReader(open.FileName);
                richTextBox1.Text = sr.ReadToEnd();
                str = open.FileName;
            }
            catch(Exception )
            {

            }
           finally
            {
                if(sr != null)
                sr.Close();
            }
         
        }

        private void archivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (str is null)
            {
                guardarComoToolStripMenuItem_Click(sender, e);
            }
            else
            {
                StreamWriter sw = new StreamWriter(str);
                sw.WriteLine(richTextBox1.Text);
                sw.Close();

            }
                
        }

        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.ShowDialog();

            StreamWriter sw = new StreamWriter(save.FileName);
            sw.WriteLine(richTextBox1.Text);
            sw.Close();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("DESEA SALIR?", "saliendo", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void cambiarFuenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Fuente fuente = new Fuente(richTextBox1, this);
            //fuente.Show();
            //this.Hide();

            FontDialog font = new FontDialog();
            font.ShowDialog();
            richTextBox1.SelectionFont = font.Font;
        }
    }
}
