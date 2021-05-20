using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryClase2Form
{
    public class ValidarStringException : Exception
    {
        public ValidarStringException(string msg) : base(msg) { }
    }
}
