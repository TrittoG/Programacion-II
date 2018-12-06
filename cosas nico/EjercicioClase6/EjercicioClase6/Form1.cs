using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioClase6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblCantPalabras_Click(object sender, EventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void rtxtTexto_TextChanged(object sender, EventArgs e)
        {
            double palabras = 0;
            double palabrasLA = 0;
            rtxtTexto.Text.Trim();
            foreach (string s in rtxtTexto.Text.Split(' '))
            {
                if (!string.IsNullOrEmpty(s))
                    palabras++;
                if (s.Length >= 2)
                    if (s.ToLower().LastIndexOf("la") == s.Length - 2)
                        palabrasLA++;
            }
            lblCantFinalizaLA.Text = string.Format("{0}",palabrasLA);
            lblCantPalabras.Text = string.Format("{0}", palabras);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtResultado.Text = PalabrasTerminanEn("o ", 3);
        }

        private string PalabrasTerminanEn(string contenidoFinal, short cantidadAEncontrar)
        {
            string acumPalabras = "";
            int acum = 0;
            int indice = -1;
            int inicioCadena;
            string texto = rtxtTexto.Text.Trim();
            texto = texto + " ";
            do
            {
                indice = texto.IndexOf(contenidoFinal, indice + 1);
                if (indice == -1)
                    break;
                acum++;
                inicioCadena = texto.LastIndexOf(" ", indice);
                if (inicioCadena == -1)
                    inicioCadena = 0;
                acumPalabras += "* " + texto.Substring(inicioCadena, (indice - inicioCadena) + 1);
            } while (acum < cantidadAEncontrar);

            return acumPalabras;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtResultado.Text = PalabrasTerminanEn("a ", 3);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";
            int cont = 0;
            foreach(char s in rtxtTexto.Text)
            {
                if(!(s < 'a' && s > 'z') || !(s < 'A' && s > 'Z'))
                {
                    if(s != ' ')
                        txtResultado.Text = txtResultado.Text + " " + s;
                }
                cont++;
                if (cont > 99)
                    break;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";
            int canti = 0;
            string texto = rtxtTexto.Text.Trim();
            foreach (string s in texto.Split(' '))
            {
                if (!string.IsNullOrEmpty(s))
                {
                    txtResultado.Text += "* " + s;
                    canti++;
                    if (canti >= 20)
                        break;
                }
            }
        }
    }
}
