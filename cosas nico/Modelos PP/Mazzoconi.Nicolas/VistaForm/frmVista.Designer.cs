namespace VistaForm
{
    partial class frmVista
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
            this.groupBoxDatosCurso = new System.Windows.Forms.GroupBox();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.btnCrear = new System.Windows.Forms.Button();
            this.dtpFechaIngreso = new System.Windows.Forms.DateTimePicker();
            this.txtDocumentoProfe = new System.Windows.Forms.TextBox();
            this.txtApellidoProfe = new System.Windows.Forms.TextBox();
            this.txtNombreProfe = new System.Windows.Forms.TextBox();
            this.lblFechaIngreso = new System.Windows.Forms.Label();
            this.lblDocumentoProfe = new System.Windows.Forms.Label();
            this.lblApellidoProfe = new System.Windows.Forms.Label();
            this.lblNombreProfe = new System.Windows.Forms.Label();
            this.lblDivisionCurso = new System.Windows.Forms.Label();
            this.lblAnioProfe = new System.Windows.Forms.Label();
            this.nudAnioCurso = new System.Windows.Forms.NumericUpDown();
            this.cmbDivisionCurso = new System.Windows.Forms.ComboBox();
            this.groupBoxDatosAlumnos = new System.Windows.Forms.GroupBox();
            this.rtbDatos = new System.Windows.Forms.RichTextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblDocumento = new System.Windows.Forms.Label();
            this.lblAnio = new System.Windows.Forms.Label();
            this.lblDivision = new System.Windows.Forms.Label();
            this.nudAnio = new System.Windows.Forms.NumericUpDown();
            this.cmbDivision = new System.Windows.Forms.ComboBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.groupBoxDatosCurso.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnioCurso)).BeginInit();
            this.groupBoxDatosAlumnos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnio)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxDatosCurso
            // 
            this.groupBoxDatosCurso.Controls.Add(this.btnMostrar);
            this.groupBoxDatosCurso.Controls.Add(this.btnCrear);
            this.groupBoxDatosCurso.Controls.Add(this.dtpFechaIngreso);
            this.groupBoxDatosCurso.Controls.Add(this.txtDocumentoProfe);
            this.groupBoxDatosCurso.Controls.Add(this.txtApellidoProfe);
            this.groupBoxDatosCurso.Controls.Add(this.txtNombreProfe);
            this.groupBoxDatosCurso.Controls.Add(this.lblFechaIngreso);
            this.groupBoxDatosCurso.Controls.Add(this.lblDocumentoProfe);
            this.groupBoxDatosCurso.Controls.Add(this.lblApellidoProfe);
            this.groupBoxDatosCurso.Controls.Add(this.lblNombreProfe);
            this.groupBoxDatosCurso.Controls.Add(this.lblDivisionCurso);
            this.groupBoxDatosCurso.Controls.Add(this.lblAnioProfe);
            this.groupBoxDatosCurso.Controls.Add(this.nudAnioCurso);
            this.groupBoxDatosCurso.Controls.Add(this.cmbDivisionCurso);
            this.groupBoxDatosCurso.Location = new System.Drawing.Point(12, 12);
            this.groupBoxDatosCurso.Name = "groupBoxDatosCurso";
            this.groupBoxDatosCurso.Size = new System.Drawing.Size(268, 208);
            this.groupBoxDatosCurso.TabIndex = 0;
            this.groupBoxDatosCurso.TabStop = false;
            this.groupBoxDatosCurso.Text = "Datos Curso";
            this.groupBoxDatosCurso.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(148, 177);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(75, 23);
            this.btnMostrar.TabIndex = 12;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(34, 177);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(75, 23);
            this.btnCrear.TabIndex = 11;
            this.btnCrear.Text = "Crear Curso";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // dtpFechaIngreso
            // 
            this.dtpFechaIngreso.Location = new System.Drawing.Point(64, 151);
            this.dtpFechaIngreso.Name = "dtpFechaIngreso";
            this.dtpFechaIngreso.Size = new System.Drawing.Size(198, 20);
            this.dtpFechaIngreso.TabIndex = 3;
            // 
            // txtDocumentoProfe
            // 
            this.txtDocumentoProfe.Location = new System.Drawing.Point(64, 122);
            this.txtDocumentoProfe.Name = "txtDocumentoProfe";
            this.txtDocumentoProfe.Size = new System.Drawing.Size(198, 20);
            this.txtDocumentoProfe.TabIndex = 10;
            // 
            // txtApellidoProfe
            // 
            this.txtApellidoProfe.Location = new System.Drawing.Point(64, 96);
            this.txtApellidoProfe.Name = "txtApellidoProfe";
            this.txtApellidoProfe.Size = new System.Drawing.Size(198, 20);
            this.txtApellidoProfe.TabIndex = 9;
            // 
            // txtNombreProfe
            // 
            this.txtNombreProfe.Location = new System.Drawing.Point(64, 68);
            this.txtNombreProfe.Name = "txtNombreProfe";
            this.txtNombreProfe.Size = new System.Drawing.Size(198, 20);
            this.txtNombreProfe.TabIndex = 8;
            // 
            // lblFechaIngreso
            // 
            this.lblFechaIngreso.AutoSize = true;
            this.lblFechaIngreso.Location = new System.Drawing.Point(0, 151);
            this.lblFechaIngreso.Name = "lblFechaIngreso";
            this.lblFechaIngreso.Size = new System.Drawing.Size(42, 13);
            this.lblFechaIngreso.TabIndex = 7;
            this.lblFechaIngreso.Text = "Ingreso";
            // 
            // lblDocumentoProfe
            // 
            this.lblDocumentoProfe.AutoSize = true;
            this.lblDocumentoProfe.Location = new System.Drawing.Point(0, 125);
            this.lblDocumentoProfe.Name = "lblDocumentoProfe";
            this.lblDocumentoProfe.Size = new System.Drawing.Size(26, 13);
            this.lblDocumentoProfe.TabIndex = 6;
            this.lblDocumentoProfe.Text = "DNI";
            // 
            // lblApellidoProfe
            // 
            this.lblApellidoProfe.AutoSize = true;
            this.lblApellidoProfe.Location = new System.Drawing.Point(0, 99);
            this.lblApellidoProfe.Name = "lblApellidoProfe";
            this.lblApellidoProfe.Size = new System.Drawing.Size(44, 13);
            this.lblApellidoProfe.TabIndex = 5;
            this.lblApellidoProfe.Text = "Apellido";
            // 
            // lblNombreProfe
            // 
            this.lblNombreProfe.AutoSize = true;
            this.lblNombreProfe.Location = new System.Drawing.Point(0, 71);
            this.lblNombreProfe.Name = "lblNombreProfe";
            this.lblNombreProfe.Size = new System.Drawing.Size(44, 13);
            this.lblNombreProfe.TabIndex = 4;
            this.lblNombreProfe.Text = "Nombre";
            // 
            // lblDivisionCurso
            // 
            this.lblDivisionCurso.AutoSize = true;
            this.lblDivisionCurso.Location = new System.Drawing.Point(0, 43);
            this.lblDivisionCurso.Name = "lblDivisionCurso";
            this.lblDivisionCurso.Size = new System.Drawing.Size(44, 13);
            this.lblDivisionCurso.TabIndex = 3;
            this.lblDivisionCurso.Text = "Division";
            // 
            // lblAnioProfe
            // 
            this.lblAnioProfe.AutoSize = true;
            this.lblAnioProfe.Location = new System.Drawing.Point(0, 16);
            this.lblAnioProfe.Name = "lblAnioProfe";
            this.lblAnioProfe.Size = new System.Drawing.Size(26, 13);
            this.lblAnioProfe.TabIndex = 2;
            this.lblAnioProfe.Text = "Año";
            // 
            // nudAnioCurso
            // 
            this.nudAnioCurso.Location = new System.Drawing.Point(64, 14);
            this.nudAnioCurso.Name = "nudAnioCurso";
            this.nudAnioCurso.Size = new System.Drawing.Size(96, 20);
            this.nudAnioCurso.TabIndex = 1;
            // 
            // cmbDivisionCurso
            // 
            this.cmbDivisionCurso.FormattingEnabled = true;
            this.cmbDivisionCurso.Location = new System.Drawing.Point(64, 40);
            this.cmbDivisionCurso.Name = "cmbDivisionCurso";
            this.cmbDivisionCurso.Size = new System.Drawing.Size(96, 21);
            this.cmbDivisionCurso.TabIndex = 0;
            // 
            // groupBoxDatosAlumnos
            // 
            this.groupBoxDatosAlumnos.Controls.Add(this.btnAgregar);
            this.groupBoxDatosAlumnos.Controls.Add(this.txtDocumento);
            this.groupBoxDatosAlumnos.Controls.Add(this.txtApellido);
            this.groupBoxDatosAlumnos.Controls.Add(this.txtNombre);
            this.groupBoxDatosAlumnos.Controls.Add(this.cmbDivision);
            this.groupBoxDatosAlumnos.Controls.Add(this.nudAnio);
            this.groupBoxDatosAlumnos.Controls.Add(this.lblDivision);
            this.groupBoxDatosAlumnos.Controls.Add(this.lblAnio);
            this.groupBoxDatosAlumnos.Controls.Add(this.lblDocumento);
            this.groupBoxDatosAlumnos.Controls.Add(this.lblApellido);
            this.groupBoxDatosAlumnos.Controls.Add(this.lblNombre);
            this.groupBoxDatosAlumnos.Location = new System.Drawing.Point(298, 12);
            this.groupBoxDatosAlumnos.Name = "groupBoxDatosAlumnos";
            this.groupBoxDatosAlumnos.Size = new System.Drawing.Size(255, 208);
            this.groupBoxDatosAlumnos.TabIndex = 1;
            this.groupBoxDatosAlumnos.TabStop = false;
            this.groupBoxDatosAlumnos.Text = "Datos Alumnos";
            // 
            // rtbDatos
            // 
            this.rtbDatos.Location = new System.Drawing.Point(12, 226);
            this.rtbDatos.Name = "rtbDatos";
            this.rtbDatos.ReadOnly = true;
            this.rtbDatos.Size = new System.Drawing.Size(541, 212);
            this.rtbDatos.TabIndex = 2;
            this.rtbDatos.Text = "";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(6, 16);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(6, 43);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(44, 13);
            this.lblApellido.TabIndex = 1;
            this.lblApellido.Text = "Apellido";
            // 
            // lblDocumento
            // 
            this.lblDocumento.AutoSize = true;
            this.lblDocumento.Location = new System.Drawing.Point(6, 71);
            this.lblDocumento.Name = "lblDocumento";
            this.lblDocumento.Size = new System.Drawing.Size(39, 13);
            this.lblDocumento.TabIndex = 2;
            this.lblDocumento.Text = "Legajo";
            // 
            // lblAnio
            // 
            this.lblAnio.AutoSize = true;
            this.lblAnio.Location = new System.Drawing.Point(6, 99);
            this.lblAnio.Name = "lblAnio";
            this.lblAnio.Size = new System.Drawing.Size(26, 13);
            this.lblAnio.TabIndex = 3;
            this.lblAnio.Text = "Año";
            // 
            // lblDivision
            // 
            this.lblDivision.AutoSize = true;
            this.lblDivision.Location = new System.Drawing.Point(6, 125);
            this.lblDivision.Name = "lblDivision";
            this.lblDivision.Size = new System.Drawing.Size(44, 13);
            this.lblDivision.TabIndex = 4;
            this.lblDivision.Text = "Division";
            // 
            // nudAnio
            // 
            this.nudAnio.Location = new System.Drawing.Point(62, 97);
            this.nudAnio.Name = "nudAnio";
            this.nudAnio.Size = new System.Drawing.Size(96, 20);
            this.nudAnio.TabIndex = 5;
            // 
            // cmbDivision
            // 
            this.cmbDivision.FormattingEnabled = true;
            this.cmbDivision.Location = new System.Drawing.Point(62, 122);
            this.cmbDivision.Name = "cmbDivision";
            this.cmbDivision.Size = new System.Drawing.Size(96, 21);
            this.cmbDivision.TabIndex = 6;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(51, 13);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(198, 20);
            this.txtNombre.TabIndex = 9;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(51, 40);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(198, 20);
            this.txtApellido.TabIndex = 10;
            // 
            // txtDocumento
            // 
            this.txtDocumento.Location = new System.Drawing.Point(51, 68);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(198, 20);
            this.txtDocumento.TabIndex = 11;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(19, 177);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 12;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // frmVista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 450);
            this.Controls.Add(this.rtbDatos);
            this.Controls.Add(this.groupBoxDatosAlumnos);
            this.Controls.Add(this.groupBoxDatosCurso);
            this.Name = "frmVista";
            this.Text = "Vista del Curso";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxDatosCurso.ResumeLayout(false);
            this.groupBoxDatosCurso.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnioCurso)).EndInit();
            this.groupBoxDatosAlumnos.ResumeLayout(false);
            this.groupBoxDatosAlumnos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxDatosCurso;
        private System.Windows.Forms.TextBox txtDocumentoProfe;
        private System.Windows.Forms.TextBox txtApellidoProfe;
        private System.Windows.Forms.TextBox txtNombreProfe;
        private System.Windows.Forms.Label lblFechaIngreso;
        private System.Windows.Forms.Label lblDocumentoProfe;
        private System.Windows.Forms.Label lblApellidoProfe;
        private System.Windows.Forms.Label lblNombreProfe;
        private System.Windows.Forms.Label lblDivisionCurso;
        private System.Windows.Forms.Label lblAnioProfe;
        private System.Windows.Forms.NumericUpDown nudAnioCurso;
        private System.Windows.Forms.ComboBox cmbDivisionCurso;
        private System.Windows.Forms.GroupBox groupBoxDatosAlumnos;
        private System.Windows.Forms.RichTextBox rtbDatos;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.DateTimePicker dtpFechaIngreso;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.ComboBox cmbDivision;
        private System.Windows.Forms.NumericUpDown nudAnio;
        private System.Windows.Forms.Label lblDivision;
        private System.Windows.Forms.Label lblAnio;
        private System.Windows.Forms.Label lblDocumento;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
    }
}

