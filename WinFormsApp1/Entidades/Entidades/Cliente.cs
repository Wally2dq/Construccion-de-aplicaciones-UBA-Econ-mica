using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeEntidades.Entidades
{
    [DataContract]
    public sealed class Cliente : Persona
    {
        private int _id;

        private string _direccion;
        private string _DNI;
        private string _usuario;
        private string _fechaNac;

        private string _email;
        private string _telefono;

        public Cliente() 
        {
        }

       /* [{"dni":222,
            "nombre":"Walter",
            "apellido":"Quintana",
            "direccion":"123",
            "email":null,
            "telefono":null,
            "fechaNacimiento":"1998-02-09T00:00:00",
            "fechaAlta":"2021-06-01T15:11:54",
            "activo":false,
            "usuario":"889040",
            "host":"190.50.37.209",
            "id":456}]*/
        

        [DataMember(Name = "dni")]
        public string dni { get => _DNI; set => _DNI = value; }

        [DataMember(Name = "id")]
        public int id { get => _id; set => _id = value; }

        [DataMember(Name = "direccion")]
        public string Direccion { get => _direccion; set => _direccion = value; }

        [DataMember(Name = "fechaNacimiento")]
        public string fechaNacimiento { get => _fechaNac; set => _fechaNac = value; }

        [DataMember(Name = "email")]
        public string email { get => _email; set => _email = value; }
        [DataMember(Name = "telefono")]
        public string telefono { get => _telefono; set => _telefono = value; }
        [DataMember(Name = "usuario")]
        public string usuario { get => _usuario; set => _usuario = value; }

        public Cliente(string usuario, string nombre, string apellido, string direccion, string dni, string fechaNac, string email, string telefono) : base(nombre, apellido) 
        {
            _direccion = direccion;
            _DNI = dni;
            _fechaNac = fechaNac;
            _email = email;
            _telefono = telefono;
            _usuario = usuario;
        }

        public string getCodigoCliente()
        {
            return this._id.ToString();
        }

        public override string GetNombreCompleto()
        {
            return string.Format($"\nUsuario: {this._usuario}"+
                $"\n Apellido: {this._apellido} " +
                $"\n Dni: {this._DNI} ");


           /* return string.Format($"Cliente {this._id} " +
                $"\nUsuario: {this._usuario} " +
                $"\nNombre: {this._nombre} " +
                $"\nApellido: {this._apellido} " +
                $"\nDni: {this._DNI} " +
                $"\nDireccion: {this._direccion} " +
                $"\nEmail:{this._email} " +
                $"\nTelefono :{this._telefono} " +
                $"\nFecha Nacimiento: {this._fechaNac} " ); */
        }

        

        public override string ToString()
        {
            return GetNombreCompleto();
        }

       
        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            if (!(obj is Cliente))
                return false;

            Cliente cliente = (Cliente)obj;

            if (cliente._usuario != this._usuario)
                return false;

            return true;
        }

       
    }
}
