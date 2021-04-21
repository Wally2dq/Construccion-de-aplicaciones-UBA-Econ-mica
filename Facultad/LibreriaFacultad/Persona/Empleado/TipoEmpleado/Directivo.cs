using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaFacultad
{
    public class Directivo : Empleado
    {
        public override string GetNombreCompleto()
        {
            return $"Docente {Nombre}";
        }
    }
}
