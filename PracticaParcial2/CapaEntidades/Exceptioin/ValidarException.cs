using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class ValidarException : Exception
    {
        public ValidarException(string msg) : base(msg) { }
    }
}
