using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unidades;

namespace ejercicio_24
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_far_Click(object sender, EventArgs e)
        {
            double salida;

            if(double.TryParse(txtFar.Text, out salida))
            {
                Fahrenheit far = new Fahrenheit(salida);

                txtFarFar.Text = string.Format("{0}", far.GetTemp());
                txtFarCel.Text = string.Format("{0}", ((Celsius)far).GetTemp());
                txtFarKel.Text = string.Format("{0}", ((Kelvin)far).GetTemp());

            }
            else
            {
                txtFarFar.Text = "E";
                txtFarCel.Text = "E";
                txtFarKel.Text = "E";
            }
        }

        private void btn_cel_Click(object sender, EventArgs e)
        {
            double salida;

            if(double.TryParse(txtCel.Text, out salida))
            {
                Celsius cel = new Celsius(salida);

                txtCelCel.Text = string.Format("{0}", cel.GetTemp());
                txtCelFar.Text = string.Format("{0}", ((Fahrenheit)cel).GetTemp());
                txtCelKel.Text = string.Format("{0}", ((Kelvin)cel).GetTemp());
            }
            else
            {
                txtCelCel.Text = "E";
                txtCelFar.Text = "E";
                txtCelKel.Text = "E";
            }
            
        }

        private void btn_kel_Click(object sender, EventArgs e)
        {
            double salida;

            if(double.TryParse(txtKel.Text, out salida))
            {
                Kelvin kel = new Kelvin(salida);

                txtKelKel.Text = string.Format("{0}", kel.GetTemp());
                txtKelCel.Text = string.Format("{0}", ((Celsius)kel).GetTemp());
                txtKelFar.Text = string.Format("{0}", ((Fahrenheit)kel).GetTemp());
            }
            else
            {
                txtKelKel.Text = "E";
                txtKelCel.Text = "E";
                txtKelFar.Text = "E";
                //como dejarlo fijo el tamaño
                //cuadro de salida
                //el boton quede con el enter
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
