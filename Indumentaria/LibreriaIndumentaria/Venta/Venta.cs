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

        public int Estado { get => _estado; }
        public int Codigo { get => _codigo; }

        public Venta(int CodigoIng, int EstadoIng, Cliente ingreso) 
        {
            _Items = new List<VentaItem>();
            _estado = EstadoIng;
            _codigo = CodigoIng;
            _Cliente = ingreso;
        }

        public double GetTotalPedido() 
        {
            throw new NotImplementedException();
        }

    }
}
