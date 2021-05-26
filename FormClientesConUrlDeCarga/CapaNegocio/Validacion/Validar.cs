using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaNegocio.Exceptions;

namespace CapaNegocio.Validacion
{
    public class Validar
    {
        public int ValidarNumero(string entrada)
        {
            int salida;

            if (!int.TryParse(entrada, out salida))//Cuando no se puede transformar el numero, salta este cartel
            {

                throw new ValidarNumeroException("Ingrese Numeros");

            }

            return salida;
        }

        public string ValidarString(string entrada)
        {

            if (string.IsNullOrEmpty(entrada)) //Valida que no sea Nulo
            {
                throw new ValidarStringException(" No deje espacios vacios");
            }

            return entrada;
        }

    }
}
