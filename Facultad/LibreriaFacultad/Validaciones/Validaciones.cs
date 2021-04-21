using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaFacultad
{
    public class ValidacionesClase
    {
        public int NumeroNegativo(int Numero)
        {
            if (Numero < 0)
                throw new NegativoExpecion("No Ingrese valores Negativos");
            return Numero;
        }
        public void ValidarNumeroEntero(ref int Numero)
        {
            bool flag = false;

            do
            {
                try
                {
                    Numero = Convert.ToInt32(Console.ReadLine()); ;
                    flag = true;

                    NumeroNegativo(Numero); 
                }
                catch (FormatException ForEx)
                {
                    Console.WriteLine(ForEx.Message + "\nIngrese su valor nuevamente");
                    flag = false;
                }
                catch (NullReferenceException Nu)
                {
                    Console.WriteLine(Nu.Message + "\nIngrese su valor nuevamente");
                    flag = false;
                }
                catch (NegativoExpecion NeEx)
                {
                    Console.WriteLine(NeEx.Message + "\nIngrese su valor nuevamente");
                    flag = false;
                }
                catch (Exception Ex)
                {

                    Console.WriteLine(Ex.Message + "\nIngrese su valor nuevamente");
                    flag = false;
                }



            } while (flag != true);

        }

        public double NumeroNegativodouble(double Numero)
        {
            if (Numero < 0)
                throw new NegativoExpecion("No Ingrese valores Negativos");
            return Numero;
        }
        public void ValidarDouble(ref double Numero)
        {
            bool flag = false;

            do
            {
                try
                {
                    Numero = Convert.ToDouble(Console.ReadLine()); ;
                    flag = true;

                    NumeroNegativodouble(Numero); ///Tengo que poner esto para que pueda leer el numero y luego ejecuta la exepcion
                }
                catch (FormatException ForEx)
                {
                    Console.WriteLine(ForEx.Message + "\nIngrese su valor nuevamente");
                    flag = false;
                }
                catch (NullReferenceException Nu)
                {
                    Console.WriteLine(Nu.Message + "\nIngrese su valor nuevamente");
                    flag = false;
                }
                catch (NegativoExpecion NeEx)
                {
                    Console.WriteLine(NeEx.Message + "\nIngrese su valor nuevamente");
                    flag = false;
                }
                catch (Exception Ex)
                {

                    Console.WriteLine(Ex.Message + "\nIngrese su valor nuevamente");
                    flag = false;
                }



            } while (flag != true);

        }

        public void ValidarString(ref string Ingreso)
        {
            bool flag = false;

            do
            {
                try
                {
                    Ingreso = Console.ReadLine();
                    flag = true;
                }
                catch (FormatException ForEx)
                {
                    Console.WriteLine(ForEx.Message + "\nIngrese su valor nuevamente");
                    flag = false;
                }
                catch (NullReferenceException Nu)
                {
                    Console.WriteLine(Nu.Message + "\nIngrese su valor nuevamente");
                    flag = false;
                }
                catch (Exception Ex)
                {

                    Console.WriteLine(Ex.Message + "\nIngrese su valor nuevamente");
                    flag = false;
                }



            } while (flag != true);

        }

    }
}
