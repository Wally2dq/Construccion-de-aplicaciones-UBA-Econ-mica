using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormClientesConUrlDeCarga
{
    public partial class Form1 : Form
    {
        public Form _formulario;
        public Form1(Form formulario)
        {
            _formulario = (Form)formulario;
            InitializeComponent();
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            FormAltaCliente AltaCliente = new FormAltaCliente(this);
            AltaCliente.Show();
            this.Hide();
        }

        private void btnMostrarCliente_Click(object sender, EventArgs e)
        {
            FormMostrarClientes MostrarCliente = new FormMostrarClientes(this);
            MostrarCliente.Show();
            this.Hide();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            _formulario.Show();
            this.Close();
        }
    }
}
