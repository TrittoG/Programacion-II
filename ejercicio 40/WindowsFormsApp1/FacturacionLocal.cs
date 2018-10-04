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
    public partial class FacturacionLocal : Form
    {
        Centralita centra;

        public FacturacionLocal(Centralita c)
        {
            InitializeComponent();
            centra = c;

        }

        private void FacturacionLocal_Load(object sender, EventArgs e)
        {
            foreach (Llamada l in centra.Llamadas)
            {
                if (l is Local)
                {
                    richTextBox1.Text = centra.ToString();
                }
            }

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
