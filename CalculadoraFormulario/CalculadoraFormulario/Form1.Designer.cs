
namespace CalculadoraFormulario
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
            this.TxtVariable1 = new System.Windows.Forms.TextBox();
            this.TxtVariable2 = new System.Windows.Forms.TextBox();
            this.labelValor1 = new System.Windows.Forms.Label();
            this.labelValor2 = new System.Windows.Forms.Label();
            this.Suma = new System.Windows.Forms.Button();
            this.Resta = new System.Windows.Forms.Button();
            this.Mutiplicacion = new System.Windows.Forms.Button();
            this.Division = new System.Windows.Forms.Button();
            this.labelResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxtVariable1
            // 
            this.TxtVariable1.Location = new System.Drawing.Point(64, 130);
            this.TxtVariable1.Name = "TxtVariable1";
            this.TxtVariable1.Size = new System.Drawing.Size(100, 20);
            this.TxtVariable1.TabIndex = 0;
            // 
            // TxtVariable2
            // 
            this.TxtVariable2.Location = new System.Drawing.Point(64, 197);
            this.TxtVariable2.Name = "TxtVariable2";
            this.TxtVariable2.Size = new System.Drawing.Size(100, 20);
            this.TxtVariable2.TabIndex = 1;
            // 
            // labelValor1
            // 
            this.labelValor1.AutoSize = true;
            this.labelValor1.Location = new System.Drawing.Point(51, 111);
            this.labelValor1.Name = "labelValor1";
            this.labelValor1.Size = new System.Drawing.Size(40, 13);
            this.labelValor1.TabIndex = 2;
            this.labelValor1.Text = "Valor 1";
            // 
            // labelValor2
            // 
            this.labelValor2.AutoSize = true;
            this.labelValor2.Location = new System.Drawing.Point(54, 178);
            this.labelValor2.Name = "labelValor2";
            this.labelValor2.Size = new System.Drawing.Size(40, 13);
            this.labelValor2.TabIndex = 3;
            this.labelValor2.Text = "Valor 2";
            // 
            // Suma
            // 
            this.Suma.Location = new System.Drawing.Point(224, 101);
            this.Suma.Name = "Suma";
            this.Suma.Size = new System.Drawing.Size(75, 23);
            this.Suma.TabIndex = 4;
            this.Suma.Text = "Suma";
            this.Suma.UseVisualStyleBackColor = true;
            this.Suma.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Suma_MouseClick);
            // 
            // Resta
            // 
            this.Resta.Location = new System.Drawing.Point(224, 147);
            this.Resta.Name = "Resta";
            this.Resta.Size = new System.Drawing.Size(75, 23);
            this.Resta.TabIndex = 5;
            this.Resta.Text = "Resta";
            this.Resta.UseVisualStyleBackColor = true;
            this.Resta.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Resta_MouseClick);
            // 
            // Mutiplicacion
            // 
            this.Mutiplicacion.Location = new System.Drawing.Point(224, 197);
            this.Mutiplicacion.Name = "Mutiplicacion";
            this.Mutiplicacion.Size = new System.Drawing.Size(75, 23);
            this.Mutiplicacion.TabIndex = 6;
            this.Mutiplicacion.Text = "Multiplicacion";
            this.Mutiplicacion.UseVisualStyleBackColor = true;
            this.Mutiplicacion.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Mutiplicacion_MouseClick);
            // 
            // Division
            // 
            this.Division.Location = new System.Drawing.Point(224, 250);
            this.Division.Name = "Division";
            this.Division.Size = new System.Drawing.Size(75, 23);
            this.Division.TabIndex = 7;
            this.Division.Text = "Division";
            this.Division.UseVisualStyleBackColor = true;
            this.Division.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Division_MouseClick);
            // 
            // labelResultado
            // 
            this.labelResultado.AutoSize = true;
            this.labelResultado.Location = new System.Drawing.Point(454, 177);
            this.labelResultado.Name = "labelResultado";
            this.labelResultado.Size = new System.Drawing.Size(55, 13);
            this.labelResultado.TabIndex = 8;
            this.labelResultado.Text = "Resultado";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelResultado);
            this.Controls.Add(this.Division);
            this.Controls.Add(this.Mutiplicacion);
            this.Controls.Add(this.Resta);
            this.Controls.Add(this.Suma);
            this.Controls.Add(this.labelValor2);
            this.Controls.Add(this.labelValor1);
            this.Controls.Add(this.TxtVariable2);
            this.Controls.Add(this.TxtVariable1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtVariable1;
        private System.Windows.Forms.TextBox TxtVariable2;
        private System.Windows.Forms.Label labelValor1;
        private System.Windows.Forms.Label labelValor2;
        private System.Windows.Forms.Button Suma;
        private System.Windows.Forms.Button Resta;
        private System.Windows.Forms.Button Mutiplicacion;
        private System.Windows.Forms.Button Division;
        private System.Windows.Forms.Label labelResultado;
    }
}

