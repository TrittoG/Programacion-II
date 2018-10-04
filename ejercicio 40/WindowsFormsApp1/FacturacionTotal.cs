using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ejercicio_40;

namespace WindowsFormsApp1
{
    public partial class FacturacionTotal : Form
    {
        Centralita centra;

        public FacturacionTotal(Centralita cen)
        {
            InitializeComponent();
             centra = cen;

            richTextBox1.Text = centra.ToString();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
