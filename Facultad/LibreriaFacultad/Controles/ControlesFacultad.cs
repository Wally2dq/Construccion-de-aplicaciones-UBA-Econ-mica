using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaFacultad
{
    public class ControlesFacultad
    {
        List<Alumno> _alumnos;
        List<Empleado> _empleado;

        private int _cantidadSede;
        private string _nombre;

        public int CantidadSede { get => this._cantidadSede; set => this._cantidadSede = value; }
        public string Nombre { get => this._nombre; set => this._nombre = value; }

        public ControlesFacultad(int CantidadSedeIngreso, string NombreIngreso)
        {
            this._alumnos = new List<Alumno>();
            this._empleado = new List<Empleado>();
            this.CantidadSede = CantidadSedeIngreso;
            this.Nombre = NombreIngreso;
        }
        

        public void AgregarAlumno(int Codigo,string Nombre,string Apellido) 
        {
            bool flag = true;

            Alumno cargaralumno = new Alumno(Codigo, Nombre, Apellido);

            foreach (Alumno alu in _alumnos) 
            {
                if ((alu.Equals(cargaralumno)) == false)
                {
                    flag = alu.Equals(cargaralumno);
                    throw new AlumnoExistenteException("Codigo registrado");
                }

            }

            if (flag==true)
            _alumnos.Add(cargaralumno);
            

        }

        public string OperacionExistosa() 
        {
            return "OperacionExitosa";
        }

        public void AgregarEmpleado(object obj) 
        {
            Empleado introEmple = (Empleado)obj;
            bool flag = true;

            foreach (Empleado emple in _empleado)
            {
                if ((emple.Equals(introEmple)) == false)
                {
                    flag = emple.Equals(obj);
                    throw new AlumnoExistenteException("Legajo registrado");
                }

            }

            if (flag == true)
                _empleado.Add(introEmple);
        } //Mostrar

        public void EliminarAlumno(int Codigo) 
        {
            foreach (Alumno alu in _alumnos) 
            {
                if (Codigo == alu.Codigo)
                {
                    _alumnos.Remove(alu);
                    break;
                }
                else 
                {
                    throw new AlumnoInexistenteExepcion("No existe alumno");
                }
            }
        }

        public void EliminarEmpleado(object obj) 
        {
            Empleado emple = (Empleado)obj;

            _empleado.Remove(emple);
        }

        public void ModificarEmpleado() { }

        public List<string> TraerAlumno(int Codigo)
        {
            List<string> _mostrarAlumno = new List<string>();

            foreach (Alumno alu in _alumnos) 
            {
                if (Codigo == alu.Codigo)
                    _mostrarAlumno.Add(alu.ToString());
            }

            return _mostrarAlumno ; 
        }
        public List<string> TraerAlumno()
        {
            List<string> _mostrarAlumno = new List<string>();

            foreach (Alumno alu in _alumnos)
            {
                _mostrarAlumno.Add(alu.ToString());
            }

            return _mostrarAlumno;
        }

        public Empleado TaerEmpleadoPorLegajo(int legajo) //Preguntar
        {
            Empleado Salida;
            foreach (Empleado i in _empleado) 
            {
                if (i.Legajo == legajo)
                {
                    Salida = (Empleado)i;
                    break;
                }
                else 
                {
                    throw new AlumnoInexistenteExepcion("No se encontro Alumno");
                }
            }
            return Salida;
        }

        public List<Empleado> TraerEmpleado() 
        {
            throw new NotImplementedException();
        }

        public List<Empleado> TraerEmpleadoPorNombre() 
        {
            throw new NotImplementedException();
        }


    }
}
