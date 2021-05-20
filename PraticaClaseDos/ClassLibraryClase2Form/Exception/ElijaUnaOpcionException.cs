using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryClase2Form
{
    public class ElijaUnaOpcionException :Exception
    {
        public ElijaUnaOpcionException(string msg) : base(msg) { }
    }
}
