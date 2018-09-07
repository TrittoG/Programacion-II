namespace ejercicio25
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.bTod = new System.Windows.Forms.TextBox();
            this.dTob = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(214, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(31, 20);
            this.button1.TabIndex = 0;
            this.button1.Text = "->";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(214, 73);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(30, 21);
            this.button2.TabIndex = 1;
            this.button2.Text = "->";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // bTod
            // 
            this.bTod.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.bTod.ForeColor = System.Drawing.Color.YellowGreen;
            this.bTod.Location = new System.Drawing.Point(98, 33);
            this.bTod.Name = "bTod";
            this.bTod.Size = new System.Drawing.Size(110, 20);
            this.bTod.TabIndex = 2;
            // 
            // dTob
            // 
            this.dTob.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.dTob.ForeColor = System.Drawing.Color.YellowGreen;
            this.dTob.Location = new System.Drawing.Point(98, 73);
            this.dTob.Name = "dTob";
            this.dTob.Size = new System.Drawing.Size(110, 20);
            this.dTob.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox3.ForeColor = System.Drawing.Color.YellowGreen;
            this.textBox3.Location = new System.Drawing.Point(257, 33);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(115, 20);
            this.textBox3.TabIndex = 4;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox4.ForeColor = System.Drawing.Color.YellowGreen;
            this.textBox4.Location = new System.Drawing.Point(250, 73);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(122, 20);
            this.textBox4.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Binario a Decimal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Decial a Binario";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(446, 141);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.dTob);
            this.Controls.Add(this.bTod);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.ForeColor = System.Drawing.Color.DarkOrange;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox bTod;
        private System.Windows.Forms.TextBox dTob;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

