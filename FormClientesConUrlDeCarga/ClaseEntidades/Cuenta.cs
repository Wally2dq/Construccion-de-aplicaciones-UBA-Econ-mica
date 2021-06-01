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
        private int _nroCuenta;
        private string _descripcion;
        private double _saldo;
        private DateTime _fechaApertura;
        private DateTime _fechaModificacion;
        private bool _activo;
        private int _idCliente;
        private int _id;

        [DataMember(Name = "descripcion")]
        public string descripcion { get => this.descripcion; set => this.descripcion = value; }
        [DataMember(Name = "saldo")]
        public double saldo { get => this._saldo; set => this._saldo = value; }
        [DataMember(Name = "fechaAapertura")]
        public DateTime fechaApertura { get => this._fechaApertura; set => this._fechaApertura = value; }
        [DataMember]
        public DateTime fechaModificacion { get => this._fechaModificacion; set => this._fechaModificacion = value; }
        [DataMember(Name = "activo")]
        public bool activo { get => this._activo; set => this._activo = value; }
        [DataMember(Name = "idCliente")]
        public int idCliente { get => this._idCliente; set => this._idCliente = value; }
        [DataMember(Name = "id")]
        public int id { get => this._id; set => this._id = value; }

        public Cuenta() 
        {

        }


    }
}
