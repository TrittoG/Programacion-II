namespace ejercicio_23
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEuro = new System.Windows.Forms.TextBox();
            this.txtDolar = new System.Windows.Forms.TextBox();
            this.txtPesos = new System.Windows.Forms.TextBox();
            this.btn_euro = new System.Windows.Forms.Button();
            this.btn_dolar = new System.Windows.Forms.Button();
            this.btn_pesos = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEuroEuro = new System.Windows.Forms.TextBox();
            this.txtEuroDolar = new System.Windows.Forms.TextBox();
            this.txtEuroPesos = new System.Windows.Forms.TextBox();
            this.txtDolarEuro = new System.Windows.Forms.TextBox();
            this.txtDolarDolar = new System.Windows.Forms.TextBox();
            this.txtDolarPesos = new System.Windows.Forms.TextBox();
            this.txtPesosEuro = new System.Windows.Forms.TextBox();
            this.txtPesosDolar = new System.Windows.Forms.TextBox();
            this.txtPesosPesos = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Euro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dolar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Pesos";
            // 
            // txtEuro
            // 
            this.txtEuro.Location = new System.Drawing.Point(64, 47);
            this.txtEuro.Name = "txtEuro";
            this.txtEuro.Size = new System.Drawing.Size(100, 20);
            this.txtEuro.TabIndex = 3;
            this.txtEuro.TextChanged += new System.EventHandler(this.txtEuro_TextChanged);
            // 
            // txtDolar
            // 
            this.txtDolar.Location = new System.Drawing.Point(64, 81);
            this.txtDolar.Name = "txtDolar";
            this.txtDolar.Size = new System.Drawing.Size(100, 20);
            this.txtDolar.TabIndex = 4;
            // 
            // txtPesos
            // 
            this.txtPesos.Location = new System.Drawing.Point(64, 108);
            this.txtPesos.Name = "txtPesos";
            this.txtPesos.Size = new System.Drawing.Size(100, 20);
            this.txtPesos.TabIndex = 5;
            // 
            // btn_euro
            // 
            this.btn_euro.Location = new System.Drawing.Point(170, 47);
            this.btn_euro.Name = "btn_euro";
            this.btn_euro.Size = new System.Drawing.Size(75, 23);
            this.btn_euro.TabIndex = 6;
            this.btn_euro.Text = "->";
            this.btn_euro.UseVisualStyleBackColor = true;
            this.btn_euro.Click += new System.EventHandler(this.btn_euro_Click);
            // 
            // btn_dolar
            // 
            this.btn_dolar.Location = new System.Drawing.Point(170, 79);
            this.btn_dolar.Name = "btn_dolar";
            this.btn_dolar.Size = new System.Drawing.Size(75, 23);
            this.btn_dolar.TabIndex = 7;
            this.btn_dolar.Text = "->";
            this.btn_dolar.UseVisualStyleBackColor = true;
            this.btn_dolar.Click += new System.EventHandler(this.btn_dolar_Click);
            // 
            // btn_pesos
            // 
            this.btn_pesos.Location = new System.Drawing.Point(170, 108);
            this.btn_pesos.Name = "btn_pesos";
            this.btn_pesos.Size = new System.Drawing.Size(75, 23);
            this.btn_pesos.TabIndex = 8;
            this.btn_pesos.Text = "->";
            this.btn_pesos.UseVisualStyleBackColor = true;
            this.btn_pesos.Click += new System.EventHandler(this.btn_pesos_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(258, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Euro";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(373, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Dolar";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(479, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Pesos";
            // 
            // txtEuroEuro
            // 
            this.txtEuroEuro.Location = new System.Drawing.Point(259, 46);
            this.txtEuroEuro.Name = "txtEuroEuro";
            this.txtEuroEuro.ReadOnly = true;
            this.txtEuroEuro.Size = new System.Drawing.Size(100, 20);
            this.txtEuroEuro.TabIndex = 12;
            // 
            // txtEuroDolar
            // 
            this.txtEuroDolar.Location = new System.Drawing.Point(367, 46);
            this.txtEuroDolar.Name = "txtEuroDolar";
            this.txtEuroDolar.ReadOnly = true;
            this.txtEuroDolar.Size = new System.Drawing.Size(100, 20);
            this.txtEuroDolar.TabIndex = 13;
            // 
            // txtEuroPesos
            // 
            this.txtEuroPesos.Location = new System.Drawing.Point(472, 47);
            this.txtEuroPesos.Name = "txtEuroPesos";
            this.txtEuroPesos.ReadOnly = true;
            this.txtEuroPesos.Size = new System.Drawing.Size(100, 20);
            this.txtEuroPesos.TabIndex = 14;
            // 
            // txtDolarEuro
            // 
            this.txtDolarEuro.Location = new System.Drawing.Point(259, 77);
            this.txtDolarEuro.Name = "txtDolarEuro";
            this.txtDolarEuro.ReadOnly = true;
            this.txtDolarEuro.Size = new System.Drawing.Size(100, 20);
            this.txtDolarEuro.TabIndex = 15;
            // 
            // txtDolarDolar
            // 
            this.txtDolarDolar.Location = new System.Drawing.Point(366, 77);
            this.txtDolarDolar.Name = "txtDolarDolar";
            this.txtDolarDolar.ReadOnly = true;
            this.txtDolarDolar.Size = new System.Drawing.Size(100, 20);
            this.txtDolarDolar.TabIndex = 16;
            // 
            // txtDolarPesos
            // 
            this.txtDolarPesos.Location = new System.Drawing.Point(473, 77);
            this.txtDolarPesos.Name = "txtDolarPesos";
            this.txtDolarPesos.ReadOnly = true;
            this.txtDolarPesos.Size = new System.Drawing.Size(100, 20);
            this.txtDolarPesos.TabIndex = 17;
            // 
            // txtPesosEuro
            // 
            this.txtPesosEuro.Location = new System.Drawing.Point(261, 111);
            this.txtPesosEuro.Name = "txtPesosEuro";
            this.txtPesosEuro.ReadOnly = true;
            this.txtPesosEuro.Size = new System.Drawing.Size(100, 20);
            this.txtPesosEuro.TabIndex = 18;
            // 
            // txtPesosDolar
            // 
            this.txtPesosDolar.Location = new System.Drawing.Point(367, 111);
            this.txtPesosDolar.Name = "txtPesosDolar";
            this.txtPesosDolar.ReadOnly = true;
            this.txtPesosDolar.Size = new System.Drawing.Size(100, 20);
            this.txtPesosDolar.TabIndex = 19;
            // 
            // txtPesosPesos
            // 
            this.txtPesosPesos.Location = new System.Drawing.Point(473, 111);
            this.txtPesosPesos.Name = "txtPesosPesos";
            this.txtPesosPesos.ReadOnly = true;
            this.txtPesosPesos.Size = new System.Drawing.Size(100, 20);
            this.txtPesosPesos.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 148);
            this.Controls.Add(this.txtPesosPesos);
            this.Controls.Add(this.txtPesosDolar);
            this.Controls.Add(this.txtPesosEuro);
            this.Controls.Add(this.txtDolarPesos);
            this.Controls.Add(this.txtDolarDolar);
            this.Controls.Add(this.txtDolarEuro);
            this.Controls.Add(this.txtEuroPesos);
            this.Controls.Add(this.txtEuroDolar);
            this.Controls.Add(this.txtEuroEuro);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_pesos);
            this.Controls.Add(this.btn_dolar);
            this.Controls.Add(this.btn_euro);
            this.Controls.Add(this.txtPesos);
            this.Controls.Add(this.txtDolar);
            this.Controls.Add(this.txtEuro);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEuro;
        private System.Windows.Forms.TextBox txtDolar;
        private System.Windows.Forms.TextBox txtPesos;
        private System.Windows.Forms.Button btn_euro;
        private System.Windows.Forms.Button btn_dolar;
        private System.Windows.Forms.Button btn_pesos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEuroEuro;
        private System.Windows.Forms.TextBox txtEuroDolar;
        private System.Windows.Forms.TextBox txtEuroPesos;
        private System.Windows.Forms.TextBox txtDolarEuro;
        private System.Windows.Forms.TextBox txtDolarDolar;
        private System.Windows.Forms.TextBox txtDolarPesos;
        private System.Windows.Forms.TextBox txtPesosEuro;
        private System.Windows.Forms.TextBox txtPesosDolar;
        private System.Windows.Forms.TextBox txtPesosPesos;
    }
}

