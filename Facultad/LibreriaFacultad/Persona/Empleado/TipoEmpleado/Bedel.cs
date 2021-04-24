using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaFacultad
{
    public sealed class Bedel : Empleado
    {
        private string _apodo;

        public string Apodo { get => this._apodo;}

        public Bedel(int legajoIngreso, string NombreIngreso,string ApellidoIngreso,DateTime FechaNacimientoIngreso,string ApodoIngreso) //NO USAMOS FECHA DE NACIMIENTO EN EL ToString
        {
            this._legajo = legajoIngreso;
            this._nombre = NombreIngreso;
            this._apellido = ApellidoIngreso;
            this._fechaNac = FechaNac;
            this._apodo = ApodoIngreso;

            this._salario = new List<Salario>();
        }


        public override string GetNombreCompleto()
        {
            return $"Bedel {Apodo}";
        }
    }
}
