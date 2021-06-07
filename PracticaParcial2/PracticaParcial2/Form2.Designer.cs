
namespace PracticaParcial2
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxTipoPrestamo = new System.Windows.Forms.ListBox();
            this.textBoxLinea = new System.Windows.Forms.TextBox();
            this.textBoxTNA = new System.Windows.Forms.TextBox();
            this.textBoxMonto = new System.Windows.Forms.TextBox();
            this.textBoxPlazo = new System.Windows.Forms.TextBox();
            this.buttonSimular = new System.Windows.Forms.Button();
            this.textBoxCuotaCapital = new System.Windows.Forms.TextBox();
            this.textBoxCuotaInteres = new System.Windows.Forms.TextBox();
            this.textBoxCuotaTotal = new System.Windows.Forms.TextBox();
            this.buttonAlta = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(863, 440);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Volver";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tipo Prestamo";
            // 
            // listBoxTipoPrestamo
            // 
            this.listBoxTipoPrestamo.FormattingEnabled = true;
            this.listBoxTipoPrestamo.Location = new System.Drawing.Point(12, 58);
            this.listBoxTipoPrestamo.Name = "listBoxTipoPrestamo";
            this.listBoxTipoPrestamo.Size = new System.Drawing.Size(199, 264);
            this.listBoxTipoPrestamo.TabIndex = 2;
            this.listBoxTipoPrestamo.SelectedIndexChanged += new System.EventHandler(this.listBoxTipoPrestamo_SelectedIndexChanged);
            // 
            // textBoxLinea
            // 
            this.textBoxLinea.Enabled = false;
            this.textBoxLinea.Location = new System.Drawing.Point(287, 63);
            this.textBoxLinea.Name = "textBoxLinea";
            this.textBoxLinea.Size = new System.Drawing.Size(100, 20);
            this.textBoxLinea.TabIndex = 3;
            // 
            // textBoxTNA
            // 
            this.textBoxTNA.Enabled = false;
            this.textBoxTNA.Location = new System.Drawing.Point(287, 108);
            this.textBoxTNA.Name = "textBoxTNA";
            this.textBoxTNA.Size = new System.Drawing.Size(100, 20);
            this.textBoxTNA.TabIndex = 4;
            // 
            // textBoxMonto
            // 
            this.textBoxMonto.Location = new System.Drawing.Point(287, 155);
            this.textBoxMonto.Name = "textBoxMonto";
            this.textBoxMonto.Size = new System.Drawing.Size(100, 20);
            this.textBoxMonto.TabIndex = 5;
            // 
            // textBoxPlazo
            // 
            this.textBoxPlazo.Location = new System.Drawing.Point(287, 202);
            this.textBoxPlazo.Name = "textBoxPlazo";
            this.textBoxPlazo.Size = new System.Drawing.Size(100, 20);
            this.textBoxPlazo.TabIndex = 6;
            // 
            // buttonSimular
            // 
            this.buttonSimular.Location = new System.Drawing.Point(250, 247);
            this.buttonSimular.Name = "buttonSimular";
            this.buttonSimular.Size = new System.Drawing.Size(137, 28);
            this.buttonSimular.TabIndex = 7;
            this.buttonSimular.Text = "Simular";
            this.buttonSimular.UseVisualStyleBackColor = true;
            this.buttonSimular.Click += new System.EventHandler(this.buttonSimular_Click);
            // 
            // textBoxCuotaCapital
            // 
            this.textBoxCuotaCapital.Enabled = false;
            this.textBoxCuotaCapital.Location = new System.Drawing.Point(303, 297);
            this.textBoxCuotaCapital.Name = "textBoxCuotaCapital";
            this.textBoxCuotaCapital.Size = new System.Drawing.Size(100, 20);
            this.textBoxCuotaCapital.TabIndex = 8;
            // 
            // textBoxCuotaInteres
            // 
            this.textBoxCuotaInteres.Enabled = false;
            this.textBoxCuotaInteres.Location = new System.Drawing.Point(303, 342);
            this.textBoxCuotaInteres.Name = "textBoxCuotaInteres";
            this.textBoxCuotaInteres.Size = new System.Drawing.Size(100, 20);
            this.textBoxCuotaInteres.TabIndex = 9;
            // 
            // textBoxCuotaTotal
            // 
            this.textBoxCuotaTotal.Enabled = false;
            this.textBoxCuotaTotal.Location = new System.Drawing.Point(303, 385);
            this.textBoxCuotaTotal.Name = "textBoxCuotaTotal";
            this.textBoxCuotaTotal.Size = new System.Drawing.Size(100, 20);
            this.textBoxCuotaTotal.TabIndex = 10;
            // 
            // buttonAlta
            // 
            this.buttonAlta.Enabled = false;
            this.buttonAlta.Location = new System.Drawing.Point(250, 425);
            this.buttonAlta.Name = "buttonAlta";
            this.buttonAlta.Size = new System.Drawing.Size(137, 27);
            this.buttonAlta.TabIndex = 11;
            this.buttonAlta.Text = "Alta";
            this.buttonAlta.UseVisualStyleBackColor = true;
            this.buttonAlta.Click += new System.EventHandler(this.buttonAlta_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(231, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Linea";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(231, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "TNA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(231, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Monto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(234, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Plazo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(217, 300);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Cuota (Capital)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(220, 342);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Cuota (Inters)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(208, 388);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "CUOTA TOTAL";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(513, 63);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(414, 277);
            this.listBox1.TabIndex = 19;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(513, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Prestamos";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(630, 368);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Cuota Total";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(755, 365);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 22;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 475);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonAlta);
            this.Controls.Add(this.textBoxCuotaTotal);
            this.Controls.Add(this.textBoxCuotaInteres);
            this.Controls.Add(this.textBoxCuotaCapital);
            this.Controls.Add(this.buttonSimular);
            this.Controls.Add(this.textBoxPlazo);
            this.Controls.Add(this.textBoxMonto);
            this.Controls.Add(this.textBoxTNA);
            this.Controls.Add(this.textBoxLinea);
            this.Controls.Add(this.listBoxTipoPrestamo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxTipoPrestamo;
        private System.Windows.Forms.TextBox textBoxLinea;
        private System.Windows.Forms.TextBox textBoxTNA;
        private System.Windows.Forms.TextBox textBoxMonto;
        private System.Windows.Forms.TextBox textBoxPlazo;
        private System.Windows.Forms.Button buttonSimular;
        private System.Windows.Forms.TextBox textBoxCuotaCapital;
        private System.Windows.Forms.TextBox textBoxCuotaInteres;
        private System.Windows.Forms.TextBox textBoxCuotaTotal;
        private System.Windows.Forms.Button buttonAlta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox1;
    }
}