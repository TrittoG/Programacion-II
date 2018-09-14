using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio_28
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dictionary<string, int> diccio = new Dictionary<string, int>();
            
            foreach(string str in richTextBox1.Text.Split(' '))
            {
                if(!(diccio.ContainsKey(str)))
                {
                    diccio.Add(str, 1);                  
                }
                else
                {
                    diccio[str]++;
                }
            }

           

            List<KeyValuePair<string, int>> lista = diccio.ToList();

            lista.Sort(Ordenar);

            string ster = "";
            for(int i = 0; i< 3;i++)
            {
                ster = ster + " " + lista[i];
            }

            MessageBox.Show(ster, "PALABRAS MAS ESCRITAS");




        }
        public static int Ordenar(KeyValuePair<string , int> a , KeyValuePair<string, int > b)
        {
            if (a.Value == b.Value)
                return 0;
            else if (a.Value > b.Value)
                return 1;
            else
                return -1;
        }
    }
}
