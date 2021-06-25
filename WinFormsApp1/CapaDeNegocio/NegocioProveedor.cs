using CapaDeDatos;
using CapaDeEntidades.Entidades;
using CapaDeEntidades.Entidades.Exepction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeNegocio
{
    public class NegocioProveedor
    {
        List<Proveedor> _listaProveedores;
        ProveedorMapper _mapper;

        public NegocioProveedor()
        {
            _listaProveedores = new List<Proveedor>();
            _mapper = new ProveedorMapper();
        }


        public List<Proveedor> TraerListaProveedores()
        {
            _listaProveedores = _mapper.TraerTodosProveedores();

            return _listaProveedores;
        }

        public List<Proveedor> TraerPorCodigo(int codigo)
        {
            List<Proveedor> p = _mapper.TraerPorCodigo(codigo);

            if (p == null)
                throw new ProveedorInexistenteException("No se encuentra proveedor con Codigo: " + codigo);

            return p;
        }

        public TransactionResult insertar(Proveedor prov)
        {
            BuscarRepetido(prov);
            return _mapper.Insertar(prov);

        }


        private void BuscarRepetido(Proveedor prov)
        {
            _listaProveedores = _mapper.TraerTodosProveedores();
            foreach (Proveedor p in _listaProveedores)
            {
                if (p.Equals(prov))
                {
                    throw new ProveedorExisteException($"Codigo {prov.Usuario} ya registrado, ingrese otro codigo");
                }

            }
        }

    }
}
