using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryCalculadora
{
    public class Class1
    {
        

        public void ValidaNumero(string Entrada, ref int NumeroEntrada)
        {
            bool bandera = false;

            do
            {
                Console.WriteLine("Ingrese valor");
                Entrada = Console.ReadLine();

                if (!int.TryParse(Entrada, out NumeroEntrada))
                {

                    Console.WriteLine("Error: Ingrese un valor numerico");

                }
                else
                {
                    bandera = true;
                }

            } while (bandera == false);
        }
    }
}
