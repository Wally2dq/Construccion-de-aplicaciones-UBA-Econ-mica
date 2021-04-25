using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryVentaRespuesto
{
     public class RespuestoStockExpecion : Exception
    {
        public RespuestoStockExpecion(string msg) : base(msg) { }
    }
}
