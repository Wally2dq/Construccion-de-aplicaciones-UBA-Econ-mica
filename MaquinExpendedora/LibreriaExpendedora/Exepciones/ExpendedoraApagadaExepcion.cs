using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaExpendedora.Exepciones
{
    class ExpendedoraApagadaExepcion : Exception
    {
        public ExpendedoraApagadaExepcion(string msg) : base(msg);
    }
}
