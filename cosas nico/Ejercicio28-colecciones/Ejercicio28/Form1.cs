using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio28
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
            Dictionary<string, int> newDic = new Dictionary<string, int>();
            richTextBox1.Text = richTextBox1.Text.ToLower();
            richTextBox1.Text = richTextBox1.Text.Replace('\n', ' ');
            richTextBox1.Text = richTextBox1.Text.Replace('.', ' ');
            richTextBox1.Text = richTextBox1.Text.Replace(',', ' ');
            richTextBox1.Text = richTextBox1.Text.Replace("  ", " ");
            richTextBox1.Text = richTextBox1.Text.Trim();
            foreach (string s in richTextBox1.Text.Split(' '))
            {
                if (!newDic.ContainsKey(s))
                    newDic.Add(s, 1);
                else
                    newDic[s]++;
            }
            richTextBox1.Clear();
            List<KeyValuePair<string, int>> newLs = newDic.ToList();
            newLs.Sort(OrdenarBA);
            string mensaje = "";
            for(int i = 0; i < 3; i++)
            {
                if(newLs.Capacity > 3)
                 mensaje = mensaje + ' ' + newLs[i].Key;
            }
            MessageBox.Show(mensaje);
        }

        private static int OrdenarAB(KeyValuePair<string, int> a, KeyValuePair<string, int> b)
        {
            if (a.Value > b.Value)
            {
                return 1;
            }
            else
            {
                if (a.Value < b.Value)
                {
                    return -1;
                }
                else
                {
                    return 0;
                }
            }
        }

        private static int OrdenarBA(KeyValuePair<string, int> a, KeyValuePair<string, int> b)
        {
            return -(OrdenarAB(a, b));
        }
    }
}
