using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaNegocio;

namespace CapaNegocio.Exceptions
{
    public class ValidarNumeroException : Exception
    {
        public ValidarNumeroException(string msg) : base(msg) { }
    }
}
