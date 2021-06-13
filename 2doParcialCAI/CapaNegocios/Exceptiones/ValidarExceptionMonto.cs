using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios.Exceptiones
{
    public class ValidarExceptionMonto : Exception
    {
        public ValidarExceptionMonto(string msg) : base(msg) { }
    }
}
