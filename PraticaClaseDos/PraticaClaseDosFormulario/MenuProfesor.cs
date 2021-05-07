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

            InitializeComponent(); 
            //Debo poner todo en load 
        }

        private void MenuProfesor_Load(object sender, EventArgs e)
        {
            CargarAlumnos(); // Para cargar los datos a la lista

            CargarCmb(); // Para carfar los datos del cmb

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
                //Alumno alumno = (Alumno) i;

                string Mostrar = i.ToString();

                listBoxAlumnos.Items.Add(Mostrar); // Me salta que el objeto es null
            }

            
        }

        private void buttonAlta_Click(object sender, EventArgs e)
        {
            int NroRegistro;
            string Nombre;
            string Apellido;
            bool Recursante;
            string Tipo;

            
        }

       

        private void CargarCmb() 
        {
            this.comboBoxTipoAlumno.DataSource = ListaTipoAlumno.MostrarLista();

            this.comboBoxTipoAlumno.DisplayMember = "Descripcion"; //Mostrar descripcion

            this.comboBoxTipoAlumno.ValueMember = "Codigo"; //Valuar el codigo
        }
    }
}
