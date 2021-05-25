using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace ClaseEntidades
{
    [DataContract]
    public abstract class Persona
    {
        protected string _nombre;
        [DataMember]
        public string Nombre { get => _nombre; set => _nombre = value; }
    }
}
