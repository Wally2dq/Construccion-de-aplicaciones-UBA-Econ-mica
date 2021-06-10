using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;
using CapaNegocio.Exceptions;
using CapaNegocio.Validacion;
using ClaseEntidades;


namespace FormClientesConUrlDeCarga
{
    public partial class FormCuenta : Form
    {
        private Form _formulario;
        private Validar _validar = new Validar();
        private Negocio _negocio = new Negocio();
        public FormCuenta(Form formulario)
        {
            _formulario = formulario;
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            _formulario.Show();
            this.Close();
        }

        private void FormCuenta_Load(object sender, EventArgs e)
        {
            CargarLista();
        }

        private void CargarLista() 
        {
            lstClientes.DataSource = null;
            lstClientes.DataSource = _negocio.Traer();
        }

        private void lstClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cliente cliente = (Cliente)lstClientes.SelectedValue;

            if (cliente != null) 
            {
                Cuenta cuenta = cliente.Cuenta;


                if (cuenta == null)
                {
                    Limpiar();

                    txtDescripcion.Enabled = true;
                    btnAlta.Enabled = true;

                }
                else
                {
                    Limpiar();

                    txtSaldo.Enabled = true;
                    btnModi.Enabled = true;

                    cargarCuenta(cliente.Cuenta);

                }
            }
            

        }

        private void cargarCuenta(Cuenta cuenta)
        {
            Cuenta cargar = (Cuenta)cuenta;
            txtFechaAlta.Text = cargar.fechaApertura.ToString();
            txtModificacion.Text = cargar.fechaApertura.ToString();
            txtNroCuenta.Text = cargar.id.ToString();
            txtDescripcion.Text = cargar.descripcion;
            txtSaldo.Text = cargar.saldo.ToString();
        }

        public void Limpiar() 
        {
            txtFechaAlta.Clear();
            txtModificacion.Clear();
            txtNroCuenta.Clear();
            txtDescripcion.Clear();
            txtSaldo.Clear();

            txtDescripcion.Enabled = false;
            btnAlta.Enabled = false;

            txtSaldo.Enabled = false;
            btnModi.Enabled = false;

        }
        
        private void btnAlta_Click(object sender, EventArgs e)
        {
            Cliente cliente = (Cliente)lstClientes.SelectedValue;
            try
            {
                cliente.Cuenta = new Cuenta();
                cliente.Cuenta.idCliente = cliente.id;
                cliente.Cuenta.descripcion = _validar.ValidarString(txtDescripcion.Text);
                cliente.Cuenta.fechaApertura = DateTime.Now;

                TransactionResult lst = _negocio.Alta(cliente.Cuenta);

                MessageBox.Show("Cuenta creada");
                Limpiar();
                txtDescripcion.Enabled = false;
                btnAlta.Enabled = false;
                CargarLista();

            }
            catch (ValidarStringException vse)
            {
                MessageBox.Show(vse.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnModi_Click(object sender, EventArgs e)
        {
            Cliente cliente = (Cliente)lstClientes.SelectedValue;

            try
            {
                cliente.Cuenta.saldo = _validar.ValidarNumeroDouble(txtSaldo.Text);
                cliente.Cuenta.fechaModificacion = DateTime.Now;

                TransactionResult lst = _negocio.Actualizar(cliente.Cuenta);

                MessageBox.Show("Actualizado ");

                txtSaldo.Enabled = false;
                btnModi.Enabled = false;
                Limpiar();
                CargarLista();

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
