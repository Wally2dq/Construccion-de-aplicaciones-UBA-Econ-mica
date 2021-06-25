using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeEntidades.Entidades.Exepction //Presta atencion en el NAMESPACE
{
    public class ClienteInexisteException : Exception
    {
        public ClienteInexisteException(string msg) : base(msg) { }
    }
}
