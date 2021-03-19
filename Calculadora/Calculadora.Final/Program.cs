using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryCalculadora;

namespace Calculadora.Final
{
    class Program
    {
        static void Main(string[] args)
        {
            string Entrada1 = "";
            string Entrada2 = "";
            int Valor1 = 0;
            int Valor2 = 0;
            //bool Validacion1 = true;
            //bool Validacion2 = true;
            string Salida = "x" ;

            Class1 F = new Class1();

            do {
                Console.WriteLine("Ingrese 2 Numeros");

                F.ValidaNumero(Entrada1,ref Valor1);

                F.ValidaNumero(Entrada2, ref Valor2);

                Console.WriteLine("Valores "+Valor1+" "+Valor2);


            } while ((Salida != "X") || (Salida !="x") );
        }
    }
}
