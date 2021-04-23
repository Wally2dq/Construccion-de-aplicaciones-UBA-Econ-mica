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

        public ControlesFacultad() 
        {
            _alumnos = new List<Alumno>();
            _empleado = new List<Empleado>();
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

        public void AgregarEmpleado() { }

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

        public void EliminarEmpleado() { }

        public void ModificarEmpleado() { }

        public List<Alumno> TraerAlumno(object obj)
        {
            foreach (Alumno alu in _alumnos) 
            {
                //Seguir
            }
        }

        public Empleado TaerEmpleadoPorLegajo()
        {
            throw new NotImplementedException();
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
