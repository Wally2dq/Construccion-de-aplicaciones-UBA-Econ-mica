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



        [DataMember(Name = "DNI")]
        public string DNI { get => _DNI; set => _DNI = value; }

        [DataMember(Name = "id")]
        public int id { get => _id; set => _id = value; }

        [DataMember(Name = "direccion")]
        public string Direccion { get => _direccion; set => _direccion = value; }

        public Cliente(int Id,string Nombre,string Apellido, string DNI,string Direccion) : base(Nombre,Apellido)
        {
            _id = Id;
            _DNI = DNI;
            _direccion = Direccion;
        }

        public Cliente()
        {

        }


        public override string ToString()
        {
            return string.Format($"Cliente {this._id}, Nombre: {this._nombre}, Apellido: {this._apellido}, Dni: {this._DNI}, Direccion: {this._direccion}");
        }
    }
}
