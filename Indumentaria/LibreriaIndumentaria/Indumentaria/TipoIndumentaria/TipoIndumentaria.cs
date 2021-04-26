using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaIndumentaria
{
    public abstract class TipoIndumentaria
    {
        protected string _origen;
        protected double _porcentajeAlgodon;

        public string Origen { get => _origen; }
        public double PorcentajeAlgodon { get => _porcentajeAlgodon; }

        public TipoIndumentaria(string Origen, double algodon)
        {
            _origen = Origen;
            _porcentajeAlgodon = algodon;
        }
        public TipoIndumentaria() { }
    }
}
