using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaExpendedora.Exepciones
{
    class NegativoExepcion : Exception
    {
        public NegativoExepcion(string msg) : base(msg)
        {

        }
    }
}

