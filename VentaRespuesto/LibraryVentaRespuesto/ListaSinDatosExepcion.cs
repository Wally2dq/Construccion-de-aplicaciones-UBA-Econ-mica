using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryVentaRespuesto
{
    public class ListaSinDatosExepcion :Exception
    {
        public ListaSinDatosExepcion(string msg) : base(msg){ }
    }
}
