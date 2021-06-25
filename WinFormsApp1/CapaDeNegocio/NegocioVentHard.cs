using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDeEntidades.Entidades;
using CapaDeEntidades.Entidades.Exepction;//Uso las exception

namespace CapaDeNegocio.Negocio
{
    public class NegocioVentaDeHar
    {
        private List<Cliente> _clientes;
        private List<Venta> _venta;
        private List<Producto> _producto;
        private List<Proveedor> _proveedores;

        public NegocioVentaDeHar() 
        {
            _clientes = new List<Cliente>();
            _venta = new List<Venta>();
            _producto = new List<Producto>();
            _proveedores = new List<Proveedor>();
        }

        public void AltaCliente(string Codigo, string Nombre, string Apellido,bool Activo, string Direccion) 
        {
            Cliente cliente = new Cliente();

            if ((BuscarClienteRepetido(cliente) == true))
                _clientes.Add(cliente);

        }

        public void BajaCliente(Cliente clienteborrar) 
        {
            Cliente cliente = (Cliente)clienteborrar;

            foreach (Cliente i in _clientes) 
            {
                if (i.Equals(cliente))
                {
                    Cliente borrar = (Cliente)i;
                    _clientes.Remove(borrar);
                    break;
                }
            }
        }

        public void ModificarCliente() 
        {

        }

        public List<Cliente> MostrarListaCliente() 
        {
            return _clientes;
        }



        private bool BuscarClienteRepetido(Cliente cliente) 
        {
            foreach (Cliente i in _clientes) 
            {
                if (i.Equals(cliente))
                {
                    throw new ClienteExisteException("Cliente ya Registrado");
                }

            }
            return true;
        }

        public Cliente BuscarCliente(string Codigo) 
        {
            foreach (Cliente c in _clientes) 
            {
                if (c.getCodigoCliente() == Codigo)
                    return c;
            }

            throw new ClienteInexisteException("No existe Cliente registrado");
        }


       /* public void AltaProveedor(int codigo, string razonSocial)
        {
            Proveedor proveedor = new Proveedor(codigo, razonSocial);

            if ((BuscarProveedorRepetido(proveedor) == true))
                _proveedores.Add(proveedor);

        }*/

        public void BajaProveedor(Proveedor proveedorborrar)
        {
            Proveedor proveedor = (Proveedor)proveedorborrar;

            foreach (Proveedor i in _proveedores)
            {
                if (i.Equals(proveedor))
                {
                    Proveedor borrar = (Proveedor)i;
                    _proveedores.Remove(borrar);
                    break;
                }
            }
        }

        public void ModificarProveedor()
        {

        }

        public List<Proveedor> MostrarListaProveedores()
        {
            return _proveedores;
        }

        public List<Producto> MostrarListaProductosxProveedor()
        {
            return _producto;
        }

        private bool BuscarProveedorRepetido(Proveedor proveedor)
        {
            foreach(Proveedor p in _proveedores)
            {
                if (p.Equals(proveedor))
                {
                    throw new ClienteExisteException("Proveedor ya registrado");
                }

            }
            return true;
        }

        public Proveedor BuscarProveedor(int Codigo)
        {
            foreach (Proveedor p in _proveedores)
            {
                if (p.getCodigoProveedor() == Codigo)
                    return p;
            }

            throw new ClienteInexisteException("No existe proveedor registrado");
        }


    }
}
