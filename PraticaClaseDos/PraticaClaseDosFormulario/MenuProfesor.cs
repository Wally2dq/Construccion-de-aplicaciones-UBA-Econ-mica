using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibraryClase2Form;

namespace PraticaClaseDosFormulario
{
    public partial class MenuProfesor : Form
    {
        private Form Usuario;
        private Profesor profesor;
        public MenuProfesor(Form UsuarioIngreso)
        {
            Usuario = UsuarioIngreso;

            profesor = new Profesor();

            CargarAlumnos(); // Para cargar los datos a la lista

            InitializeComponent();
        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            Usuario.Show();

            this.Close();
        }

        private void CargarAlumnos()
        {
            List<Alumno> _mostrar = profesor.MostrarLista();

            foreach (Alumno i in _mostrar) 
            {
                Alumno alumno = (Alumno) i;

                listBoxAlumnos.Items.Add(alumno.ToString());
            }

            
        }

    }
}
