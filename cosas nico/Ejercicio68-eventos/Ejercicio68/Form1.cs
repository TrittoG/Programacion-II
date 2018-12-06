using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio68
{
    public partial class Form1 : Form
    {
        Persona persona;
        public event DelegadoString Evento;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Evento += NotificarCambio;
        }

        private void NotificarCambio(string msg)
        {
            MessageBox.Show(msg);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(persona is null)
            {
                persona = new Persona(textBox1.Text, textBox2.Text);
                Evento.Invoke("Se creo: " + persona.Mostrar());
            }
            else
            {
                persona = new Persona(textBox1.Text, textBox2.Text);
                Evento.Invoke("Modificacion: " + persona.Mostrar());
            }
        }
    }
}
