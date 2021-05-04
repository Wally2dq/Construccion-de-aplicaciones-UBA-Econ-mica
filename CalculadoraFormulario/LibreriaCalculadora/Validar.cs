using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaCalculadora
{
    public class Validar
    {
        public double ValidarNumero(string entrada) 
        {
            double salida;

            if (!double.TryParse(entrada, out salida))//Cuando no se puede transformar el numero, salta este cartel
            {

                throw new ValidarNumeroException("Ingrese Numeros");

            }

            return salida;
        }
    }
}
