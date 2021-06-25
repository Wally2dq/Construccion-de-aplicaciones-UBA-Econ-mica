using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeEntidades.Entidades.Exepction
{
    public class PrecioNegativoExcepction : Exception
    {
        public PrecioNegativoExcepction(string msg) : base(msg) { }
    }
}
