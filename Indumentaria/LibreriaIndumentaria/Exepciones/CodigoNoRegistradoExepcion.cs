using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaIndumentaria
{
    public class CodigoNoRegistradoExepcion : Exception
    {
        public CodigoNoRegistradoExepcion() : base("Codigo No Registrado")
        {
        }
    }
}
