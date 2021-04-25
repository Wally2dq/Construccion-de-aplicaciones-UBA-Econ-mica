using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaFacultad
{
    public abstract class Empleado:Persona
    {
        protected List<Salario> _salario;
        protected DateTime _fechaIngreso;
        protected int _legajo;

        public int Legajo { get => this._legajo; set => this.Legajo = value; } //El set estara en el constructor
        public DateTime FechaIngreso { get => this._fechaIngreso; set => this.FechaIngreso = value; }
        public DateTime FechaNac { get => this._fechaNac; set => this.FechaNac = value; }

        public List<Salario> Salarios() 
        {
            if (_salario.Count == 0)
                throw new ListaSinDatosExpecion("No hay datos Cargados");
            return _salario;
        }
        public int Antiguedad()
        {
            return (_fechaIngreso.Year - DateTime.Now.Year);
        }
        public Salario UltimoSalario()
        {
            if (_salario.Count == 0)
                throw new ListaSinDatosExpecion("No hay datos Cargados");

            return _salario.Last(); 
        }

        public override bool Equals(object obj) //Pongo object aca y en los demas devuelvo la clase directamente
        {

            if (obj == null)  //Objeto Nulo
                return false;

            if (!(obj is Empleado)) //El objeto No es Empleado
                return false;

            Empleado emple = (Empleado)obj;

            if (this.Legajo != emple.Legajo) // no encuentra el legajo en la lista, es falso, no son iguales
                return false;

            return true;
        } 

        public void AgregarSalario(Salario SalarioObj) 
        {
            _salario.Add(SalarioObj);
        }
        public override string GetCredencial()
        {
            Salario sala = UltimoSalario();
            return $"Legajo: {Legajo} - Nombre Completo: {GetNombreCompleto()} - " +
                $"\n Ultimo Salario: {sala.ToString()}" + Convert.ToString(UltimoSalario());
        } 

        public override string GetNombreCompleto()
        {
            return base.GetNombreCompleto();
        }

        public override string ToString()
        {
            return GetCredencial();
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

    }
}
