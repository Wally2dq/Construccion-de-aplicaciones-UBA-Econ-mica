using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaExpendedora.Exepciones
{
    public class SinStockExepcion : Exception
    {
        public SinStockExepcion(string msg) : base(msg) 
        {

        }
    }
}
