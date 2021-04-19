using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaExpendedora.Exepciones
{
    public class DineroInsuficienteExepcion : Exception
    {
        public DineroInsuficienteExepcion(string msg) : base(msg) 
        {

        }
    }
}
