using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaIndumentaria
{
    public class Venta
    {
        List<VentaItem> _Items;
        Cliente _Cliente;

        private int _estado;
        private int _codigo;

        public double GetTotalPedido() 
        {
            throw new NotImplementedException();
        }

    }
}
