using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryVentaRespuesto
{
    public class CotrolesVentaRes
    {
        List<Respuesto> _listaProductos;
        private string _nombreComercio;
        private string _direccion;

        public string NombreComercio { get => this._nombreComercio; set => this._nombreComercio = value; }
        public string Direccion { get => this._direccion; set => this._direccion = value; }

        public CotrolesVentaRes(string NombreIng, string DireIng)
        {
            NombreComercio = NombreIng;
            Direccion = DireIng;
            _listaProductos = new List<Respuesto>();
        }


        public void AgregarRespuesto(Respuesto obj) 
        {
            bool flag = true;

            foreach (Respuesto res in _listaProductos) 
            {
                if ((res.CodigoRes.Equals(obj.CodigoRes)) ==true) 
                {
                    flag = false;
                    throw new CodigoYaRegistradoExepcion("Codigo ya registrado del respuesto");
                }
            }

            if (flag != false)
                _listaProductos.Add(obj);
        }

        private Respuesto BuscarRes(int Codigo) 
        {
            foreach(Respuesto i in _listaProductos)
            {
                if ((i.CodigoRes.Equals(i.CodigoRes)) == true)
                    throw new CodigoInexistenteExepcion("No existe Codigo Registrado");
            }
            return _listaProductos.SingleOrDefault(i=>i.CodigoRes==Codigo);
        }

        public void QuitarRespuesto(int Codigo) 
        {
             Respuesto Res =BuscarRes(Codigo);

            if (!(Res == null))
            {
                if (Res.Stock > 0)
                {
                    throw new RespuestoStockExpecion("No se puede eliminar Respuestos con stock");
                }
                else 
                {
                    _listaProductos.Remove(Res);
                }
            }
            
        }

        public void ModiicarPrecio(int Codigo, double PrecioNuevo) 
        {
            Respuesto res = BuscarRes(Codigo);

            if (!(res == null))
                res.Precio = PrecioNuevo;

        }

        public void AgregarStock(int Codigo, int StockNuevo) 
        {
            Respuesto res = BuscarRes(Codigo);

            if (!(res == null))
                res.Stock += StockNuevo;
        }

        public void QuitarStock(int Codigo, int StockQuitar) 
        {
            Respuesto res = BuscarRes(Codigo);

            if (!(res == null)) 
            {
                if ((res.Stock - StockQuitar) < 0)
                {
                    throw new FaltaStock("No puede quedar stock en negativo");
                }
                else 
                {
                    res.Stock -= StockQuitar;
                }
            }
        }

        public List<Respuesto> TraerPorCategorio(int Categoria) 
        {
            if ((_listaProductos.SingleOrDefault(i => i.CodigoCat == Categoria)) == null)
                throw new CodigoInexistenteExepcion("No se registra Codigo de Categorio");

            return _listaProductos.Where(i=> i.CodigoCat==Categoria).ToList() ;
        }

        public List<Respuesto> MostrarRespuestos()
        {
            if (_listaProductos.Count == 0)
                throw new ListaSinDatosExepcion("No hay datos Cargados");
            return _listaProductos;
        }

    }
}
