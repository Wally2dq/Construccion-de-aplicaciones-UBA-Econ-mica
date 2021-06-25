using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeEntidades.Entidades
{
    [DataContract]
    public class Venta
    {
        private int _id;

        private int _idProducto;

        private int _idCliente;

        private int _cantidad;

        private int _usuario;

        private DateTime _fechaCompra;

        [DataMember]
        public int id { get => _id; set => _id = value; }
        [DataMember]
        public int idProducto { get => _idProducto; set => _idProducto = value; }
        [DataMember]
        public int idCliente { get => _idCliente; set => _idCliente = value; }
        [DataMember(Name ="Cantidad")]
        public int cantidad { get => _cantidad; set => _cantidad = value; }
        [DataMember(Name ="FechaAlta")]
        public DateTime fechaCompra { get => _fechaCompra; set => _fechaCompra = value; }
        [DataMember]
        public int Usuario { get => _usuario; set => _usuario = value; }

        /*"idCliente": 0,
    "idProducto": 0,
    "cantidad": 0,
    "estado": 0,
    "fechaAlta": "2021-06-03T17:26:09.818Z",
    "usuario": 0,
    "id": 0*/

        public Venta(int IdCliente,int Usuario, int IdProducto,int Cantidad,DateTime FechaCompra) 
        {
            _idCliente = IdCliente;

            _cantidad = Cantidad;

            _fechaCompra = FechaCompra;

            _idProducto = IdProducto;

            _usuario = Usuario;

        }

        public override string ToString()
        {
             return $"Factura: {id.ToString()}, Id Cliente: {_idCliente.ToString()}, Usuario: {_usuario.ToString()},Id Producto: {_idProducto.ToString()}, Cantidad: {cantidad.ToString()}, Fecha: {_fechaCompra.ToString()}";
        }

    }
}
