using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocios;
using CapaEntidades;
using CapaNegocios.Exceptiones;
using CapaNegocios.Validaciones;

namespace _2doParcialCAI
{
    public partial class FormPlazoFijos : Form
    {
        private Negocio _negocio;
        private Form _formulario;
        private Validar _validar;
        public FormPlazoFijos(Form F)
        {
            _negocio = new Negocio();
            _validar = new Validar();
            _formulario = F;
            InitializeComponent();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        private void Limpiar() 
        {
            txtCapitalInvertir.Clear();
            txtDias.Clear();
            txtFinal.Clear();
            txtRecibir.Clear();
            txtTasa.Clear();
            btnAlta.Enabled = false;
            btnSimular.Enabled = false;
            comboBox1.SelectedIndex = 0;
        }

        private void FormPlazoFijos_Load(object sender, EventArgs e)
        {
            CargarCmb();
            CargarListaBox();
        }

        private void CargarListaBox()
        {
            listBox1.DataSource = null;
            listBox1.DataSource = _negocio.CargarLista();

            if (listBox1!=null) 
            {
                List<PlazoFijo> plazo = _negocio.CargarLista() ;
                Operador n = new Operador(plazo);

                textBox1.Text = n.MontoTotal().ToString();
                textBox2.Text = n.Comision().ToString();
            }
        }

        private void CargarCmb() 
        {
            comboBox1.DataSource = null;
            comboBox1.DataSource = _negocio.CargarCmb();
        }

        private void btnSimular_Click(object sender, EventArgs e)
        {
            try
            {
                TipoPlazoFijo tipo = (TipoPlazoFijo)comboBox1.SelectedValue;
                if (tipo == null)
                {
                    throw new ValidarException("Seleccione un tipo de plazo fijo");
                }
                else
                {
                    if (tipo.id == 0)
                    {
                        throw new ValidarException("Seleccione un tipo de plazo fijo");
                    }
                    else
                    {

                        double CapitalInvertir = _validar.ValidarNumeroDoubleMonto(_validar.ValidarNumeroDouble(txtCapitalInvertir.Text).ToString());
                        int Dias = _validar.ValidarNumeroEntero(txtDias.Text);


                        PlazoFijo p = new PlazoFijo();
                        p.CapitalInicial = CapitalInvertir;
                        p.Dias = Dias;
                        p.Tasa = _validar.ValidarNumeroDouble(txtTasa.Text);
                        p.Tipo = tipo.id;
                        p.TipoPlazoFijo = tipo;

                        txtRecibir.Text = p.Interes.ToString();
                        txtFinal.Text = p.MontoFinal.ToString();

                        btnAlta.Enabled = true;

                    }
                }
            }
            catch (ValidarException ve)
            {
                MessageBox.Show(ve.Message);
            }
            catch (ValidarExceptionMonto veM)
            {
                MessageBox.Show(veM.Message);
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            TipoPlazoFijo tipo = (TipoPlazoFijo)comboBox1.SelectedValue;
            if (tipo != null)
            {
                if (tipo.id != 0) 
                {
                    btnSimular.Enabled = true;
                    txtTasa.Text = tipo.Tasa.ToString();
                }
            }
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            try
            {
                TipoPlazoFijo tipo = (TipoPlazoFijo)comboBox1.SelectedValue;
                if (tipo == null)
                {
                    throw new ValidarException("Seleccione un tipo de plazo fijo");
                }
                else
                {
                    if (tipo.id == 0)
                    {
                        throw new ValidarException("Seleccione un tipo de plazo fijo");
                    }
                    else
                    {

                        double CapitalInvertir = _validar.ValidarNumeroDouble(txtCapitalInvertir.Text);
                        int Dias = _validar.ValidarNumeroEntero(txtDias.Text);


                        PlazoFijo p = new PlazoFijo();
                        p.CapitalInicial = _validar.ValidarNumeroDouble(txtCapitalInvertir.Text) ;
                        p.Dias = _validar.ValidarNumeroEntero(txtDias.Text);
                        p.Tasa = _validar.ValidarNumeroDouble(txtTasa.Text);
                        p.Tipo = tipo.id;
                        p.TipoPlazoFijo = tipo;

                        txtRecibir.Text = p.Interes.ToString();
                        txtFinal.Text = p.MontoFinal.ToString();

                        ResultadoTransaccion lst = _negocio.Alta(p);

                        if (lst.IsOk)
                        {
                            MessageBox.Show("Alta Relizada");

                            CargarListaBox();
                        }
                        else 
                        {
                            MessageBox.Show("No se pudo realizar el alta");
                        }

                        Limpiar();
                    }
                }
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

        private void button1_Click(object sender, EventArgs e)
        {
            _formulario.Show();
            this.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
