using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaIndumentaria
{
    public class ListaSinDatosExepcion: Exception
    {
        public ListaSinDatosExepcion() : base("Lista sin datos Cagados") { }
    }
}
