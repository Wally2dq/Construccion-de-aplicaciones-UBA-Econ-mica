using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;
using CapaDatos;

namespace CapaNegocio
{
    public class NegocioPrestamo
    {
        List<Prestamo> _lstPrestamo;
        PrestamoMappers _mapper = new PrestamoMappers();

        public NegocioPrestamo() 
        {
            _lstPrestamo = new List<Prestamo>();
        }

        public ResultadoTransaccion AltaPrestamo(Prestamo prestamo) 
        {
            ResultadoTransaccion lst = _mapper.InsertarPrestamo(prestamo);

            return lst;
        }

        public List<Prestamo> TraerPorId(int id) 
        {
           List<Prestamo>lst= _mapper.TraerTodosPrestamo(id);

            return lst;
        }
    }
}
