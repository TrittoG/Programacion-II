namespace VistaForm
{
    partial class VistaCurso
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_crearCurso = new System.Windows.Forms.Button();
            this.btn_mostrar = new System.Windows.Forms.Button();
            this.dateTimePicker_ingresoCurso = new System.Windows.Forms.DateTimePicker();
            this.txt_DniCurso = new System.Windows.Forms.TextBox();
            this.txt_ApellidoCurso = new System.Windows.Forms.TextBox();
            this.txt_NombreCurso = new System.Windows.Forms.TextBox();
            this.comboBox_divisionCurso = new System.Windows.Forms.ComboBox();
            this.numericUpDown_año = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.comboBoxDivisionAlumno = new System.Windows.Forms.ComboBox();
            this.numericUpDownAñoAlumno = new System.Windows.Forms.NumericUpDown();
            this.txt_legajo = new System.Windows.Forms.TextBox();
            this.txt_ApellidoAlumno = new System.Windows.Forms.TextBox();
            this.txt_NombreAlumno = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_año)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAñoAlumno)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_crearCurso);
            this.groupBox1.Controls.Add(this.btn_mostrar);
            this.groupBox1.Controls.Add(this.dateTimePicker_ingresoCurso);
            this.groupBox1.Controls.Add(this.txt_DniCurso);
            this.groupBox1.Controls.Add(this.txt_ApellidoCurso);
            this.groupBox1.Controls.Add(this.txt_NombreCurso);
            this.groupBox1.Controls.Add(this.comboBox_divisionCurso);
            this.groupBox1.Controls.Add(this.numericUpDown_año);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(326, 244);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Del Curso";
            // 
            // btn_crearCurso
            // 
            this.btn_crearCurso.Location = new System.Drawing.Point(21, 186);
            this.btn_crearCurso.Name = "btn_crearCurso";
            this.btn_crearCurso.Size = new System.Drawing.Size(131, 43);
            this.btn_crearCurso.TabIndex = 13;
            this.btn_crearCurso.Text = "Crear curso";
            this.btn_crearCurso.UseVisualStyleBackColor = true;
            this.btn_crearCurso.Click += new System.EventHandler(this.btn_crearCurso_Click);
            // 
            // btn_mostrar
            // 
            this.btn_mostrar.Location = new System.Drawing.Point(174, 186);
            this.btn_mostrar.Name = "btn_mostrar";
            this.btn_mostrar.Size = new System.Drawing.Size(131, 43);
            this.btn_mostrar.TabIndex = 12;
            this.btn_mostrar.Text = "Mostrar";
            this.btn_mostrar.UseVisualStyleBackColor = true;
            this.btn_mostrar.Click += new System.EventHandler(this.btn_mostrar_Click);
            // 
            // dateTimePicker_ingresoCurso
            // 
            this.dateTimePicker_ingresoCurso.Location = new System.Drawing.Point(118, 140);
            this.dateTimePicker_ingresoCurso.Name = "dateTimePicker_ingresoCurso";
            this.dateTimePicker_ingresoCurso.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker_ingresoCurso.TabIndex = 11;
            // 
            // txt_DniCurso
            // 
            this.txt_DniCurso.Location = new System.Drawing.Point(117, 117);
            this.txt_DniCurso.Name = "txt_DniCurso";
            this.txt_DniCurso.Size = new System.Drawing.Size(201, 20);
            this.txt_DniCurso.TabIndex = 10;
            // 
            // txt_ApellidoCurso
            // 
            this.txt_ApellidoCurso.Location = new System.Drawing.Point(118, 92);
            this.txt_ApellidoCurso.Name = "txt_ApellidoCurso";
            this.txt_ApellidoCurso.Size = new System.Drawing.Size(200, 20);
            this.txt_ApellidoCurso.TabIndex = 9;
            // 
            // txt_NombreCurso
            // 
            this.txt_NombreCurso.Location = new System.Drawing.Point(118, 70);
            this.txt_NombreCurso.Name = "txt_NombreCurso";
            this.txt_NombreCurso.Size = new System.Drawing.Size(200, 20);
            this.txt_NombreCurso.TabIndex = 8;
            // 
            // comboBox_divisionCurso
            // 
            this.comboBox_divisionCurso.FormattingEnabled = true;
            this.comboBox_divisionCurso.Location = new System.Drawing.Point(117, 45);
            this.comboBox_divisionCurso.Name = "comboBox_divisionCurso";
            this.comboBox_divisionCurso.Size = new System.Drawing.Size(121, 21);
            this.comboBox_divisionCurso.TabIndex = 7;
            this.comboBox_divisionCurso.SelectedIndexChanged += new System.EventHandler(this.comboBox_divisionCurso_SelectedIndexChanged);
            // 
            // numericUpDown_año
            // 
            this.numericUpDown_año.Location = new System.Drawing.Point(118, 23);
            this.numericUpDown_año.Name = "numericUpDown_año";
            this.numericUpDown_año.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_año.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Ingreso";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "DNI";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Apellido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Division";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Año";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_Agregar);
            this.groupBox2.Controls.Add(this.comboBoxDivisionAlumno);
            this.groupBox2.Controls.Add(this.numericUpDownAñoAlumno);
            this.groupBox2.Controls.Add(this.txt_legajo);
            this.groupBox2.Controls.Add(this.txt_ApellidoAlumno);
            this.groupBox2.Controls.Add(this.txt_NombreAlumno);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(361, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(342, 244);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos Alumno";
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.Location = new System.Drawing.Point(21, 186);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(301, 43);
            this.btn_Agregar.TabIndex = 10;
            this.btn_Agregar.Text = "Agregar";
            this.btn_Agregar.UseVisualStyleBackColor = true;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // comboBoxDivisionAlumno
            // 
            this.comboBoxDivisionAlumno.FormattingEnabled = true;
            this.comboBoxDivisionAlumno.Location = new System.Drawing.Point(99, 116);
            this.comboBoxDivisionAlumno.Name = "comboBoxDivisionAlumno";
            this.comboBoxDivisionAlumno.Size = new System.Drawing.Size(121, 21);
            this.comboBoxDivisionAlumno.TabIndex = 9;
            // 
            // numericUpDownAñoAlumno
            // 
            this.numericUpDownAñoAlumno.Location = new System.Drawing.Point(99, 94);
            this.numericUpDownAñoAlumno.Name = "numericUpDownAñoAlumno";
            this.numericUpDownAñoAlumno.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownAñoAlumno.TabIndex = 8;
            // 
            // txt_legajo
            // 
            this.txt_legajo.Location = new System.Drawing.Point(99, 70);
            this.txt_legajo.Name = "txt_legajo";
            this.txt_legajo.Size = new System.Drawing.Size(100, 20);
            this.txt_legajo.TabIndex = 7;
            // 
            // txt_ApellidoAlumno
            // 
            this.txt_ApellidoAlumno.Location = new System.Drawing.Point(99, 48);
            this.txt_ApellidoAlumno.Name = "txt_ApellidoAlumno";
            this.txt_ApellidoAlumno.Size = new System.Drawing.Size(100, 20);
            this.txt_ApellidoAlumno.TabIndex = 6;
            // 
            // txt_NombreAlumno
            // 
            this.txt_NombreAlumno.Location = new System.Drawing.Point(99, 27);
            this.txt_NombreAlumno.Name = "txt_NombreAlumno";
            this.txt_NombreAlumno.Size = new System.Drawing.Size(100, 20);
            this.txt_NombreAlumno.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(18, 125);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "Division";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 102);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(26, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Año";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 77);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Legajo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Apellido";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Nombre";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(14, 293);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(691, 121);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // VistaCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 426);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "VistaCurso";
            this.Text = "Vista del curso";
            this.Load += new System.EventHandler(this.VistaCurso_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_año)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAñoAlumno)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_crearCurso;
        private System.Windows.Forms.Button btn_mostrar;
        private System.Windows.Forms.DateTimePicker dateTimePicker_ingresoCurso;
        private System.Windows.Forms.TextBox txt_DniCurso;
        private System.Windows.Forms.TextBox txt_ApellidoCurso;
        private System.Windows.Forms.TextBox txt_NombreCurso;
        private System.Windows.Forms.ComboBox comboBox_divisionCurso;
        private System.Windows.Forms.NumericUpDown numericUpDown_año;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_Agregar;
        private System.Windows.Forms.ComboBox comboBoxDivisionAlumno;
        private System.Windows.Forms.NumericUpDown numericUpDownAñoAlumno;
        private System.Windows.Forms.TextBox txt_legajo;
        private System.Windows.Forms.TextBox txt_ApellidoAlumno;
        private System.Windows.Forms.TextBox txt_NombreAlumno;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

