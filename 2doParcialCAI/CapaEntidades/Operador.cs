using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Operador
    {
        List<PlazoFijo> _listaPlazos;

        public Operador(List<PlazoFijo> listaPlazo) 
        {
            _listaPlazos = listaPlazo;
        }

        public double MontoTotal() 
        {
            double suma = 0;
            foreach (PlazoFijo p in _listaPlazos) 
            {
                suma += p.CapitalInicial;
            }
            return suma;
        }

        public double Comision() 
        {
            double fijo = 15;
            double resultado = 0;

            foreach(PlazoFijo p in _listaPlazos)
            {
                resultado += (fijo) + (p.Interes * 0.01);
            }
            

            return resultado;

        }
    }
}
