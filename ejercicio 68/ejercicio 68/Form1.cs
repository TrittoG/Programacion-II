using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio_68
{
    public partial class Form1 : Form
    {
        private Persona p;
        private event DelegadoString Evento;

        public Form1()
        {
            InitializeComponent();
        }

        public void NotificarCambio(string mensaje)
        {
            MessageBox.Show(mensaje + p.Mostrar());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Evento += NotificarCambio;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(p is null)
            {
                p = new Persona(textBox1.Text, textBox2.Text);
                button1.Text = "Modificar";

                Evento.Invoke("se ha creado");
            }
            else
            {
                Evento.Invoke("se ha modificado");
                
            }
            
        }
    }
}
