using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VentaDeHardware;
using CapaDeNegocio.Negocio;
using CapaDeNegocio.Validaciones;
using CapaDeEntidades.Entidades.Exepction;
using CapaDeEntidades.Entidades;
using CapaDeNegocio.Clientes;

namespace VentaDeHardware.Clientes.Clientes_Opciones
{
    public partial class FormBuscarCliente : Form
    {
        private Form _fomulario;
        private NegocioVentaDeHar _negocio = new NegocioVentaDeHar();
        private Validar validacion = new Validar();
        private NegocioClientes _clientes = new NegocioClientes();

        public FormBuscarCliente(Form formulario)
        {
            _fomulario = (FormClientes)formulario;
            InitializeComponent();
        }

        public void Limpiar() 
        {
            txtBuscar.Clear();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            _fomulario.Show();
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                int Buscar = validacion.ValidarNumeroEntero(txtBuscar.Text);

                //Cliente cliente = _clientes.TraerPorCodigo(Buscar); Nose como traer por id registro
                Cliente cliente = _clientes.BuscarCliente(Buscar.ToString());

                MessageBox.Show(_clientes.MostrarDatosCliente(cliente));
                Limpiar();
            }
            catch (ValidarNumeroException vse)
            {
                MessageBox.Show(vse.Message);
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

        private void FormBuscarCliente_Load(object sender, EventArgs e)
        {
        }
    }
}
