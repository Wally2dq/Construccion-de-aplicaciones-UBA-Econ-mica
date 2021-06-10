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
    public partial class FormModulos : Form
    {
        public FormModulos()
        {
            InitializeComponent();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            Form1 formulario = new Form1(this);
            formulario.Show();
            this.Hide();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCuentas_Click(object sender, EventArgs e)
        {
            FormCuenta cuenta = new FormCuenta(this);
            cuenta.Show();
            this.Hide();
        }
    }
}
