using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaFacultad
{
    class ControlesFacultad
    {
        List<Alumno> _alumnos;
        List<Empleado> _empleado;

        private int _cantidadSede;
        private string _nombre;

        public void AgregarAlumno() { }

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
