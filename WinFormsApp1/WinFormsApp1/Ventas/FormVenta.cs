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
using VentaDeHardware;
using VentaDeHardware.Ventas.VentasOpciones;

namespace VentaDeHardware.Ventas
{
    public partial class FormVenta : Form
    {
        private Form _formulario;

        public FormVenta(Form formulario)
        {
            _formulario = (FormMenuPrincipal)formulario;
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            _formulario.Show();
            this.Close();
        }

        private void btnIniciarVenta_Click(object sender, EventArgs e)
        {
            FormNuevaVenta formularioNuevaVenta = new FormNuevaVenta(this);

            formularioNuevaVenta.Show();
            this.Hide();
        }

        private void btnListarVentaXCliente_Click(object sender, EventArgs e)
        {
            FormListaVentas formularioListaVentas = new FormListaVentas(this);
            formularioListaVentas.Show();
            this.Hide();
        }

        private void btnClienteVentas_Click(object sender, EventArgs e)
        {
            FormBuscarVentasPorCliente ventasporCliente = new FormBuscarVentasPorCliente(this);

            ventasporCliente.Show();
            this.Hide();
        }
    }
}
