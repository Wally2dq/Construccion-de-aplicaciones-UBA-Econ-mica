using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaIndumentaria
{
    public sealed class Camisa : Indumentaria
    {
        private bool _tieneEstampado;
        private string _tipoManga;

        protected override string GetDetalle()
        {
            throw new NotImplementedException();
        }
        protected override string ToString() 
        {
            return GetDetalle();
        }
    }
}
