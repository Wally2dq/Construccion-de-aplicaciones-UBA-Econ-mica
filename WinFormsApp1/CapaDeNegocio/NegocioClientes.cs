using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDeEntidades.Entidades;
using CapaDeDatos;
using CapaDeEntidades.Entidades.Exepction;

namespace CapaDeNegocio.Clientes
{
    public class NegocioClientes
    {
        List<Cliente> _listaClientes;
        ClienteMapper _mapper;

        public NegocioClientes() 
        {
            _listaClientes = new List<Cliente>();
            _mapper = new ClienteMapper();
        }

        public List<Cliente> TraerListaClientes() 
        {
            _listaClientes = _mapper.TraerTodosClientes();

           
            return _listaClientes;
        }

        public Cliente TraerPorCodigo(int codigo) 
        {
            Cliente c = _mapper.TraerPorCodigo(codigo);

            if (c == null)
                throw new ClienteInexisteException("No se encuentra Cliente con Codigo: " + codigo);

            return c;
        }

        public TransactionResult Insertar(string usuario, string nombre, string apellido, string direccion, string dni, string fechaNac, string email, string telefono)
        {
            Cliente cliente = new Cliente(usuario,nombre,apellido,direccion,dni,fechaNac,email,telefono);

            BuscarRepetido(cliente);

            return _mapper.Insertar(cliente);
        }

        private void BuscarRepetido(Cliente cliente)
        {
            _listaClientes = _mapper.TraerTodosClientes();
            foreach (Cliente i in _listaClientes)
            {
                if (i.Equals(cliente))
                {
                    throw new ClienteExisteException("Cliente ya Registrado \nIngrese otro codigo de Cliente");
                }

            }
        }

        public Cliente BuscarCliente(string Codigo)
        {
            _listaClientes = _mapper.TraerTodosClientes();
            foreach (Cliente c in _listaClientes)
            {
                if (c.usuario == Codigo)
                    return c;
            }

            throw new ClienteInexisteException("No existe Cliente registrado");
        }

        public string MostrarDatosCliente(Cliente cliente) 
        {
            Cliente c = cliente;

            return string.Format($"Cliente {c.id} " +
                $"\nUsuario: {c.usuario} " +
                $"\nNombre: {c.Nombre} " +
                $"\nApellido: {c.Ape} " +
                $"\nDni: {c.Ape} " +
                $"\nDireccion: {c.Direccion} " +
                $"\nEmail:{c.email} " +
                $"\nTelefono :{c.telefono} " +
                $"\nFecha Nacimiento: {c.fechaNacimiento} " ); 
        }
    }
}
