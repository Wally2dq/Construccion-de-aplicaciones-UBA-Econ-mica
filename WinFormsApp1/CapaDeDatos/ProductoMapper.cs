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
    public class ProductoMapper
    {
        public List<Producto> TraerTodosProductos()
        {
            string json2 = WebHelperVentaHardware.Get("Productos");
            List<Producto> lst = MapList(json2);
            return lst;
        }

        private List<Producto> MapList(string json2)
        {
            List<Producto> lst = JsonConvert.DeserializeObject<List<Producto>>(json2);
            return lst;
        }

        public Producto TraerPorCodigo(int codigo)
        {
            string jsons = WebHelperVentaHardware.Get("Productos/" + codigo.ToString());
            Producto producto = JsonConvert.DeserializeObject<Producto>(jsons);
            return producto;
        }

        private Producto Map(string jsons)
        {
            Producto producto = JsonConvert.DeserializeObject<Producto>(jsons);
            return producto;
        }

        public TransactionResult Insertar(Producto producto)
        {
            NameValueCollection obj = ReverseMap(producto);

            string json = WebHelperVentaHardware.Post("Productos", obj);

            TransactionResult lst = JsonConvert.DeserializeObject<TransactionResult>(json);

            return lst;

        }

        private NameValueCollection ReverseMap(Producto producto)
        {
            NameValueCollection p = new NameValueCollection();
            p.Add("idCategoria", producto.idCategoria.ToString());
            p.Add("Nombre", producto.Nombre.ToString());
            p.Add("Stock", producto.Stock.ToString());
            p.Add("Precio", producto.Precio.ToString("0.00"));
            p.Add("FechaAlta",producto.FechaAlta.ToString());
            p.Add("Usuario", producto.Usuario.ToString());
            p.Add("idProveedor", producto.idProveedor.ToString());
            return p;

        }

        public TransactionResult Modificar(Producto producto)
        {
            NameValueCollection obj = ReverseMapUpdate(producto);

            string json = WebHelperVentaHardware.Put("Productos", obj);

            TransactionResult lst = JsonConvert.DeserializeObject<TransactionResult>(json);

            return lst;

        }
        private NameValueCollection ReverseMapUpdate(Producto producto)
        {
            NameValueCollection p = new NameValueCollection();
            p.Add("id", producto.id.ToString());
            p.Add("Stock", producto.Stock.ToString());
            p.Add("Precio", producto.Precio.ToString());
            p.Add("Nombre", producto.Nombre);
            p.Add("idCategoria",producto.idCategoria.ToString());
            p.Add("idProveedor", producto.idProveedor.ToString()); 
            return p;

        }


    }
}
