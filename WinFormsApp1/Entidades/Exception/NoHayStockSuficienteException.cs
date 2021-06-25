using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeEntidades.Entidades.Exepction //Presta atencion con los namespace o te va a saltar un error
{
    public class NoHayStockSuficienteException : Exception
    {
        public NoHayStockSuficienteException(string msg) : base(msg) { }
    }
}
