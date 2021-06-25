using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using CapaDeEntidades.Entidades.Exepction;

namespace CapaDeEntidades.Entidades
{
    [DataContract]
    public class Producto
    {
        private string _id;
        private string _nombreProducto;
        private double _precio;
        private int _stock;
        private int _usuario;
        private DateTime _fechaAlta;
        private int _idCategoria;
        private int _idProveedor;

        /*
         * dCategoria
integer($int32)
Nombre
string
Stock
integer($int32)
Precio
number($double)
FechaAlta
string($date-time)
Usuario
integer($int32)
id
         */
        [DataMember(Name = "id")]
        public string id { get => _id; set => _id = value; }//Id del producto
        [DataMember(Name = "idProveedor")]
        public int idProveedor { get => _idProveedor; set => _idProveedor = value; }
        [DataMember(Name = "Nombre")]
        public string Nombre { get => _nombreProducto; set => _nombreProducto = value; }
        [DataMember(Name = "Stock")]
        public int Stock { get => _stock; set => _stock = value; }
        [DataMember(Name = "Precio")]
        public double Precio { get => _precio; set => _precio = value; }
        [DataMember(Name = "Usuario")]
        public int Usuario { get => _usuario; set => _usuario = value; }
        [DataMember(Name = "FechaAlta")]
        public DateTime FechaAlta { get => _fechaAlta; set => _fechaAlta = value; }
        [DataMember(Name = "idCategoria")]
        public int idCategoria { get => _idCategoria; set => _idCategoria = value; }

        public Producto() { }

        public int RestarStock(int Resta) 
        {
            int StockSinTocar = _stock;

            if (Resta <= 0)
                throw new ValidarNumeroException("Ingrese una cantidad mayor a 0");

            if (StockSinTocar == 0)
                throw new NoHayStockSuficienteException($"No hay stock de {Nombre}" );

            if ((StockSinTocar - Resta) < 0)
                throw new NoHayStockSuficienteException($"No hay stock suficiente de {Nombre}, Quedan {Stock} de stock");

            return StockSinTocar -= Resta;
        }
        

        public int AgregarStock(int Agregar)
        {
            if (Agregar ==0)
                throw new ProductoStockAgregarException($"Debe agregar un Stock mayor a 0");

            if (Agregar < 0)
                throw new ProductoStockAgregarException("El stock no debe ser negativo");


            return _stock += Agregar;
        }

        public double CalcularTotal(int Cantidad) 
        {
            return Cantidad * Precio;
        }

        public double ModificarPrecio(double PrecioMod) 
        {
            if (PrecioMod < 0)
                throw new PrecioNegativoExcepction("El precio no puede ser Negativo");

            _precio = PrecioMod;

            return _precio;
        }

        public override string ToString()
        {
            return $"Codigo: {Usuario}" +
                   $"\n Nombre: {Nombre}" +
                   $"\n Precio: $ {Precio}" +
                   $"\n Stock: {Stock}" +
                   $"\n Nro de categotia: {idCategoria}";
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            if (!(obj is Producto))
                return false;

            Producto producto = (Producto)obj;

            if (producto._usuario != this._usuario)
                return false;

            return true;
        }
    }
}
