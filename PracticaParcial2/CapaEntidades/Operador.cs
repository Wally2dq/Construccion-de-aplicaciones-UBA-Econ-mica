using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Operador
    {
       /* + Prestamos: List&lt;Prestamo&gt;
        + Comision: double
        + PorcentajeComision: double*/

        private double _comision;
        private double _porcentajeComision = 0.15;

        public double Comision { get => _comision; }
        public double PorcentajeComision { get => _porcentajeComision; }

        public Operador(double Comision) 
        {
            _comision = Comision;
        }

        public double MostrarComision() 
        {
            return Comision * PorcentajeComision;
        }

    }
}
