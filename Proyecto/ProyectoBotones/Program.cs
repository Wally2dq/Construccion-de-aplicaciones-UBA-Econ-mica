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
            int Seleccion=0;

            Controles C = new Controles();

            //Console.WriteLine(B.MostrarBoton());

            //Console.ReadKey();
            Botones B = new Botones();
            
            do
            {
                Console.WriteLine("Seleccione una opcion" +
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
                        Console.WriteLine("Caso 1 Listar Botones");
                        Console.WriteLine(B.MostrarBoton());
                        break;

                    case 2:
                        Console.WriteLine("Caso 2 Agregar Boton");
                        C.AgregarBotonEnLista();
                        break;
                    case 3:
                        Console.WriteLine("Caso 3 Eliminar Boton");
                        break;
                    case 4:
                        Console.WriteLine("Caso 4 Mostrar Descripcion");
                        break;
                    case 5:
                        Console.WriteLine("Caso 5 Salir");
                        flag = true;
                        break;
                    default:
                        Console.WriteLine("Ingrese un valor del 1 a 5");
                        break;
                }

            } while (flag != true);

            Console.WriteLine("\nGracias por utilizar nuestros servicios\n");
            Console.ReadKey();
        }
    }
}
