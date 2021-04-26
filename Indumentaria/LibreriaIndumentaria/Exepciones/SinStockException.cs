using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaIndumentaria
{
    public class SinStockException : Exception
    {
        public SinStockException(string msg) : base(msg) { }
    }
}
