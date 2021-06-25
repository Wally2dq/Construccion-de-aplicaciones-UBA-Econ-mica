using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDeEntidades.Entidades;
using CapaDeDatos;
using CapaDeEntidades.Entidades.Exepction;

namespace CapaDeNegocio.Ventas
{
    public class NegocioVentas
    {
        List<Venta> _listVentas;
        VentasMapper _ventasMapper;

        List<Producto> _listProducto = new List<Producto>();
        ProductoMapper _mapper = new ProductoMapper();

        public NegocioVentas() 
        {
            _listVentas = new List<Venta>();
            _ventasMapper = new VentasMapper();
        }

        public List<Venta> TraerTodasVentas() 
        {
            List<Venta> lst = _ventasMapper.TraerTodoVentas();


            return lst;
        }

        public List<Venta> TraerPorUsuario(int Usuario) 
        {
            List<Venta> lst = _ventasMapper.TraerTodoVentas();

            List<Venta> lstSalida = new List<Venta>();

            foreach (Venta v in lst) 
            {
                if (v.Usuario == Usuario)
                    lstSalida.Add(v);
            }

            return lstSalida;
        }

        public Producto BuscarProductoSinUrl(string Codigo)
        {
            _listProducto = _mapper.TraerTodosProductos();
            foreach (Producto c in _listProducto)
            {
                if (c.id == Codigo)
                    return c;
            }

            throw new ClienteInexisteException("No existe Producto registrado");
        }

        public TransactionResult AltaVenta(Venta venta) 
        {
            return _ventasMapper.AltaVenta(venta);
        }
    }
}
