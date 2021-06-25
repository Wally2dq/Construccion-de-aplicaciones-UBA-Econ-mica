using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDeEntidades.Entidades.Exepction;

namespace CapaDeNegocio.Validaciones
{
    public class Validar
    {
        public double ValidarNumeroDouble(string entrada)
        {
            double salida;

            if (!double.TryParse(entrada, out salida))
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

        public int ValidarNumeroEntero(string entrada)
        {
            int salida;

            if (!int.TryParse(entrada, out salida))
            {

                throw new ValidarNumeroException("Ingrese Numeros enteros");

            }

            return salida;
        }
        public DateTime ValidarFecha(string entrada)
        {
            DateTime salida;

            if (!DateTime.TryParse(entrada, out salida))
            {

                throw new ValidarFechaException("Ingrese una fecha valida");

            }
            else if (salida > DateTime.Now) 
            {
                throw new ValidarFechaException("Ingrese una fecha valida");
            }

            return salida;
        }
    }
}
