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

            if (textBoxUsuario.Text == "1234")  //USUARIO 1234 , CONTRASEÑA 1234
            {
                if (textBoxContraseña.Text == "1234")
                {
                    LimpiarCampos();

                    MenuProfesor menu = new MenuProfesor(this);

                    menu.Show();
                    this.Hide();


                }
                else 
                {
                    textBoxContraseña.Clear();
                    textBoxContraseña.Focus();
                    MessageBox.Show("Contraseña incorecta");
                }
            }
            else 
            {
                LimpiarCampos();
                textBoxUsuario.Focus(); //hace que este sobre este box para poner de vuelta el usuario
                MessageBox.Show("Usuario Incorrecto");
            }

;
        }

        

        private void LimpiarCampos() 
        {
            textBoxUsuario.Clear();
            textBoxContraseña.Clear();
        }
    }
}
