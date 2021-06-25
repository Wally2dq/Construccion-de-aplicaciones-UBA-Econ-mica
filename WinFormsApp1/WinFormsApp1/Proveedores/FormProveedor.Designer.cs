
namespace VentaDeHardware.Proveedores
{
    partial class FormProveedor
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
            this.btnAltaProveedor = new System.Windows.Forms.Button();
            this.Proveedor = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscarProveedor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAltaProveedor
            // 
            this.btnAltaProveedor.Location = new System.Drawing.Point(881, 81);
            this.btnAltaProveedor.Name = "btnAltaProveedor";
            this.btnAltaProveedor.Size = new System.Drawing.Size(177, 36);
            this.btnAltaProveedor.TabIndex = 0;
            this.btnAltaProveedor.Text = "Alta Proveedor";
            this.btnAltaProveedor.UseVisualStyleBackColor = true;
            this.btnAltaProveedor.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // Proveedor
            // 
            this.Proveedor.AutoSize = true;
            this.Proveedor.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.Proveedor.Location = new System.Drawing.Point(13, 13);
            this.Proveedor.Name = "Proveedor";
            this.Proveedor.Size = new System.Drawing.Size(104, 22);
            this.Proveedor.TabIndex = 1;
            this.Proveedor.Text = "Proveedores";
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(1012, 307);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 2;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(13, 81);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(810, 199);
            this.listBox1.TabIndex = 7;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(929, 224);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 8;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBuscarProveedor
            // 
            this.txtBuscarProveedor.Location = new System.Drawing.Point(977, 181);
            this.txtBuscarProveedor.Name = "txtBuscarProveedor";
            this.txtBuscarProveedor.Size = new System.Drawing.Size(100, 23);
            this.txtBuscarProveedor.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(851, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Buscar por Codigo";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(271, 286);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 48);
            this.button1.TabIndex = 11;
            this.button1.Text = "Cargar Todos";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // FormProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1099, 342);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBuscarProveedor);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.Proveedor);
            this.Controls.Add(this.btnAltaProveedor);
            this.Name = "FormProveedor";
            this.Text = "FormProveedor";
            this.Activated += new System.EventHandler(this.Refresh);
            this.Load += new System.EventHandler(this.FormProveedor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAltaProveedor;
        private System.Windows.Forms.Label Proveedor;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBuscarProveedor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}