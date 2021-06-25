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
using VentaDeHardware.Ventas;
using CapaDeNegocio.Clientes;
using CapaDeNegocio;
using CapaDeNegocio.Validaciones;
using CapaDeEntidades.Entidades.Exepction;
using CapaDeEntidades.Entidades;
using CapaDeNegocio.Ventas;
using VentaDeHardware.Ventas.VentasOpciones.ProcesoDeVentas;

namespace VentaDeHardware.Ventas.VentasOpciones
{
    public partial class FormNuevaVenta : Form
    {

        private Form _formulario;

        private NegocioVentaDeHar _negocio = new NegocioVentaDeHar();
        private NegocioClientes _negocioCliente = new NegocioClientes();
        private NegocioProducto _negocioProducto = new NegocioProducto();
        private NegocioVentas _negocioVentas = new NegocioVentas();

        private Validar validar = new Validar();

        public FormNuevaVenta(Form formulario)
        {
            _formulario = (Form)formulario;

            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            _formulario.Show();
            this.Close();
        }

        private void FormNuevaVenta_Load(object sender, EventArgs e)
        {
        }

        private void btnMostrarClientesTodos_Click(object sender, EventArgs e)
        {
            listBoxClientes.DataSource = null;
            listBoxClientes.DataSource = _negocioCliente.TraerListaClientes();
            listBoxClientes.SelectedIndex = -1;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int Buscar;

            try
            {
                Buscar = validar.ValidarNumeroEntero(txtCodigoCliente.Text);

                Cliente cliente = _negocioCliente.BuscarCliente(Buscar.ToString());

                if (cliente != null)
                {
                    listBoxClientes.DataSource = null;

                    List<Cliente> _c = new List<Cliente>();
                    _c.Add(cliente);

                    listBoxClientes.DataSource = _c;

                    listBoxClientes.SelectedIndex = -1;
                }
                else
                {
                    MessageBox.Show("No existe cliente");
                }
            }
            catch (ClienteInexisteException cie)
            {
                MessageBox.Show(cie.Message);
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        
        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            Cliente C = (Cliente)listBoxClientes.SelectedValue;

            FormSelectProdVentas ventas = new FormSelectProdVentas(this,C);
            ventas.Show();
            this.Hide();
        }

        private void listBoxClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxClientes.SelectedIndex == -1)
            {
                btnSiguiente.Enabled = false;
            }
            else 
            {
                btnSiguiente.Enabled = true;
            }
        }

       
    }
}
