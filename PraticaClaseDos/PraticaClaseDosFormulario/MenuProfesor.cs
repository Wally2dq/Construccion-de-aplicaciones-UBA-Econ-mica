using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PraticaClaseDosFormulario
{
    public partial class MenuProfesor : Form
    {
        private Form Usuario;
        public MenuProfesor(Form UsuarioIngreso)
        {
            Usuario = UsuarioIngreso;

            InitializeComponent();
        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            Usuario.Show();

            this.Close();
        }
    }
}
