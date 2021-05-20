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
        private Validar validar = new Validar();


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

        public void LimpiarCampos() 
        {
            textBoxNroRegistro.Clear();
            textBoxApellido.Clear();
            textBoxNombre.Clear();
            comboBoxTipoAlumno.SelectedIndex = 0;
            checkRecursante.Checked = false;
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


            try
            {
                NroRegistro = validar.ValidarNumero(textBoxNroRegistro.Text);
                Nombre = validar.ValidarString(textBoxNombre.Text);
                Apellido = validar.ValidarString(textBoxApellido.Text);
                Recursante = checkRecursante.Checked;

                if (comboBoxTipoAlumno.SelectedIndex == 0)
                {
                    throw new ElijaUnaOpcionException("Elija un tipo de alumno");
                }
                Tipo = comboBoxTipoAlumno.Text;

                Alumno Cargar = new Alumno(NroRegistro,Nombre,Apellido,Recursante,Tipo);

                profesor.BuscarAlumnoRepetido(Cargar);
                profesor.CargarAlumno(Cargar);

                LimpiarCampos();

                MessageBox.Show("Carga Existosa");
            }
            catch (ElijaUnaOpcionException euoe)
            {
                MessageBox.Show(euoe.Message);
            }
            catch (ValidarNumeroException VNE)
            {
                MessageBox.Show(VNE.Message);
            }
            catch (ValidarStringException VSE)
            {
                MessageBox.Show(VSE.Message);
            }
            catch (CodigoDeAlumnoYaRegistradoException CAYRE) 
            {
                MessageBox.Show(CAYRE.Message);
            }
            
        }

       

        private void CargarCmb() 
        {
            this.comboBoxTipoAlumno.DataSource = ListaTipoAlumno.MostrarLista();

            this.comboBoxTipoAlumno.DisplayMember = "Descripcion"; //Mostrar descripcion

            this.comboBoxTipoAlumno.ValueMember = "Codigo"; //Valuar el codigo
        }

        private void btnEliminarAlumno_Click(object sender, EventArgs e)
        {
            if (comboBoxTipoAlumno.SelectedIndex == -1)
            {
                btnEliminarAlumno.Enabled = false;
            }
            else 
            {
                try
                {
                    Alumno alu = (Alumno)comboBoxTipoAlumno.SelectedValue;

                    profesor.EliminarAlumno(alu);
                    MessageBox.Show("Alumno Eliminado");
                }
                catch (Exception Ex) 
                {
                    MessageBox.Show(Ex.Message);
                }
                
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            listBoxAlumnos.Items.Clear();

            CargarAlumnos();
        }
    }
}
