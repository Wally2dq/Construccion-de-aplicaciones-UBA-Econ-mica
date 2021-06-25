using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDeEntidades.Entidades;
using CapaDeNegocio;
using CapaDeNegocio.Negocio;

namespace VentaDeHardware.Productos.ProductoOpciones
{
    public partial class FormProductoLista : Form
    {
        private Form _menuProd;
        private NegocioVentaDeHar _negocio = new NegocioVentaDeHar();
        private NegocioProducto negocio = new NegocioProducto();

        public FormProductoLista(Form form)
        {
            _menuProd = (Form)form;
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            _menuProd.Show();
            this.Close();
        }

        private void FormProductoLista_Load(object sender, EventArgs e)
        {
            listBoxProductos.DataSource = negocio.traerListaProductos();

        }
    }
}
