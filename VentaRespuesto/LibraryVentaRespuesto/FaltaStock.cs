using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryVentaRespuesto
{
    public class FaltaStock : Exception
    {
        public FaltaStock(string msg) : base(msg) { }
    }
}
