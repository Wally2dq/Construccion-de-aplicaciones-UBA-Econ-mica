using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaFacultad
{
    public abstract class Empleado:Persona
    {
        protected List<object> _salario;
        protected DateTime _fechaIngreso;
        protected int _legajo;

        public int Legajo { get => this._legajo; set => this._legajo = value; }
        public DateTime FechaIngreso { get => this._fechaIngreso; set => this._fechaIngreso = value; }
        public DateTime FechaNac { get => this._fechaNac; set => this._fechaNac=value; }

        public List<string> Salarios(object obj) //Preguntar
        {
            Empleado salario = (Empleado)obj;

            List<string> _listaSalario = new List<string>();

            foreach (Salario I in salario._salario) //Salario de un empleado determinado
            {
                _listaSalario.Add(I.ToString());
            }

            return _listaSalario;

        }
        public int Antiguedad()
        {
            return (_fechaIngreso.Year - DateTime.Now.Year);
        }
        public object UltimoSalario(object obj)// Preguntar
        {
            Empleado ultSalario = (Empleado)obj;

            return ultSalario._salario.Last(); //MostrarElUltimo
        }

        public override bool Equals(object obj)
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

        public void AgregarSalario(object SalarioObj) 
        {
            Salario salario = (Salario)SalarioObj;

            _salario.Add(salario);
        }
        public override string GetCredencial()
        {
            return $"Legajo: {Legajo} - Nombre Completo: {GetNombreCompleto()} - Salario: {UltimoSalario().ToString()} ";
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
