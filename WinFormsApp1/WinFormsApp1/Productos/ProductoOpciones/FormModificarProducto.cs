using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDeNegocio.Validaciones;
using CapaDeNegocio;
using CapaDeEntidades.Entidades;
using CapaDeEntidades.Entidades.Exepction;

namespace VentaDeHardware.Productos.ProductoOpciones
{
    public partial class FormModificarProducto : Form
    {
        private Form _formulario;
        private Validar _validar = new Validar();
        private NegocioProducto _negocioProducto = new NegocioProducto();
        private Producto _modificar;

        public FormModificarProducto(Form formulario)
        {
            _formulario = (Form)formulario;
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _formulario.Show();
            this.Close();
        }

        private void Limpiar()
        {
            txtBuscar.Clear(); 
            txtCodigo.Clear();
            txtNombre.Clear();
            txtCategoria.Clear();
            txtStockActual.Clear();
            txtPrecioActual.Clear();
            txtAgregarStock.Clear();
            txtPrecioActualizar.Clear();

            radioPrecio.Checked = false;
            radioStock.Checked = false;

            btnModificar.Enabled = false;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int Codigo;

            try
            {
                Codigo = _validar.ValidarNumeroEntero(txtBuscar.Text);

                Producto p = _negocioProducto.buscarProducto(Codigo);

                if (p != null)
                {

                    Limpiar();
                    txtCodigo.Text = p.Usuario.ToString();
                    txtNombre.Text = p.Nombre;
                    txtCategoria.Text = p.idCategoria.ToString();
                    txtPrecioActual.Text = p.Precio.ToString();
                    txtStockActual.Text = p.Stock.ToString();

                    _modificar = p;
                }
                else 
                {
                    MessageBox.Show("No se encuentra Producto con el Codigo "+Codigo);
                    Limpiar();
                }
                
            }
            catch (ValidarNumeroException vne)
            {
                MessageBox.Show(vne.Message);
                Limpiar();
            }
            catch (ProductoInexistenteException PIE)
            {
                MessageBox.Show(PIE.Message);
                Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void radioStock_CheckedChanged(object sender, EventArgs e)
        {
            if (radioStock.Checked == true)
            {
                txtAgregarStock.Enabled = true;

                btnModificar.Enabled = true;

                txtPrecioActualizar.Clear();

                txtPrecioActualizar.Enabled = false;
            }
            else 
            {
                txtAgregarStock.Enabled = false;
            }
        }

        private void radioPrecio_CheckedChanged(object sender, EventArgs e)
        {
            if (radioPrecio.Checked == true)
            {
                txtPrecioActualizar.Enabled = true;

                btnModificar.Enabled = true;

                txtAgregarStock.Clear();

                txtAgregarStock.Enabled = false;

            }
            else
            {
                txtPrecioActualizar.Enabled = false;
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (radioStock.Checked == true)
            {
                int StockActualizar;
                int StockActualizado;

                try
                {
                    StockActualizar = _validar.ValidarNumeroEntero(txtAgregarStock.Text);

                    Producto p = _modificar;

                    StockActualizado = p.AgregarStock(StockActualizar);

                    TransactionResult t = _negocioProducto.ModificarProducto(p);

                    if (t.IsOk == true)
                    {
                        MessageBox.Show("Stock Actual : " + p.Stock);

                        Limpiar();
                        txtCodigo.Text = p.Usuario.ToString();
                        txtNombre.Text = p.Nombre;
                        txtCategoria.Text = p.idCategoria.ToString();
                        txtPrecioActual.Text = p.Precio.ToString();
                        txtStockActual.Text = p.Stock.ToString();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo Actualizar el Stock");
                    }

                }
                catch (ValidarNumeroException vne)
                {
                    MessageBox.Show(vne.Message);
                }
                catch (ProductoStockAgregarException PAE)
                {
                    MessageBox.Show(PAE.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (radioPrecio.Checked == true) 
            {
                double PrecioActualizar;
                double PrecioActualizado;

                try
                {
                    PrecioActualizar = _validar.ValidarNumeroEntero(txtPrecioActualizar.Text);

                    Producto p = _modificar;

                    PrecioActualizado = p.ModificarPrecio(PrecioActualizar);

                    TransactionResult t = _negocioProducto.ModificarProducto(p);

                    if (t.IsOk == true)
                    {
                        MessageBox.Show("Precio Actual : " + p.Precio);

                        Limpiar();
                        txtCodigo.Text = p.Usuario.ToString();
                        txtNombre.Text = p.Nombre;
                        txtCategoria.Text = p.idCategoria.ToString();
                        txtPrecioActual.Text = p.Precio.ToString();
                        txtStockActual.Text = p.Stock.ToString();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo Actualizar el Precio");
                    }

                }
                catch (ValidarNumeroException vne)
                {
                    MessageBox.Show(vne.Message);
                }
                catch (PrecioNegativoExcepction PNE)
                {
                    MessageBox.Show(PNE.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
