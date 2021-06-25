using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeEntidades.Entidades.Exepction
{
    public class ValidarNumeroException:Exception
    {
        public ValidarNumeroException(string msg) : base(msg) { }
    }
}
