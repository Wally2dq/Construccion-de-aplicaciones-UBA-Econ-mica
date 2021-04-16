﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaExpendedora.Validaciones
{
    public class Validaciones
    {
        public void ValidarNumeroEntero(ref int Numero)
        {
            bool flag = false;

            do
            {
                try
                {
                    Numero = Convert.ToInt32(Console.ReadLine()); ;
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

        public void ValidarString(ref string Ingreso)
        {
            bool flag = false;
            string validar;

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