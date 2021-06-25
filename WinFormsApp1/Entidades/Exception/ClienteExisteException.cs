using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeEntidades.Entidades.Exepction //Presta atencion en el NAMESPACE
{
    public class ClienteExisteException : Exception
    {
        public ClienteExisteException(string msg) : base(msg) { }
    }
}
