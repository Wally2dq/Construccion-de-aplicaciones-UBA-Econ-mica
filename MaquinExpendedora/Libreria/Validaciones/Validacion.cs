using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibreriaExpendedora.Exepciones;

namespace LibreriaExpendedora.Validaciones
{
    public class ValidacionesClase
    {
        public int NumeroNegativo(int Numero)
        {
            if (Numero < 0)
                throw new SinStockExepcion("No Ingrese valores Negativos");
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

                    NumeroNegativo(Numero); ///Tengo que poner esto para que pueda leer el numero y luego ejecuta la exepcion

                    //INGRESAR VALORES MAYOR A 0
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

        }

        public double NumeroNegativodouble(double Numero)
        {
            if (Numero < 0)
                throw new SinStockExepcion("No Ingrese valores Negativos");
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

        public List<string> ValidarLista(List<string>_lista) 
        {

            try
            {
                if (_lista.Count == 0)
                {
                    throw new SinStockExepcion("No hay Stock");
                }
            }
            catch (SinStockExepcion SinSEx)
            {
                Console.WriteLine(SinSEx.Message);
            }
            catch (Exception Ex) 
            {
                Console.WriteLine(Ex.Message);
            }

            return _lista;
            
        }

        public bool ValidarEncenderMaquina(bool EncenderMaquina) 
        {
            bool flag = false;
            try
            {
                if (EncenderMaquina == false)
                    throw new ExpendedoraApagadaExepcion("Debe encender la Expendedora");
                flag = true;
            }
            catch (ExpendedoraApagadaExepcion ExApa)
            {
                Console.WriteLine(ExApa.Message);
                flag = false;
            }
            catch (Exception Ex) 
            {
                Console.WriteLine(Ex.Message);
                flag = false;
            }

            return flag;
        }
        public bool ControlDeCapacidad(/*List<object> lista*/int Cantidad, int Limite)
        {
            bool flag = false;
            try
            {
                if (Cantidad > Limite)
                {
                    flag = false;
                    throw new CapacidadInsuficienteExepcion("Capacidad de la maquina llena");
                }
                else 
                {
                    flag = true;
                }
            }
            catch (CapacidadInsuficienteExepcion Cap)
            {
                Console.WriteLine(Cap.Message);
                flag = false;
            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.Message);
                flag = false;
            }

            return flag;
        }

    }
}
