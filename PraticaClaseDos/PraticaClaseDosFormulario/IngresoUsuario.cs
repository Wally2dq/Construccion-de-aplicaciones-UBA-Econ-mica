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
    public partial class IngresoUsuario : Form
    {
        public IngresoUsuario()
        {
            InitializeComponent();
        }
        private void IngresoUsuario_Load(object sender, EventArgs e)
        {
            LimpiarCampos();

        }

        private void buttonIngreso_Click(object sender, EventArgs e)
        {

            if (textBoxUsuario.Text == "Wal")
            {
                if (textBoxContraseña.Text == "1234")
                {

                    MenuProfesor menu = new MenuProfesor(this);

                    menu.Show();
                    this.Hide();


                }
                else 
                {
                    MessageBox.Show("Contraseña incorecta");
                }
            }
            else 
            {
                MessageBox.Show("Usuario Incorrecto");
            }


            LimpiarCampos();
        }

        

        private void LimpiarCampos() 
        {
            textBoxUsuario.Clear();
            textBoxContraseña.Clear();
        }
    }
}
