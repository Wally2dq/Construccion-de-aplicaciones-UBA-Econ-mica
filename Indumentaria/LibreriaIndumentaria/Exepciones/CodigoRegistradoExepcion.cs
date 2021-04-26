using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaIndumentaria
{
    public class CodigoRegistradoExepcion : Exception
    {
        public CodigoRegistradoExepcion(string msg) : base(msg) { }
    }
}
