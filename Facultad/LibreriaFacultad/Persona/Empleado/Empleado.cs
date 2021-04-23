using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaFacultad
{
    public abstract class Empleado:Persona
    {
        List<object> _salario;
        protected DateTime _fechaIngreso;
        protected int _legajo;

        public int Legajo { get => this._legajo; set => this._legajo = value; }
        public DateTime FechaIngreso { get => this._fechaIngreso; set => this._fechaIngreso = value; }
        public DateTime FechaNac { get => this._fechaNac; set => this._fechaNac=value; }
        public int Antiguedad()
        {
            return (_fechaIngreso.Year - DateTime.Now.Year);
        }
        public Object UltimoSalario()
        {
            return"";
        }

        public override bool Equals(object obj)
        {

            if (obj == null)
                return false;

            if (!(obj is Empleado)) //El objeto No es Empleado
                return false;

            Empleado emple = (Empleado)obj;

            if (emple.Legajo != this.Legajo) //Ya se encuentra el legajo en la lista
                return false;

            return true;
        }

        public void AgregarSalario(object Salario) 
        {
        }
        public override string GetCredencial()
        {
            return $"Legajo: {Legajo} - Nombre Completo: {GetNombreCompleto()} - Salario ${UltimoSalario()}";
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
