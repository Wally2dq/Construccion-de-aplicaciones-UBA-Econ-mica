using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using ClaseEntidades;

namespace CapaNegocio
{
    public class Negocio
    {
        private ClienteMapper _clinteMapper;

        private List<Cliente> _listaClientes;

        public Negocio()
        {
            _clinteMapper = new ClienteMapper();
            _listaClientes = new List<Cliente>();
        }

        public List<Cliente> Traer()
        {
            // Traigo del servicio los clientes
            _listaClientes = _clinteMapper.TraerTodos();

            // REGLAS DE NEGOCIO > sean mayores, activos, pares, etc

            // va con try catch  y validaciones

            return _listaClientes;
        }

        public TransactionResult Agregar(int id ,string usuario,string nombre, string apellido, string direccion, string dni,string FechaNac)
        {
            Cliente cliente = new Cliente(id,nombre, apellido,dni, direccion, FechaNac, usuario);

            return _clinteMapper.Insertar(cliente);
        }
    }
}
