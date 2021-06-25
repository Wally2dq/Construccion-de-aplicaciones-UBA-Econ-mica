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
using CapaDeNegocio.Negocio;
using VentaDeHardware.Proveedores.ProveedorOpciones;
using CapaDeNegocio.Validaciones;


namespace VentaDeHardware.Productos.ProductoOpciones
{
    public partial class FormAltaProducto : Form
    {
        private Form _menuProd;
        private NegocioVentaDeHar _negocio = new NegocioVentaDeHar();
        private NegocioProducto _negocioProducto = new NegocioProducto();
        private Validar _validar = new Validar();
        private NegocioProveedor _negocioProveedor = new NegocioProveedor();

        public FormAltaProducto(FormProducto form)
        {
            _menuProd = (Form)form;

            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            _menuProd.Show();
            this.Close();
        }

        private void btnAgregarProveedor_Click(object sender, EventArgs e)
        {
            FormAltaProveedor proveedor = new FormAltaProveedor(this);
            proveedor.Show();
            this.Hide();
        }

        private void Refresh(object sender, EventArgs e)
        {
            CargarListaBox();
            txtUsuario.Focus();
        }

        private void CargarListaBox()
        {

            listBox1.DataSource = null;
            listBox1.DataSource = _negocioProveedor.TraerListaProveedores();
            listBox1.SelectedIndex = -1;
        }

        private void limpiar()
        {
            txtCantidad.Clear();
            txtNombre.Clear();
            txtPrecioUnitario.Clear();
            txtUsuario.Clear();
            txtCategoria.Clear();

            listBox1.SelectedIndex = -1;
            
        }
        

        private void btnAlta_Click(object sender, EventArgs e)
        {
            string nombre;
            int stock;
            double precio;
            DateTime date;
            int usuario;
            int categoria;

            int idProveedorEntrada;


            try
            {
                nombre = _validar.ValidarString(txtNombre.Text);
                stock = _validar.ValidarNumeroEntero(txtCantidad.Text);
                precio = _validar.ValidarNumeroDouble(txtPrecioUnitario.Text);
                usuario = _validar.ValidarNumeroEntero(txtUsuario.Text);
                categoria = _validar.ValidarNumeroEntero(txtCategoria.Text);
                date = DateTime.Now;

                Proveedor proveedor = (Proveedor) listBox1.SelectedValue;

                idProveedorEntrada = _validar.ValidarNumeroEntero(proveedor.Id.ToString());

                Producto P = new Producto();
                P.Nombre = nombre;
                P.Stock = stock;
                P.Precio = precio;
                P.Usuario = usuario;
                P.FechaAlta = DateTime.Now;
                P.idCategoria = categoria;
                P.idProveedor = idProveedorEntrada;

                if (P != null) 
                {
                    TransactionResult resultado = _negocioProducto.insertarProducto(P);

                    if (resultado.IsOk == true)
                    {
                        MessageBox.Show("El producto con Codigo " + P.Usuario + " se ha cargado correctamente");
                    }
                    else
                    {
                        MessageBox.Show("Error en la carga del producto");
                    }
                }
                else 
                {
                    MessageBox.Show("Ingrese datos Validos");
                }

                limpiar();
                
            } catch (ProductoExistenteException exc)
            {
                MessageBox.Show(exc.Message);
            }
            catch (ValidarStringException VSE)
            {
                MessageBox.Show(VSE.Message);
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

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                btnAlta.Enabled = true;
            }
            else 
            {
                btnAlta.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormAltaProveedor alta = new FormAltaProveedor(this);
            alta.Show();
            this.Hide();
        }
    }
}
