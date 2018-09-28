using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace VistaForm
{
    public partial class VistaCurso : Form
    {
        Curso c;
        Alumno alu;
        
        public VistaCurso()
        {
            InitializeComponent();
        }

        private void btn_crearCurso_Click(object sender, EventArgs e)
        {
            Profesor pro;

            Divisiones division;
            Enum.TryParse<Divisiones>(comboBox_divisionCurso.SelectedValue.ToString(), out division);

            pro = new Profesor(txt_NombreCurso.Text, txt_ApellidoCurso.Text, txt_DniCurso.Text, dateTimePicker_ingresoCurso.Value);

            c = new Curso((short)numericUpDown_año.Value, division, pro);
        }

        private void comboBox_divisionCurso_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void VistaCurso_Load(object sender, EventArgs e)
        {
            comboBox_divisionCurso.DataSource = Enum.GetValues(typeof(Divisiones));            comboBoxDivisionAlumno.DataSource = Enum.GetValues(typeof(Divisiones));
        }

        private void btn_mostrar_Click(object sender, EventArgs e)
        {
            richTextBox1.Text =(string)c; 
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            Divisiones division;
            Enum.TryParse<Divisiones>(comboBoxDivisionAlumno.SelectedValue.ToString(), out division);

            alu = new Alumno(txt_NombreAlumno.Text, txt_ApellidoAlumno.Text, txt_legajo.Text, (short)numericUpDownAñoAlumno.Value, division);

            richTextBox1.Text = richTextBox1.Text + alu.ExponerDatos();
        }
    }
}
