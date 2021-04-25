using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaFacultad
{
    public class EmpleadoInexistenteExepcion : Exception
    {
        public EmpleadoInexistenteExepcion(string msg) : base(msg) { }
    }
}
