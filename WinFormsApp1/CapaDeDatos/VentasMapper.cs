using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDeEntidades.Entidades;
using Newtonsoft.Json;

namespace CapaDeDatos
{
    public class VentasMapper
    {
        public List<Venta> TraerTodoVentas() 
        {
            string json = WebHelperVentaHardware.Get("Ventas");
            List<Venta> lst = MapLista(json);
            return lst;
        }

        private List<Venta> MapLista(string json)
        {
            List<Venta> lst = JsonConvert.DeserializeObject<List<Venta>>(json);
            return lst;
        }

        public TransactionResult AltaVenta(Venta venta) 
        {
            NameValueCollection obj = ReverseMap(venta);

            string json = WebHelperVentaHardware.Post("Ventas", obj);

            TransactionResult lst = JsonConvert.DeserializeObject<TransactionResult>(json);

            return lst;
        }

        private NameValueCollection ReverseMap(Venta venta)
        {
            NameValueCollection n = new NameValueCollection();
            n.Add("idCliente", venta.idCliente.ToString());
            n.Add("idProducto", venta.idProducto.ToString());
            n.Add("Cantidad", venta.cantidad.ToString());
            n.Add("FechaAlta", venta.fechaCompra.ToString());
            n.Add("Usuario", venta.Usuario.ToString());
            n.Add("Estado","0");

            return n;
        }
    }
}
