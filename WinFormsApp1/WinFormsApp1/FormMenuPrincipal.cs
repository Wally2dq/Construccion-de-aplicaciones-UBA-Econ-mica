using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDeNegocio.Negocio;
using VentaDeHardware.Productos;
using VentaDeHardware.Proveedores;
using VentaDeHardware.Ventas;

namespace VentaDeHardware
{
    public partial class FormMenuPrincipal : Form
    {
        private Form _inicio;

        public FormMenuPrincipal(Form form)
        {
            _inicio = (Form)form;

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _inicio.Show();

            this.Close();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            FormClientes formularioCliente = new FormClientes(this);

            formularioCliente.Show();
            this.Hide();
        }

        private void btnProducto_Click(object sender, EventArgs e)
        {
            FormProducto formularioProducto = new FormProducto(this);

            formularioProducto.Show();
            this.Hide();
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            FormProveedor formularioProveedor = new FormProveedor(this);

            formularioProveedor.Show();
            this.Hide();
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            FormVenta formularioVenta = new FormVenta(this);

            formularioVenta.Show();
            this.Hide();
        }
    }
}
