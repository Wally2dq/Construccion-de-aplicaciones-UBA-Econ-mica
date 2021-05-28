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
    public partial class FormMostrarClientes : Form
    {
        private Form _fomulario;
        private Negocio _negocio = new Negocio();
        public FormMostrarClientes(Form formulario)
        {
            _fomulario = (Form)formulario;
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            _fomulario.Show();
            this.Close();
        }

        private void FormMostrarClientes_Load(object sender, EventArgs e)
        {
            listBoxClientes.DataSource = null;
            listBoxClientes.DataSource = _negocio.Traer();
        }
    }
}
