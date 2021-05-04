using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibreriaCalculadora;

namespace CalculadoraFormulario
{
    public partial class Form1 : Form
    {
        static private Validar validar = new Validar();

        public Form1()
        {
            InitializeComponent();
        }

        public void Limpiar() 
        {
            TxtVariable1.Clear();
            TxtVariable2.Clear();
        }

        private void Suma_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                string text1 = TxtVariable1.Text;
                string text2 = TxtVariable2.Text;

                double Valor1 = validar.ValidarNumero(text1);

                double Valor2 = validar.ValidarNumero(text2);

                Botones p = new Botones(Valor1, Valor2);

                MessageBox.Show("Resultado = "+ p.Suma() );

                Limpiar();
            }
            catch (ValidarNumeroException vne) 
            {
                MessageBox.Show(vne.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Resta_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                string text1 = TxtVariable1.Text;
                string text2 = TxtVariable2.Text;

                double Valor1 = validar.ValidarNumero(text1);

                double Valor2 = validar.ValidarNumero(text2);

                Botones p = new Botones(Valor1, Valor2);

                MessageBox.Show("Resultado = " + p.Resta());

                Limpiar();
            }
            catch (ValidarNumeroException vne)
            {
                MessageBox.Show(vne.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Mutiplicacion_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                string text1 = TxtVariable1.Text;
                string text2 = TxtVariable2.Text;

                double Valor1 = validar.ValidarNumero(text1);

                double Valor2 = validar.ValidarNumero(text2);

                Botones p = new Botones(Valor1, Valor2);

                MessageBox.Show("Resultado = " + p.Multiplicacion());

                Limpiar();
            }
            catch (ValidarNumeroException vne)
            {
                MessageBox.Show(vne.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Division_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                string text1 = TxtVariable1.Text;
                string text2 = TxtVariable2.Text;

                double Valor1 = validar.ValidarNumero(text1);

                double Valor2 = validar.ValidarNumero(text2);

                Botones p = new Botones(Valor1, Valor2);

                MessageBox.Show("Resultado = " + p.Division());

                Limpiar();
            }
            catch (ValidarNumeroException vne)
            {
                MessageBox.Show(vne.Message);
            }
            catch (NoDividirPorCeroException nde) 
            {
                MessageBox.Show(nde.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
