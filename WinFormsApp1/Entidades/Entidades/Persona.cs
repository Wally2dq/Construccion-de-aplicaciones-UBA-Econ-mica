using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeEntidades.Entidades
{
    [DataContract]
    public abstract class Persona
    {
        protected string _apellido;
        protected string _nombre;
        protected string _razonSocial;

        [DataMember (Name ="nombre")]
        public string Nombre { get => _nombre; set => _nombre = value; }

        [DataMember(Name = "apellido")]
        public string Ape { get => _apellido; set => _apellido = value; }

        public Persona() { }

        public Persona(string Nombre,string Apellido) 
        {
            _nombre = Nombre;
            _apellido = Apellido;
        }

        public Persona(string RazonSocial) //Pongo el contructor asi porque un proveedor tiene nombre
            //Pero no tiene apellido, pero pueden tener razon social, que es el "Nombre"
        {
            _razonSocial = RazonSocial;
        }

        public abstract string GetNombreCompleto();
    }
}
