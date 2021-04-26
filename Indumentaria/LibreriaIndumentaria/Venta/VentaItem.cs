using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaIndumentaria
{
    public class VentaItem
    {
        Indumentaria _prenda;

        private int _cantidad;

        public VentaItem(int CantidadIngreso, Indumentaria Ingreso) 
        {
            _cantidad = CantidadIngreso;
            _prenda = Ingreso;
        }

        public double GetTotal() 
        {
            throw new NotImplementedException(); 
        }

    }
}
