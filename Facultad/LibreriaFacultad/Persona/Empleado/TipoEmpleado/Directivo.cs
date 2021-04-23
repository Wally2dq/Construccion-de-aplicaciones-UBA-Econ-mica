using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaFacultad
{
    public class Directivo : Empleado
    {
        public Directivo(int legajoIngreso, string NombreIngreso, string ApellidoIngreso, DateTime FechaNacimientoIngreso) //NO USAMOS FECHA DE NACIMIENTO EN EL ToString
        {
            this.Legajo = legajoIngreso;
            this.Nombre = NombreIngreso;
            this.Apellido = ApellidoIngreso;
            this.FechaNac = FechaNac;

            this._salario = new List<Salario>();
        }
        public override string GetNombreCompleto()
        {
            return $"Docente {Nombre}";
        }
    }
}
