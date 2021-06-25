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
using CapaDeNegocio.Validaciones;
using CapaDeEntidades.Entidades.Exepction;
using VentaDeHardware.Proveedores.ProveedorOpciones;

namespace VentaDeHardware.Proveedores
{
    public partial class FormProveedor : Form
    {
        private Form _menuProd;
        private NegocioVentaDeHar _negocio = new NegocioVentaDeHar();
        private NegocioProveedor negocio = new NegocioProveedor();
        private Validar validar = new Validar();

        public FormProveedor(Form form)
        {
            _menuProd = (Form)form;
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            _menuProd.Show();
            this.Close();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            FormAltaProveedor formularioAltaProveedor = new FormAltaProveedor(this);

            formularioAltaProveedor.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
       
        private void FormProveedor_Load(object sender, EventArgs e)
        {
            Refresh();
        }

        private void Refresh(object sender, EventArgs e)
        {
            
            CargarComboProductos();
        }
       

        private void CargarComboProductos()
        {
            listBox1.DataSource = null;
            listBox1.DataSource = negocio.TraerListaProveedores();
            listBox1.SelectedIndex = -1;
        }


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int Buscar;


            try
            {
                Buscar = validar.ValidarNumeroEntero(txtBuscarProveedor.Text);

                List<Proveedor> proveedor = negocio.TraerPorCodigo(Buscar);

                if (proveedor.Count != 0)
                {
                    listBox1.DataSource = null;

                    listBox1.DataSource = proveedor;

                    listBox1.SelectedIndex = -1;


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

        private void button1_Click_1(object sender, EventArgs e)
        {
            txtBuscarProveedor.Clear();
            CargarComboProductos();
        }
    }
}
