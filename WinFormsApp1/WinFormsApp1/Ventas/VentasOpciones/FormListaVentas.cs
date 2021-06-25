using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDeNegocio.Ventas;

namespace VentaDeHardware.Ventas.VentasOpciones
{
    public partial class FormListaVentas : Form
    {
        private Form _formulario;
        private NegocioVentas _negocioVentas = new NegocioVentas();

        public FormListaVentas(Form fomulario)
        {
            _formulario = fomulario;
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            _formulario.Show();
            this.Close();
        }

        private void FormListaVentas_Load(object sender, EventArgs e)
        {
            lstVentas.DataSource = null;
            lstVentas.DataSource = _negocioVentas.TraerTodasVentas();
        }

        
    }
}
