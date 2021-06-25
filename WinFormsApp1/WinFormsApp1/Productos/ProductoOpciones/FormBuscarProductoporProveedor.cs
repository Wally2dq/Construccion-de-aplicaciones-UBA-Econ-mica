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
using CapaDeNegocio;
using CapaDeNegocio.Validaciones;
using CapaDeNegocio.Ventas;

namespace VentaDeHardware.Productos.ProductoOpciones
{
    public partial class FormBuscarProductoporProveedor : Form
    {
        private Form _formulario;
        private Validar validar = new Validar();
        private NegocioProducto _negocioProducto = new NegocioProducto();
        private NegocioProveedor _negocioProveedor = new NegocioProveedor();

        public FormBuscarProductoporProveedor(Form formulario)
        {
            _formulario = formulario;

            InitializeComponent();
        }

        
        private void btnVolver_Click_1(object sender, EventArgs e)
        {

            _formulario.Show();
            this.Close();

        }

        private void FormBuscarVentasPorCliente_Load_1(object sender, EventArgs e)
        {
         
        }

        private void listBoxClientes_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            label3.Text = "";

            if (listBoxProveedor.SelectedIndex != -1)
            {
                try
                {
                    listBoxProductos.DataSource = null;

                    Proveedor p = (Proveedor)listBoxProveedor.SelectedValue;

                    int idProveedor = validar.ValidarNumeroEntero(p.Id.ToString());

                    listBoxProductos.DataSource = _negocioProducto.TraerPorProveedor(idProveedor);

                    List<Producto> _productos = _negocioProducto.TraerPorProveedor(idProveedor);

                    label3.Text = p.Ape;

                    if (_productos.Count==0)
                    {
                        MessageBox.Show($"No hay Productos comprados a {p.Ape}");
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int Buscar;

            label3.Text = "";

            try
            {
                Buscar = validar.ValidarNumeroEntero(txtCodigoProveedor.Text);

                List<Proveedor> proveedor = _negocioProveedor.TraerPorCodigo(Buscar);

                if (proveedor.Count!=0)
                {
                    listBoxProveedor.DataSource = null;

                    listBoxProveedor.DataSource = proveedor;

                    listBoxProveedor.SelectedIndex = -1;

                    
                }
                else
                {
                    MessageBox.Show($"No existe Proveedor con codigo {Buscar}");
                }
            }
            catch (ProveedorInexistenteException PIE) 
            {
                MessageBox.Show(PIE.Message);
            }
            catch (ValidarNumeroException cie)
            {
                MessageBox.Show(cie.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}