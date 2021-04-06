using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibreriaBotones;
using LibreriaBotones.Controles;
using LibreriaBotones.Controles.Boton;

namespace ProyectoBotones
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = false;
            bool flagIngreso =false;
            int Seleccion=-1;

            Controles C = new Controles();

            //Console.WriteLine(B.MostrarBoton());

            //Console.ReadKey();
            Botones B = new Botones();
            
            do
            {
                Console.WriteLine("\nSeleccione una opcion" +
                    "\n1 - Mostrar Botones" +
                    "\n2 - Agregar Boton" +
                    "\n3 - Eliminar Boton" +
                    "\n4 - Mostrar Descripcion" +
                    "\n5 - Salir");

                do
                {
                    try
                    {
                        Console.WriteLine("\nIngrese su Opcion");
                        Seleccion = Convert.ToInt32(Console.ReadLine());
                        flagIngreso = false;
                    }
                    catch (FormatException FoEx)
                    {
                        Console.WriteLine("Ingrese un numero por favor "+FoEx.Message);
                        flagIngreso = true;
                    }
                    catch (Exception Exe) 
                    {
                        Console.WriteLine("Ocurrio un error "+Exe.Message);
                    }
                } while (flagIngreso!=false);
               
                switch (Seleccion)
                {
                    case 1:
                        Console.WriteLine("Lista Botones");
                        C.MostrarBotonesControlador();
                        break;

                    case 2:
                        Console.WriteLine("Agregar Boton");
                        C.AgregarBotonEnLista();
                        break;
                    case 3:
                        Console.WriteLine("Eliminar Boton");
                        C.BorrarBotonesControlador();

                        //ERROR, NO ME SACA EL DATO DE LA LISTA AL MOSTRAR NUEVAMENTE LUEGO DE EJECUTAR ESTO


                        break;
                    case 4:
                        Console.WriteLine("Mostrar Descripcion");
                        C.MostrarDescripcionBotonesControlador();
                        break;
                    case 5:
                        Console.WriteLine("Salir");
                        flag = true;
                        break;
                    default:
                        Console.WriteLine("\nIngrese un valor del 1 a 5\n");
                        break;
                }

            } while (flag != true);

            Console.WriteLine("\nGracias por utilizar nuestros servicios\n");
            Console.ReadKey();
        }
    }
}
