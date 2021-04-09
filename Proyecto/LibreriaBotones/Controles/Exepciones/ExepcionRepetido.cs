using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaBotones.Controles.Exepciones
{
    public class RepetidoExepcion : Exception
    {
        List<int> _Botones;

        private void BusquedaRepetido(int Entrada)
        {
            foreach (int i in _Botones)
            {
                if (i == Entrada)
                {
                    throw new RepetidoExepcion(); 
                }
            }
        }


    }
}
