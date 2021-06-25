using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDeEntidades.Entidades.Exepction;
using CapaDeEntidades.Entidades;
using CapaDeNegocio.Validaciones;
using CapaDeNegocio;

namespace VentaDeHardware.Productos.ProductoOpciones
{
    public partial class FormBuscarProducto : Form
    {
        private Form _formulario;
        private Validar _validar = new Validar();
        private NegocioProducto _negocioProducto = new NegocioProducto();
        public FormBuscarProducto(Form formulario)
        {
            _formulario = (Form)formulario;
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            _formulario.Show();
            this.Close();
        }
        private void Limpiar() 
        {
            txtBuscar.Clear();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int Codigo;

            try
            {
                Codigo = _validar.ValidarNumeroEntero(txtBuscar.Text);

                Producto p = _negocioProducto.buscarProducto(Codigo);

                if (p != null) 
                {
                    MessageBox.Show(p.ToString());
                }
                Limpiar();
            }
            catch (ValidarNumeroException vne)
            {
                MessageBox.Show(vne.Message);
                Limpiar();
            } 
            catch (ProductoInexistenteException PIE) 
            {
                MessageBox.Show(PIE.Message);
                Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
