using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaFacultad
{
    public class EmpleadoExistenteException : Exception
    {
        public EmpleadoExistenteException(string msg) : base(msg) { }
    }
}
