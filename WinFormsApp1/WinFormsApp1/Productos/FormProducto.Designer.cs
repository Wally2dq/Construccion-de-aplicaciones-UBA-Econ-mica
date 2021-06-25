
namespace VentaDeHardware.Productos
{
    partial class FormProducto
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
            this.btnAlta = new System.Windows.Forms.Button();
            this.btnListaProducto = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnAgregarStock = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnBuscarPorCodigo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Productos";
            // 
            // btnAlta
            // 
            this.btnAlta.Location = new System.Drawing.Point(78, 64);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(168, 32);
            this.btnAlta.TabIndex = 1;
            this.btnAlta.Text = "Alta Producto";
            this.btnAlta.UseVisualStyleBackColor = true;
            this.btnAlta.Click += new System.EventHandler(this.btnAlta_Click);
            // 
            // btnListaProducto
            // 
            this.btnListaProducto.Location = new System.Drawing.Point(78, 186);
            this.btnListaProducto.Name = "btnListaProducto";
            this.btnListaProducto.Size = new System.Drawing.Size(168, 31);
            this.btnListaProducto.TabIndex = 2;
            this.btnListaProducto.Text = "Lista De Productos";
            this.btnListaProducto.UseVisualStyleBackColor = true;
            this.btnListaProducto.Click += new System.EventHandler(this.btnListaProducto_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(254, 363);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 3;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnAgregarStock
            // 
            this.btnAgregarStock.Location = new System.Drawing.Point(80, 124);
            this.btnAgregarStock.Name = "btnAgregarStock";
            this.btnAgregarStock.Size = new System.Drawing.Size(166, 43);
            this.btnAgregarStock.TabIndex = 4;
            this.btnAgregarStock.Text = "Agregar Stock y Modificar Precio";
            this.btnAgregarStock.UseVisualStyleBackColor = true;
            this.btnAgregarStock.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(78, 239);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(168, 31);
            this.btnBuscar.TabIndex = 5;
            this.btnBuscar.Text = "Buscar Producto";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnBuscarPorCodigo
            // 
            this.btnBuscarPorCodigo.Location = new System.Drawing.Point(78, 296);
            this.btnBuscarPorCodigo.Name = "btnBuscarPorCodigo";
            this.btnBuscarPorCodigo.Size = new System.Drawing.Size(168, 51);
            this.btnBuscarPorCodigo.TabIndex = 6;
            this.btnBuscarPorCodigo.Text = "Buscar Producto por Cod Proveedor";
            this.btnBuscarPorCodigo.UseVisualStyleBackColor = true;
            this.btnBuscarPorCodigo.Click += new System.EventHandler(this.btnBuscarPorCodigo_Click);
            // 
            // FormProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(341, 398);
            this.Controls.Add(this.btnBuscarPorCodigo);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnAgregarStock);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnListaProducto);
            this.Controls.Add(this.btnAlta);
            this.Controls.Add(this.label1);
            this.Name = "FormProducto";
            this.Text = "FormProducto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAlta;
        private System.Windows.Forms.Button btnListaProducto;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnAgregarStock;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnBuscarPorCodigo;
    }
}