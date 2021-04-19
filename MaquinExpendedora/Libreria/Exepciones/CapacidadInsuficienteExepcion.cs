using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaExpendedora.Exepciones
{
    public class CapacidadInsuficienteExepcion : Exception
    {
        public CapacidadInsuficienteExepcion(string msg) : base(msg) 
        {
            //Debo crear un constructur, tiene 1 parametro, pero nada mas
        }
    }
}
