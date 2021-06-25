using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VentaDeHardware; //Tuve que poner el using porque sino no puedo usar el form

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            FormMenuPrincipal menu = new FormMenuPrincipal(this);

            menu.Show();
            this.Hide();

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
