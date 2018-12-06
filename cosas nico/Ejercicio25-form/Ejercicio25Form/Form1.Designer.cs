namespace Ejercicio25Form
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
            this.btonBinDec = new System.Windows.Forms.Button();
            this.btonDecBin = new System.Windows.Forms.Button();
            this.txtBin = new System.Windows.Forms.TextBox();
            this.txtBinDec = new System.Windows.Forms.TextBox();
            this.txtDec = new System.Windows.Forms.TextBox();
            this.txtDecBin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btonBinDec
            // 
            this.btonBinDec.Location = new System.Drawing.Point(221, 12);
            this.btonBinDec.Name = "btonBinDec";
            this.btonBinDec.Size = new System.Drawing.Size(75, 23);
            this.btonBinDec.TabIndex = 0;
            this.btonBinDec.Text = "->";
            this.btonBinDec.UseVisualStyleBackColor = true;
            this.btonBinDec.Click += new System.EventHandler(this.btonBinDec_Click);
            // 
            // btonDecBin
            // 
            this.btonDecBin.Location = new System.Drawing.Point(221, 54);
            this.btonDecBin.Name = "btonDecBin";
            this.btonDecBin.Size = new System.Drawing.Size(75, 23);
            this.btonDecBin.TabIndex = 1;
            this.btonDecBin.Text = "->";
            this.btonDecBin.UseVisualStyleBackColor = true;
            this.btonDecBin.Click += new System.EventHandler(this.btonDecBin_Click);
            // 
            // txtBin
            // 
            this.txtBin.Location = new System.Drawing.Point(102, 15);
            this.txtBin.Name = "txtBin";
            this.txtBin.Size = new System.Drawing.Size(100, 20);
            this.txtBin.TabIndex = 2;
            // 
            // txtBinDec
            // 
            this.txtBinDec.Location = new System.Drawing.Point(321, 14);
            this.txtBinDec.Name = "txtBinDec";
            this.txtBinDec.ReadOnly = true;
            this.txtBinDec.Size = new System.Drawing.Size(100, 20);
            this.txtBinDec.TabIndex = 3;
            // 
            // txtDec
            // 
            this.txtDec.Location = new System.Drawing.Point(102, 57);
            this.txtDec.Name = "txtDec";
            this.txtDec.Size = new System.Drawing.Size(100, 20);
            this.txtDec.TabIndex = 4;
            // 
            // txtDecBin
            // 
            this.txtDecBin.Location = new System.Drawing.Point(321, 57);
            this.txtDecBin.Name = "txtDecBin";
            this.txtDecBin.ReadOnly = true;
            this.txtDecBin.Size = new System.Drawing.Size(100, 20);
            this.txtDecBin.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Binario a decimal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Decimal a binario";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 86);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDecBin);
            this.Controls.Add(this.txtDec);
            this.Controls.Add(this.txtBinDec);
            this.Controls.Add(this.txtBin);
            this.Controls.Add(this.btonDecBin);
            this.Controls.Add(this.btonBinDec);
            this.Name = "Form1";
            this.Text = "Conversor binario decimal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btonBinDec;
        private System.Windows.Forms.Button btonDecBin;
        private System.Windows.Forms.TextBox txtBin;
        private System.Windows.Forms.TextBox txtBinDec;
        private System.Windows.Forms.TextBox txtDec;
        private System.Windows.Forms.TextBox txtDecBin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

