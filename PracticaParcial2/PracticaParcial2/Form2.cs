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
using CapaEntidades;  

namespace PracticaParcial2
{
    public partial class Form2 : Form
    {
        private Form _formulario;
        private NegocioTipoPrestamo _negocioTipoPrestamo;
        private Validar _validar;
        private NegocioPrestamo _negocioPrestamo;

        public Form2(Form formulario)
        {
            _formulario = formulario;
            _negocioTipoPrestamo = new NegocioTipoPrestamo();
            _validar = new Validar();
            _negocioPrestamo = new NegocioPrestamo();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _formulario.Show();
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            CargarLstTipoPrestamo();
        }
        private void CargarLstTipoPrestamo() 
        {
            listBoxTipoPrestamo.DataSource = null;
            listBoxTipoPrestamo.DataSource = _negocioTipoPrestamo.TraerTiposPrestamo();
        }

        private void CargarLstiPrestamo(int id) 
        {
            listBox1.DataSource = null;
            listBox1.DataSource = _negocioPrestamo.TraerPorId(id);
        }

        

        private void listBoxTipoPrestamo_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxMonto.Enabled = true;
            textBoxPlazo.Enabled = true;

            try
            {
                Limpiar();

                PrestamoTipo tipo = (PrestamoTipo) listBoxTipoPrestamo.SelectedValue;

                if (tipo != null)
                {
                    textBoxLinea.Text = tipo.Linea.ToString();
                    textBoxTNA.Text = tipo.TNA.ToString();

                    CargarLstiPrestamo(tipo.id);
                }

                
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

       

        private void buttonSimular_Click(object sender, EventArgs e)
        {
            textBoxMonto.Enabled = false;
            textBoxPlazo.Enabled = false;
            try
            {
                PrestamoTipo tipo = (PrestamoTipo)listBoxTipoPrestamo.SelectedValue;

                double Monto = _validar.ValidarNumeroDouble(textBoxMonto.Text);
                int Plazo = _validar.ValidarNumeroEntero(textBoxPlazo.Text);

                Prestamo prestamo = new Prestamo();
                prestamo.id = tipo.id;
                prestamo.Linea = tipo.Linea;
                prestamo.TNA = tipo.TNA;
                prestamo.Monto = Monto;
                prestamo.Plazo = Plazo;

                double CuotaCap = prestamo.CuotaCapital(Monto, Plazo);
                double CuotaInte = prestamo.CuotaInteres(CuotaCap, prestamo.TNA);
                double MontoTotal= prestamo.CuotaTotal(CuotaCap,CuotaInte);

                textBoxCuotaCapital.Text = CuotaCap.ToString();
                textBoxCuotaInteres.Text = CuotaInte.ToString();
                textBoxCuotaTotal.Text = MontoTotal.ToString();

                buttonAlta.Enabled = true;

            }
            catch (ValidarException ve) 
            {
                MessageBox.Show(ve.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonAlta_Click(object sender, EventArgs e)
        {
            try
            {
                PrestamoTipo tipo = (PrestamoTipo)listBoxTipoPrestamo.SelectedValue;

                Prestamo prestamo = new Prestamo();
                prestamo.Tipo = tipo.id;
                prestamo.Linea = tipo.Linea;
                prestamo.TNA = tipo.TNA;
                prestamo.Monto = _validar.ValidarNumeroDouble(textBoxMonto.Text) ;
                prestamo.Plazo = _validar.ValidarNumeroEntero(textBoxPlazo.Text);

                double CuotaCap = prestamo.CuotaCapital(prestamo.Monto, prestamo.Plazo);
                double CuotaInte = prestamo.CuotaInteres(CuotaCap, prestamo.TNA);
                double CuotaTotal = prestamo.CuotaTotal(CuotaCap, CuotaInte);

                prestamo.Cuota = CuotaTotal;


                ResultadoTransaccion resultado = _negocioPrestamo.AltaPrestamo(prestamo);


                MessageBox.Show(resultado.Id.ToString());

                CargarLstTipoPrestamo();

                Limpiar();
            }
            
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Prestamo prestamo = (Prestamo)listBox1.SelectedValue;

            if (prestamo != null)
            {
                Operador ope = new Operador(prestamo.Monto);

                textBox1.Text = ope.MostrarComision().ToString("0.00");
            }

        }

        private void Limpiar() 
        {
            textBoxLinea.Clear();
            textBoxMonto.Clear();
            textBoxTNA.Clear();
            textBoxPlazo.Clear();
            textBoxCuotaInteres.Clear();
            textBoxCuotaCapital.Clear();
            textBoxCuotaTotal.Clear();
        }
    }
}
