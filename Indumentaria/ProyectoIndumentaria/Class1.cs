using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibreriaIndumentaria;

namespace ProyectoIndumentaria
{
    public class ValidacionesClase
    {
        private int NumeroNegativo(int Numero)
        {
            if (Numero < 0)
                throw new NegativoExepcion("No Ingrese valores Negativos");
            return Numero;
        }
        public int ValidarNumeroEntero()
        {
            int Numero = 0;
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
                catch (NegativoExepcion NeEx)
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

            return Numero;
        }

        private double NumeroNegativodouble(double Numero)
        {
            if (Numero < 0)
                throw new NegativoExepcion("No Ingrese valores Negativos");
            return Numero;
        }
        public double ValidarDouble()
        {
            double Numero = 0;
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
                catch (NegativoExepcion NeEx)
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

            return Numero;

        }

        public string ValidarString()
        {
            string Ingreso = "";
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

            return Ingreso;

        }
        public DateTime ValidarFecha(DateTime Ingreso)
        {
            //DateTime Ingreso;
            bool flag = false;

            do
            {
                try
                {
                    Ingreso = Convert.ToDateTime(Console.ReadLine());
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

            return Ingreso;

        }

    }
}
