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

        private string OperacionExistosa() 
        {
            return "Operacion Exitosa";
        }

        public void AgregarAlumno(int Codigo,string Nombre,string Apellido) 
        {
            Alumno alumno = new Alumno(Codigo, Nombre, Apellido);

            _alumnos.Add(alumno);

            OperacionExistosa();

        }



        public void AgregarEmpleado() { }

        public void EliminarAlumno() { }

        public void EliminarEmpleado() { }

        public void ModificarEmpleado() { }

        public List<Alumno> TraerAlumno(object obj)
        {
            throw new NotImplementedException();
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
