using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaFacultad
{
    public class Docente :Empleado
    {
        public Docente (int legajoIngreso, string NombreIngreso, string ApellidoIngreso, DateTime FechaNacimientoIngreso) //NO USAMOS FECHA DE NACIMIENTO EN EL ToString
        {
            this.Legajo = legajoIngreso;
            this.Nombre = NombreIngreso;
            this.Apellido = ApellidoIngreso;
            this.FechaNac = FechaNacimientoIngreso;

            this._salario = new List<Salario>();
        }
        public override string GetNombreCompleto()
        {
            return $"Sr. Director {Apellido}";
        }
    }
}
