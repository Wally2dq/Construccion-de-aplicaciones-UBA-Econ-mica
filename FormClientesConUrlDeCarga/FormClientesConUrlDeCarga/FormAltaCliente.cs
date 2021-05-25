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

namespace FormClientesConUrlDeCarga
{
    public partial class FormAltaCliente : Form
    {
        private Form _formulario;
        private Negocio _negocion = new Negocio();
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
    }
}
