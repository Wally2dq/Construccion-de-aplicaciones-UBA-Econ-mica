using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaIndumentaria
{
    public class NegativoExepcion : Exception
    {
        public NegativoExepcion(string msg) : base(msg) { }
    }
}
