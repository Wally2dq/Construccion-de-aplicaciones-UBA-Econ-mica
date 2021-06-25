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
using CapaDeNegocio.Clientes;
using CapaDeNegocio.Validaciones;
using CapaDeNegocio.Ventas;

namespace VentaDeHardware.Ventas.VentasOpciones
{
    public partial class FormBuscarVentasPorCliente : Form
    {
        private Form _formulario;
        private NegocioClientes _negocioCliente = new NegocioClientes();
        private Validar validar = new Validar();
        private NegocioVentas _negocioVentas = new NegocioVentas();

        public FormBuscarVentasPorCliente(Form formulario)
        {
            _formulario = formulario;

            InitializeComponent();
        }

        
        private void CargarBoxCliente()
        {
            listBoxClientes.DataSource = null;
            listBoxClientes.DataSource = _negocioCliente.TraerListaClientes();
            listBoxClientes.SelectedIndex = -1;
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

            if (listBoxClientes.SelectedIndex != -1)
            {
                try
                {
                    listBoxVentas.DataSource = null;

                    Cliente c = (Cliente)listBoxClientes.SelectedValue;

                    int Usuario = validar.ValidarNumeroEntero(c.usuario);

                    listBoxVentas.DataSource = _negocioVentas.TraerPorUsuario(Usuario);

                    label3.Text = c.Ape;

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

                    label3.Text = cliente.Ape;
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
            catch (ValidarNumeroException vne) 
            {
                MessageBox.Show(vne.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}