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

        public string Apodo { get => this._apodo; set => this._apodo = value; }

        public Bedel(int legajoIngreso, string NombreIngreso,string ApellidoIngreso,DateTime FechaNacimientoIngreso,string ApodoIngreso) //NO USAMOS FECHA DE NACIMIENTO EN EL ToString
        {
            this.Legajo = legajoIngreso;
            this.Nombre = NombreIngreso;
            this.Apellido = ApellidoIngreso;
            this.FechaNac = FechaNac;
            this.Apodo = ApodoIngreso;

            this._salario = new List<Salario>();
        }
        //Preguntar carga de lista


        public override string GetNombreCompleto()
        {
            return $"Bedel {Apodo}";
        }
    }
}
