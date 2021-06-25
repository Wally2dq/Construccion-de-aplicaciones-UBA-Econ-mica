using CapaDeDatos;
using CapaDeEntidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDeEntidades.Entidades.Exepction;

namespace CapaDeNegocio
{
    public class NegocioProducto
    {
        ProductoMapper _mapper;
        List<Producto> listaProductos;

        public NegocioProducto()
        {
            listaProductos = new List<Producto>();
            _mapper = new ProductoMapper();
        }

        public List<Producto> traerListaProductos()
        {
            return _mapper.TraerTodosProductos();
        }

        public Producto traerProductoPorID(int codigo)
        {
            Producto prod = _mapper.TraerPorCodigo(codigo);

            if (prod == null)
            {
                throw new ProductoInexistenteException("No se encuentra producto con id: " + codigo);
            }

            return prod;
        }

        public TransactionResult insertarProducto(Producto producto)
        {
            BuscarRepetido(producto);
            return _mapper.Insertar(producto);

        }


        private void BuscarRepetido(Producto prod)
        {
            listaProductos = _mapper.TraerTodosProductos();
            foreach (Producto p in listaProductos)
            {
                if (p.Equals(prod))
                {
                    throw new ProductoExistenteException($"Codigo {prod.Usuario} ya registrado, ingrese otro codigo");
                }

            }
        }

        public Producto buscarProducto(int codigo)
        {
            listaProductos = _mapper.TraerTodosProductos();
            Producto prod = listaProductos.Find(x => x.Usuario == codigo);

            if (prod == null)
            {
                throw new ProductoInexistenteException("No existe producto con id: " + codigo);
            }

            return prod;
        }

        public TransactionResult ModificarProducto(Producto prod) 
        {
            TransactionResult t = _mapper.Modificar(prod);

            return t;
        }

        public List<Producto> TraerPorProveedor(int idProveedor)
        {
            List<Producto> lst = _mapper.TraerTodosProductos();

            List<Producto> lstSalida = new List<Producto>();

            foreach (Producto p in lst)
            {
                if (p.idProveedor == idProveedor)
                    lstSalida.Add(p);
            }

            return lstSalida;
        }
    }
}
