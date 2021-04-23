using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaFacultad
{
    public class AlumnoInexistenteExepcion : Exception
    {
        public AlumnoInexistenteExepcion(string msg) : base(msg) { }
    }
}
