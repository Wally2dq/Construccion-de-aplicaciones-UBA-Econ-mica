using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryClase2Form
{
    public class CodigoDeAlumnoYaRegistradoException : Exception
    {
        public CodigoDeAlumnoYaRegistradoException(string msg) : base(msg) { }
    }
}
