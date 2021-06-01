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
using CapaNegocio.Validacion;
using CapaNegocio.Exceptions;
using ClaseEntidades;


namespace FormClientesConUrlDeCarga
{
    public partial class FormAltaCliente : Form
    {
        private Form _formulario;
        private Negocio _negocio = new Negocio();
        private Validar validar = new Validar();

        public FormAltaCliente(Form formulario)
        {
            _formulario = (Form)formulario;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _formulario.Show();
            this.Close();
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            try 
            {
                string Nombre = validar.ValidarString(txtNombre.Text);
                string Apellido = validar.ValidarString(txtApeliido.Text);
                string Direccion = validar.ValidarString(txtDireccion.Text);
                int Dni = validar.ValidarNumero(txtDNI.Text);
                string Usuario = validar.ValidarString(txtUsuario.Text);
                string FechaNac = validar.ValidarString(dateTimeFecha.Text);

                TransactionResult resultado = _negocio.Agregar(Usuario, Nombre, Apellido, Direccion, Dni.ToString(),FechaNac);

                MessageBox.Show(resultado.Id.ToString());

                Limpiar();

            }
            catch (ValidarNumeroException vne)
            {
                MessageBox.Show(vne.Message);
            }
            catch (ValidarStringException vse) 
            {
                MessageBox.Show(vse.Message);
            }
        }
        public void Limpiar() 
        {
            txtUsuario.Clear();
            txtNombre.Clear();
            txtApeliido.Clear();
            txtDireccion.Clear();
            txtDNI.Clear();
            dateTimeFecha.ResetText();
        }
    }
}
