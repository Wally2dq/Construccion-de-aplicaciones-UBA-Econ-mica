
namespace VentaDeHardware.Ventas
{
    partial class FormVenta
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnIniciarVenta = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnListarVentaXCliente = new System.Windows.Forms.Button();
            this.btnClienteVentas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ventas";
            // 
            // btnIniciarVenta
            // 
            this.btnIniciarVenta.Location = new System.Drawing.Point(101, 56);
            this.btnIniciarVenta.Name = "btnIniciarVenta";
            this.btnIniciarVenta.Size = new System.Drawing.Size(234, 37);
            this.btnIniciarVenta.TabIndex = 1;
            this.btnIniciarVenta.Text = "Iniciar una Venta";
            this.btnIniciarVenta.UseVisualStyleBackColor = true;
            this.btnIniciarVenta.Click += new System.EventHandler(this.btnIniciarVenta_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(361, 262);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 2;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnListarVentaXCliente
            // 
            this.btnListarVentaXCliente.Location = new System.Drawing.Point(101, 128);
            this.btnListarVentaXCliente.Name = "btnListarVentaXCliente";
            this.btnListarVentaXCliente.Size = new System.Drawing.Size(234, 33);
            this.btnListarVentaXCliente.TabIndex = 3;
            this.btnListarVentaXCliente.Text = "Listar Ventas";
            this.btnListarVentaXCliente.UseVisualStyleBackColor = true;
            this.btnListarVentaXCliente.Click += new System.EventHandler(this.btnListarVentaXCliente_Click);
            // 
            // btnClienteVentas
            // 
            this.btnClienteVentas.Location = new System.Drawing.Point(101, 192);
            this.btnClienteVentas.Name = "btnClienteVentas";
            this.btnClienteVentas.Size = new System.Drawing.Size(234, 33);
            this.btnClienteVentas.TabIndex = 4;
            this.btnClienteVentas.Text = "Listar Ventas por Clientes";
            this.btnClienteVentas.UseVisualStyleBackColor = true;
            this.btnClienteVentas.Click += new System.EventHandler(this.btnClienteVentas_Click);
            // 
            // FormVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(448, 297);
            this.Controls.Add(this.btnClienteVentas);
            this.Controls.Add(this.btnListarVentaXCliente);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnIniciarVenta);
            this.Controls.Add(this.label1);
            this.Name = "FormVenta";
            this.Text = "FormVenta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnIniciarVenta;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnListarVentaXCliente;
        private System.Windows.Forms.Button btnClienteVentas;
    }
}