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

        public int Legajo { get => this._legajo;} //El set estara en el constructor
        public DateTime FechaIngreso { get => this._fechaIngreso;}
        public DateTime FechaNac { get => this._fechaNac;}

        public List<string> Salarios(Empleado obj) //Usar list<Salario> Ver como usarlo
        {

            List<string> _listaSalario = new List<string>();

            foreach (Salario I in obj._salario) //Salario de un empleado determinado
            {
                _listaSalario.Add(I.ToString());
            }

            return _listaSalario;

        }
        public int Antiguedad()
        {
            return (_fechaIngreso.Year - DateTime.Now.Year);
        }
        public Salario UltimoSalario(Empleado obj)// Preguntar
        {
            return obj._salario.Last(); 
        }

        public override bool Equals(object obj) //Pongo object aca y en los demas devuelvo la clase directamente
        {

            if (obj == null)
                return false;

            if (!(obj is Empleado)) //El objeto No es Empleado
                return false;

            Empleado emple = (Empleado)obj;

            if (this.Legajo == emple.Legajo) //Ya se encuentra el legajo en la lista
                return false;

            return true;
        } //Consulta !=

        public void AgregarSalario(Salario SalarioObj) 
        {
            _salario.Add(SalarioObj);
        }
        public override string GetCredencial()
        {
            return $"Legajo: {Legajo} - Nombre Completo: {GetNombreCompleto()} - Salario: " + Convert.ToString(UltimoSalario());
        } //Preguntar

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
