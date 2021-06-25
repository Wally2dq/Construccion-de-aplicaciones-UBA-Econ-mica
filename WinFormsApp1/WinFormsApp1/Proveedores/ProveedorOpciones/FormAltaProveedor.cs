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
using CapaDeNegocio.Validaciones;

namespace VentaDeHardware.Proveedores.ProveedorOpciones
{
    public partial class FormAltaProveedor : Form
    {
        private Form _volver;
        private NegocioVentaDeHar _negocio = new NegocioVentaDeHar();
        private Validar validacion = new Validar();
        private NegocioProveedor negocio = new NegocioProveedor();


        public FormAltaProveedor(Form form)
        {
             _volver = (Form)form;
             InitializeComponent();
        }

    private void btnVolver_Click(object sender, EventArgs e)
        {
            
            _volver.Show();
            this.Close();
        }
        private void LimpiarCampos()
        {
            txtCodigo.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtEmail.Clear();
            txtCuit.Clear();
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            int codigo;
            string nombre;
            string apellido;
            string email;
            string cuit;
            try
            {
                codigo = int.Parse(txtCodigo.Text);
                nombre = validacion.ValidarString(txtNombre.Text);
                apellido = validacion.ValidarString(txtApellido.Text);
                email = validacion.ValidarString(txtEmail.Text+"@gmail.com");
                cuit = validacion.ValidarNumeroEntero(txtCuit.Text).ToString();

                Proveedor prov = new Proveedor(0, nombre, apellido, email, cuit, true, DateTime.Now.ToString(), "", 1, codigo);
                
                TransactionResult t = negocio.insertar(prov);

                if (t.IsOk == true)
                {
                    MessageBox.Show("Carga exitosa");
                    LimpiarCampos();
                }
                else 
                {
                    MessageBox.Show("Problemas en la carga");
                }
                
            }
            catch (ValidarStringException vse)
            {
                MessageBox.Show(vse.Message);
            }
            catch (ProveedorExisteException cee)
            {
                MessageBox.Show(cee.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        
       
    }
}
