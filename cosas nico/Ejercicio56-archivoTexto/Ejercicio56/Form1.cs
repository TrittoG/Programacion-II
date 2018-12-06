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

namespace Ejercicio56
{
	public partial class Form1 : Form
	{
        private bool guardado;
		private string archivoPath;
		public Form1()
		{
            string[] args = Environment.GetCommandLineArgs();
            if (args.Length > 1)            
                archivoPath = args[1];
            guardado = false;
			InitializeComponent();
			toolStripStatusLabel1.Text = richTextBox1.Text.Length + " Caracteres";
            

        }

		private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
		{
			
		}

		private void richTextBox1_TextChanged(object sender, EventArgs e)
		{
			toolStripStatusLabel1.Text = richTextBox1.Text.Length + " Caracteres";
		}

		private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
		{
			SaveFileDialog save = new SaveFileDialog();
			save.Filter = "Archivos txt(*.txt)|*.txt";
			if(save.ShowDialog() == DialogResult.OK)
			{
				archivoPath = save.FileName;
			}
			guardarToolStripMenuItem_Click(sender, e);
			
		}

		private void toolStripStatusLabel1_Click(object sender, EventArgs e)
		{
			
		}

		private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
		{

		}

		private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
		{
			OpenFileDialog open = new OpenFileDialog();
			open.Filter = "Archivos txt(*.txt)|*.txt";
			if(open.ShowDialog() == DialogResult.OK)
			{
				archivoPath = open.FileName;
				StreamReader sr = new StreamReader(archivoPath);
				richTextBox1.Text = sr.ReadToEnd();
				sr.Close();
			}
		}

		private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
		{
            if (archivoPath != null)
            {
                StreamWriter sw = new StreamWriter(archivoPath);
                sw.WriteLine(richTextBox1.Text);
                sw.Close();
                guardado = true;
            }
            else
            {
                guardarComoToolStripMenuItem_Click(sender, e);
            }
		}

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (guardado == false)
            {
                DialogResult dg = MessageBox.Show("No has guardado los cambios, ¿Deseas guardar?", "Salir sin guardar", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (dg == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
                else
                {
                    if (dg == DialogResult.Yes)
                    {
                        guardarToolStripMenuItem_Click(sender, e);
                    }
                }
            }   
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (archivoPath != null)
            {
                StreamReader sr = new StreamReader(archivoPath);
                richTextBox1.Text = sr.ReadToEnd();
                sr.Close();
            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            
        }

        private void tamañoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            fd.ShowDialog();
            richTextBox1.SelectionFont = new Font(fd.Font, FontStyle.Regular);
        }
    }
}
