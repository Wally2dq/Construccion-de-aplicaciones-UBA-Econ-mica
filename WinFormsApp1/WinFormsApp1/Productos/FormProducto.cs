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
using VentaDeHardware.Productos.ProductoOpciones;

namespace VentaDeHardware.Productos
{
    public partial class FormProducto : Form
    {
        private Form _menu;

        public FormProducto(Form form)
        {
            _menu = (Form)form;

            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            _menu.Show();
            this.Close();
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            FormAltaProducto formularioAltaProd = new FormAltaProducto(this);

            formularioAltaProd.Show();
            this.Hide();

        }

        private void btnListaProducto_Click(object sender, EventArgs e)
        {
            FormProductoLista formularioListaProductos = new FormProductoLista(this);

            formularioListaProductos.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormModificarProducto modificar = new FormModificarProducto(this);
            modificar.Show();
            this.Hide();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            FormBuscarProducto buscar = new FormBuscarProducto(this);
            buscar.Show();
            this.Hide();
        }

        private void btnBuscarPorCodigo_Click(object sender, EventArgs e)
        {
            FormBuscarProductoporProveedor buscar = new FormBuscarProductoporProveedor(this);
            buscar.Show();
            this.Hide();
        }
    }
}
