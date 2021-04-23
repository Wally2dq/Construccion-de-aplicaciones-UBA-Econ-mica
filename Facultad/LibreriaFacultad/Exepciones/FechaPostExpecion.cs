using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaFacultad
{
    public class FechaPostExpecion :Exception
    {
        public FechaPostExpecion(string msg) : base(msg) { }
    }
}
