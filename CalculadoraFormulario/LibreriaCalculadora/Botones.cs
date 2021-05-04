using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaCalculadora
{
    public class Botones
    {
        private double valor1;
        private double valor2;


        public Botones(double Ingreso1, double Ingreso2) 
        {
            valor1 = Ingreso1;
            valor2 = Ingreso2;
        }

        public double Suma() 
        {
            double Resultado;
            Resultado = valor1 + valor2;

            return Resultado;
        }

        public double Resta()
        {
            double Resultado;
            Resultado = valor1 - valor2;

            return Resultado;
        }

        public double Multiplicacion()
        {
            double Resultado;
            Resultado = valor1 * valor2;

            return Resultado;
        }

        public double Division() 
        {
            double Resultado = -1;

            if (valor2 == 0)
            {
                throw new NoDividirPorCeroException("No se puede dividir por 0");
            }
            else 
            {
                Resultado = valor1 / valor2;
            }

            return Resultado;
        }

    }
}
