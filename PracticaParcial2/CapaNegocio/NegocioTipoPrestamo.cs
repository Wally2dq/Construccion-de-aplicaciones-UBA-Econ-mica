using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;
using CapaDatos;

namespace CapaNegocio
{
    public class NegocioTipoPrestamo
    {
        List<PrestamoTipo> _lstTipoPrestamo;
        private PrestamoMappers _mapper;

        public NegocioTipoPrestamo() 
        {
            _lstTipoPrestamo = new List<PrestamoTipo>();
            _mapper = new PrestamoMappers();
        }

        public List<PrestamoTipo> TraerTiposPrestamo() 
        {
            List<PrestamoTipo> lst = _mapper.TraerTodosPT();
            return lst;
        }
    }
}
