using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaIndumentaria
{
    public sealed class Pantalon : Indumentaria
    {
        private string _material;
        private bool _tieneBolsillos;

        protected override string GetDetalle()
        {
            throw new NotImplementedException();
        }

    }
}
