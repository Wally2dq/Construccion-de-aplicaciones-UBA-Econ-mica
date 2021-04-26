using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaIndumentaria
{
    public class TiendaRopa
    {
        List<Indumentaria> _Inventario;
        List<Venta> _Ventas;

        private int UltimoCodigo;

        public TiendaRopa() 
        {
            _Inventario = new List<Indumentaria>();
            _Ventas = new List<Venta>();
        }

        private int GetProximoCodigo() 
        {
            return UltimoCodigo++;
        }

        public void AgregarIndumentaria(Indumentaria obj) 
        {
            foreach (Indumentaria i in _Inventario) 
            {
                if (i.Equals(obj))
                    throw new CodigoRegistradoExepcion("Codigo Ya Registrado" +
                        "\nIngrese otra indumentaria");
            }

            _Inventario.Add(obj);
        }

        public void ModificarIndumentaria(Indumentaria Obj) 
        {
            bool flag=true;

            if (_Inventario.Count == 0)
            {
                throw new ListaSinDatosExepcion();
            }
            else 
            {
                foreach (Indumentaria i in _Inventario)
                {
                    if (i.Equals(Obj) == true)
                    {
                        Indumentaria Cambio = i;
                        Cambio = Obj;
                        flag = true;
                        break;
                    }
                    else
                    {
                        flag = false;
                    }

                }
            }

            if (flag == false)
                throw new CodigoNoRegistradoExepcion();
           
        }

        public void QuitarIndumentaria(Indumentaria Obj) 
        {
            if (_Inventario.Count == 0)
                throw new ListaSinDatosExepcion();

            _Inventario.Remove(Obj);
        }
        public void IngresarOrden(Venta Obj) 
        {
            _Ventas.Add(Obj);
        }
        public List<Indumentaria> Listar() 
        {
            if (_Inventario.Count == 0)
                throw new ListaSinDatosExepcion();

            return _Inventario;
        }
        public List<Venta> ListarOrden() 
        {
            return _Ventas;
        }

        public void DevolverOrden(Venta obj) 
        {
            
        }

        public Indumentaria TraerIndumentaria(int Codigo) 
        {
            if ((_Inventario.SingleOrDefault(i => i.Codigo == Codigo) == null))
                throw new CodigoNoRegistradoExepcion();

            return _Inventario.SingleOrDefault(i => i.Codigo == Codigo);
        }
    }
}
