﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryVentaRespuesto
{
    public class CodigoYaRegistradoExepcion : Exception
    {
        public CodigoYaRegistradoExepcion(string msg) : base(msg) { }
    }
}
