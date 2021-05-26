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

        protected string _apellido;
        [DataMember]
        public string Nombre { get => _nombre; set => _nombre = value; }

        [DataMember(Name = "apellido")]
        public string Ape { get => _apellido; set => _apellido = value; }

        public Persona(string Nombre,string Apellido) 
        {
            _nombre = Nombre;
            _apellido = Apellido;
        }
        public Persona() { }
    }
}
