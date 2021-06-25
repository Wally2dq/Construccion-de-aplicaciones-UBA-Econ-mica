using CapaDeNegocio;
using CapaDeNegocio.Clientes;
using CapaDeNegocio.Negocio;
using CapaDeNegocio.Ventas;
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
using CapaDeEntidades.Entidades.Exepction;
using CapaDeNegocio.Validaciones;

namespace VentaDeHardware.Ventas.VentasOpciones.ProcesoDeVentas
{
    public partial class FormSelectProdVentas : Form
    {
        private Form _formulario;

        private Validar _validar = new Validar();
        private NegocioVentaDeHar _negocio = new NegocioVentaDeHar();
        private NegocioClientes _negocioCliente = new NegocioClientes();
        private NegocioProducto _negocioProducto = new NegocioProducto();
        private NegocioVentas _negocioVentas = new NegocioVentas();
        private Cliente _cliente;

        private int _cantidad;

        public FormSelectProdVentas(Form formulario, Cliente clienteIngreso)
        {
            _formulario = (Form)formulario;
            _cliente = (Cliente)clienteIngreso;
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            _formulario.Show();
            this.Close();
        }

        public void Limpiar() 
        {
            txtTotal.Clear();
            txtCantidad.Clear();
        }

        private void FormSelectProdVentas_Load(object sender, EventArgs e)
        {
            label6.Text = _cliente.Nombre;
        }

        private void btnMostrarProductosLista_Click(object sender, EventArgs e)
        {
            listBoxProductos.DataSource = null;
            listBoxProductos.DataSource = _negocioProducto.traerListaProductos();
            listBoxProductos.SelectedIndex = -1;
        }

        private void btnBuscarProd_Click(object sender, EventArgs e)
        {
            int Buscar;

            try
            {
                Buscar = _validar.ValidarNumeroEntero(txtBuscarProducto.Text);

                Producto producto = _negocioProducto.buscarProducto(Buscar);

                if (producto != null)
                {
                    listBoxProductos.DataSource = null;
                    List<Producto> _p = new List<Producto>();
                    _p.Add(producto);

                    listBoxProductos.DataSource = _p;

                    listBoxProductos.SelectedIndex = -1;
                }
                else
                {
                    MessageBox.Show("No existe Producto");
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcularTotal_Click(object sender, EventArgs e)
        {
            int Cantidad;
            int CantidadRestante;

            txtTotal.Clear();

            try
            {
                Producto p = (Producto)listBoxProductos.SelectedValue;

                Cantidad = _validar.ValidarNumeroEntero(txtCantidad.Text);

                CantidadRestante = p.RestarStock(Cantidad);

                txtTotal.Text = p.CalcularTotal(Cantidad).ToString("0.00");
                _cantidad = Cantidad;

                if (txtTotal.Text != "")
                {
                    btnConfirmarCompra.Enabled = true;
                }
                else
                {
                    btnConfirmarCompra.Enabled = false;
                }

            }
            catch (ValidarNumeroException VNE) 
            {
                MessageBox.Show(VNE.Message);
            }
            catch (NoHayStockSuficienteException NHSE)
            {
                MessageBox.Show(NHSE.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void listBoxProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxProductos.SelectedIndex != -1)
            {
                btnCalcularTotal.Enabled = true;
            }
            else 
            {
                btnCalcularTotal.Enabled = false;
            }
        }

        private void btnConfirmarCompra_Click(object sender, EventArgs e)
        {
            try
            {
                Producto p = (Producto)listBoxProductos.SelectedValue;
                Cliente c = _cliente;

                int Usuario = _validar.ValidarNumeroEntero(c.usuario);
                int IdProducto = _validar.ValidarNumeroEntero(p.id);

                Venta venta = new Venta(c.id, Usuario, IdProducto, _cantidad, DateTime.Now);

                TransactionResult t = _negocioVentas.AltaVenta(venta);

                if (t.IsOk == true) 
                {
                    p.Stock = p.RestarStock(venta.cantidad);

                    TransactionResult t2 = _negocioProducto.ModificarProducto(p);

                    if (t2.IsOk == true)
                    {
                        MessageBox.Show("Venta realizada");

                        Limpiar();
                        _formulario.Show();
                        this.Close();
                    }

                }
                else 
                {
                    MessageBox.Show("No se pudo realizar el alta");
                }

            }
            catch (ValidarNumeroException VNE) 
            {
                MessageBox.Show(VNE.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
