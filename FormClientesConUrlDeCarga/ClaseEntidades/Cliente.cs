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
    public class Cliente : Persona
    {
        private int _id;

        private string _direccion;
        private string _DNI;
        private string _usuario;
        private string _fechaNac;




        [DataMember(Name = "DNI")]
        public string DNI { get => _DNI; set => _DNI = value; }

        [DataMember(Name = "id")]
        public int id { get => _id; set => _id = value; }

        [DataMember(Name = "direccion")]
        public string Direccion { get => _direccion; set => _direccion = value; }

        [DataMember(Name = "fechaNacimiento")]
        public string fechaNacimiento { get => _fechaNac; set => _fechaNac = value; }

        [DataMember(Name = "usuario")]
        public string usuario { get => _usuario; set => _usuario = value; }

        public Cliente(int id,string Nombre,string Apellido, string DNI,string Direccion, string FechaNac,string Usuario) : base(Nombre,Apellido)
        {
            _id = id;
            _DNI = DNI;
            _direccion = Direccion;
            _usuario = Usuario;
            _fechaNac = FechaNac;
        }

        public Cliente()
        {

        }


        public override string ToString()
        {
            return string.Format($"Cliente {this._id}, Usuario: {this._usuario}, Nombre: {this._nombre}, Apellido: {this._apellido}, Dni: {this._DNI}, Direccion: {this._direccion}, Fecha Nacimiento: {this._fechaNac}" );
        }
    }
}
