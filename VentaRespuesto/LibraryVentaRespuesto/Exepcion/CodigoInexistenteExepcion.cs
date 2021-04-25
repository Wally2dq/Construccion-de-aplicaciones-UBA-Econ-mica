using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryVentaRespuesto
{
    public class CodigoInexistenteExepcion : Exception
    {
        public CodigoInexistenteExepcion(string msg) : base(msg) { }
    }
}
