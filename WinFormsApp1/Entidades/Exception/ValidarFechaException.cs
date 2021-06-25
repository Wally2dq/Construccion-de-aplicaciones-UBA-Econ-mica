using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeEntidades.Entidades.Exepction
{
    public class ValidarFechaException : Exception
    {
        public ValidarFechaException(string msg) : base(msg) { }
    }
}
