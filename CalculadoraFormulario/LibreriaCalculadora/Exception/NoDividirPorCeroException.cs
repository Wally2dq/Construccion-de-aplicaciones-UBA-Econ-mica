using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaCalculadora
{
    public class NoDividirPorCeroException : Exception
    {
        public NoDividirPorCeroException(string msg) : base(msg) { }
    }
}
