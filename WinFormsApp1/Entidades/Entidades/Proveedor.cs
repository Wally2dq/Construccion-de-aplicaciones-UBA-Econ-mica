using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeEntidades.Entidades
{
    [DataContract]
    public sealed class Proveedor : Persona
    {
        private int idProducto;
        private string nombre;
        private string email;
        private string cuit;
        private bool activo;
        private string fechaAlta;
        private string fechaBaja;
        private int id;
        private int usuario;
        [DataMember]
        public int IdProducto { get => idProducto; set => idProducto = value; }
        [DataMember]

        public string Nombre1 { get => nombre; set => nombre = value; }
        [DataMember]

        public string Email { get => email; set => email = value; }
        [DataMember]

        public string Cuit { get => cuit; set => cuit = value; }
        [DataMember]

        public bool Activo { get => activo; set => activo = value; }
        [DataMember]

        public string FechaAlta { get => fechaAlta; set => fechaAlta = value; }
        [DataMember]

        public string FechaBaja { get => fechaBaja; set => fechaBaja = value; }
        [DataMember]

        public int Id { get => id; set => id = value; }
        [DataMember]

        public int Usuario { get => usuario; set => usuario = value; }



        public Proveedor(int idProducto, string nombre, string apellido, string email, string cuit, bool activo, string fechaAlta, string fechaBaja, int id, int usuario) : this(nombre, apellido)
        {
            this.Email = email;
            this.Cuit = cuit;
            this.Activo = activo;
            this.FechaAlta = fechaAlta;
            this.FechaBaja = fechaBaja;
            this.Id = id;
            this.Usuario = usuario;
        }

        public Proveedor()
        {

        }

        public Proveedor(string Nombre, string Apellido) : base(Nombre, Apellido)
        {
        }

        public override string GetNombreCompleto()
        {
            return $"{Id} - {_razonSocial}";
        }
        
        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            if (!(obj is Proveedor))
                return false;

            Proveedor proveedor = (Proveedor)obj;

            if (proveedor.Usuario != this.Usuario)
                return false;

            return true;
        }

        public int getCodigoProveedor()
        {
            return this.Id;
        }

        public override string ToString()
        {
            return "ID: " + this.Usuario + " Nombre: " + this.Nombre + " Apellido " + this.Ape + " Fecha Alta: " + FechaAlta +" Email: "+Email+" Cuit: "+Cuit; 
        }
    }
}
