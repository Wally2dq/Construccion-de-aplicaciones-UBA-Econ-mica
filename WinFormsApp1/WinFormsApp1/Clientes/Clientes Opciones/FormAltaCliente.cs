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
using CapaDeNegocio.Clientes;
using CapaDeNegocio.Validaciones;
using CapaDeEntidades.Entidades.Exepction;
using CapaDeEntidades.Entidades;

namespace VentaDeHardware.Clientes.Clientes_Opciones
{
    public partial class FormAltaCliente : Form
    {
        private Form _formulario;
        private NegocioVentaDeHar _negocio = new NegocioVentaDeHar();
        private Validar validacion = new Validar();
        private NegocioClientes _negocioCliente = new NegocioClientes();

        public FormAltaCliente(Form fomrulario)
        {
            _formulario = (Form)fomrulario;

            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            _formulario.Show();
            this.Close();
        }

        private void LimpiarCampos() 
        {
            txtCodigo.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtDireccion.Clear();
            txtDni.Clear();
            txtTelefono.Clear();
            txtEmail.Clear();
            dateFechaNacimiento.ResetText();
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            string Codigo;
            string Nombre;
            string Apellido;
            string Direccion;
            int Dni;
            int Telefono;
            string email;
            DateTime fechaNac;

            try
            {
                Codigo = validacion.ValidarString(txtCodigo.Text);
                Nombre = validacion.ValidarString(txtNombre.Text);
                Apellido = validacion.ValidarString(txtApellido.Text);
                Direccion = validacion.ValidarString(txtDireccion.Text);
                Dni = validacion.ValidarNumeroEntero(txtDni.Text);
                Telefono = validacion.ValidarNumeroEntero(txtTelefono.Text);
                email = validacion.ValidarString(txtEmail.Text);
                fechaNac = validacion.ValidarFecha(dateFechaNacimiento.Text);

                LimpiarCampos();

                TransactionResult resultado = _negocioCliente.Insertar(Codigo,Nombre,Apellido,Direccion,Dni.ToString(),fechaNac.ToString(),email,Telefono.ToString());
                MessageBox.Show("Carga exitosa !!! Cliente Nro: "+resultado.Id.ToString());
            }
            catch (ValidarStringException vse)
            {
                MessageBox.Show(vse.Message);
            }
            catch (ClienteExisteException cee)
            {
                txtCodigo.Focus();
                MessageBox.Show(cee.Message);
            }
            catch (ValidarFechaException cfe)
            {
                MessageBox.Show(cfe.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormAltaCliente_Load(object sender, EventArgs e)
        {

        }

        
    }
}
