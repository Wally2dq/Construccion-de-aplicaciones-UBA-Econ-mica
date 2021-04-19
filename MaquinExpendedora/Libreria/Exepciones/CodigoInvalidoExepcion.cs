using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaExpendedora.Exepciones
{
    public class CodigoInvalidoExepcion : Exception
    {
        public CodigoInvalidoExepcion(string msg) : base(msg)
        {

        }
    }
}
