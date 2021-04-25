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
        

        public void AgregarAlumno(Alumno obj) 
        {
            bool flag = true;

            foreach (Alumno alu in _alumnos) 
            {
                if ((alu.Codigo.Equals(obj.Codigo)) == true)
                {
                    flag = false;
                    throw new AlumnoExistenteException("Codigo ya registrado");
                }

            }

            if (flag!=false)
            _alumnos.Add(obj);
            

        }

        public string OperacionExistosa() 
        {
            return "OperacionExitosa";
        }

        public void AgregarEmpleado(Empleado obj) 
        {
            bool flag = true;

            foreach (Empleado emple in _empleado)
            {
                if ((emple.Equals(obj)) == true)
                {
                    flag = false;
                    throw new AlumnoExistenteException("Legajo registrado");
                }

            }

            if (flag != false)
                _empleado.Add(obj);
        } 

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

        public void EliminarEmpleado(int Legajo) 
        {

            foreach (Empleado emple in _empleado)
            {
                if (Legajo== emple.Legajo)
                {
                    _empleado.Remove(emple);
                    break;
                }
                else
                {
                    throw new EmpleadoInexistenteExepcion("No existe empleado");
                }
            }
        }

        public void ModificarEmpleado(Empleado obj) 
        {
            foreach (Empleado emple in _empleado) 
            {
                if (emple.Legajo.Equals(obj.Legajo))
                {
                    Empleado Modi = (Empleado)emple;
                    Modi = obj;
                }
                
            }

        }

        public Alumno TraerAlumnoCodigo(int CodigoIngreso) //
        {

            if ((_alumnos.SingleOrDefault(i => i.Codigo == CodigoIngreso)) == null) //Busco el dato y si es null salta la exepcion
                throw new AlumnoInexistenteExepcion("No se registra Alumno con ese Codigo");

            return _alumnos.SingleOrDefault(i => i.Codigo == CodigoIngreso); // el single default al no encotrarlo me devuelve null
 
        }

        
        public List<Alumno> TraerAlumno()
        {
            if (_alumnos.Count == 0)
                throw new ListaSinDatosExpecion("No hay datos Cargados");

            return _alumnos;
        }

        public Empleado TaerEmpleadoPorLegajo(int legajoIngreso) //Preguntar
        {
            if ((_empleado.SingleOrDefault(i => i.Legajo == legajoIngreso)) == null)
                throw new EmpleadoExistenteException("No se registra Empleado con ese registro");

            return _empleado.SingleOrDefault(i=>i.Legajo==legajoIngreso);
        }

        public List<Empleado> TraerEmpleado() 
        {
            if (this._empleado.Count == 0)
                throw new ListaSinDatosExpecion("No se registran datos registrados");

            return this._empleado;
        }

        public List<Empleado> TraerEmpleadoPorNombre(string NombreIngreso)
        {
            if (this._empleado.SingleOrDefault(i => i.Nombre == NombreIngreso) == null)
                throw new EmpleadoExistenteException("No se registra Empleado con ese Nombre");

            return this._empleado.Where(emp => emp.Nombre == NombreIngreso).ToList();
        }


    }
}
