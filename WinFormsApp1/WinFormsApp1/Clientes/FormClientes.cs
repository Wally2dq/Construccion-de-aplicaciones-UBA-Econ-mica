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
using VentaDeHardware;
using VentaDeHardware.Clientes.Clientes_Opciones;

namespace VentaDeHardware
{
    public partial class FormClientes : Form
    {
        private Form _menuPrincipal;

        public FormClientes(Form formulario) 
        {
            _menuPrincipal = (Form)formulario;

            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            _menuPrincipal.Show();
            this.Close();
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            FormAltaCliente altaCli = new FormAltaCliente(this);

            altaCli.Show();
            this.Hide();
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            FormBuscarCliente altaCli = new FormBuscarCliente(this);

            altaCli.Show();
            this.Hide();
        }
    }
}
