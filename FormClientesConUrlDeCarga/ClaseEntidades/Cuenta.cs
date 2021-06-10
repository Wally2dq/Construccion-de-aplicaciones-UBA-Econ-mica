using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace ClaseEntidades
{
    [DataContract]
    public class Cuenta
    {
        public Cuenta _cuenta;

        
        private string _descripcion;
        private double _saldo;
        private DateTime _fechaApertura;
        private DateTime _fechaModificacion;
        private int _idCliente;
        private int _id;

        [DataMember(Name = "Descripcion")]
        public string descripcion { get => this._descripcion; set => this._descripcion = value; }
        [DataMember(Name = "Saldo")]
        public double saldo { get => this._saldo; set => this._saldo = value; }
        [DataMember(Name = "FechaAapertura")]
        public DateTime fechaApertura { get => this._fechaApertura; set => this._fechaApertura = value; }
        [DataMember]
        public DateTime fechaModificacion { get => this._fechaModificacion; set => this._fechaModificacion = value; }
        [DataMember(Name = "idCliente")]
        public int idCliente { get => this._idCliente; set => this._idCliente = value; }
        [DataMember(Name = "id")]
        public int id { get => this._id; set => this._id = value; }

        public Cuenta() 
        {

        }


    }
}
