using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaFacultad
{
    public class AlumnoExistenteException :Exception
    {
        public AlumnoExistenteException(string msg) : base(msg) { }
    }
}
