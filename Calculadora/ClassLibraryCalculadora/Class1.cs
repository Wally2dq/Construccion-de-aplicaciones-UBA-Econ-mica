using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryCalculadora
{
    public class Class1
    {
        

        public void ValidaNumero(string EntradaValidacion, ref int NumeroEntradaValidacion)
        {
            bool bandera = false;

            do
            {
                Console.WriteLine("Ingrese valor");
                EntradaValidacion = Console.ReadLine();

                if (!int.TryParse(EntradaValidacion, out NumeroEntradaValidacion))
                {

                    Console.WriteLine("Error: Ingrese un valor numerico");

                }
                else
                {
                    bandera = true;
                }

            } while (bandera == false);
        }

        public void Operaciones(int Valor1Operacion, int Valor2Operacion) {
            string EntradaOperacion="";
            int Operacion = 0 ;
            int Resultado=0;
            double Division = 0;

            bool flag = true;

            do
            {
                Console.WriteLine("Selecione una operacion" +
                    "\n1- Suma" +
                    "\n2- Resta" +
                    "\n3- Multiplicacion" +
                    "\n4- Division");

                ValidaNumero(EntradaOperacion, ref Operacion);

                switch (Operacion)
                {
                    case 1:
                        Console.WriteLine("Selecciono Suma");
                        Resultado = Valor1Operacion + Valor1Operacion;
                        break;
                    case 2:
                        Console.WriteLine("Selecciono Resta");
                        Resultado = Valor1Operacion - Valor1Operacion;
                        break;
                    case 3:
                        Console.WriteLine("Selecciono Multiplicacion");
                        Resultado = Valor1Operacion * Valor1Operacion;
                        break;
                    case 4:
                        Console.WriteLine("Selecciono Division");
                        Division = Valor1Operacion / Valor1Operacion;
                        break;
                    default:
                        flag = false;
                        Console.WriteLine("Por favor, Seleccione una operacion real");
                        break;

                }
            } while (flag== false);

            if (Operacion == 4)
            {
                Console.WriteLine("Su resultado es "+Division);
            }
            else 
            {
                Console.WriteLine("Su resultado es "+Resultado);
            }
        }

        public void ValidarSalida(ref string ValSalida) {
            // Falta realizar la validacion, al ingresar Salida, en minuscula, hacer todo en mayuscula
        }


    }
}
