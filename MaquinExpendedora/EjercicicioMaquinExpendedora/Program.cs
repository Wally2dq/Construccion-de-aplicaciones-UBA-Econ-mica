using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibreriaExpendedora.Expendedor;
using LibreriaExpendedora.Validaciones;
using LibreriaExpendedora.Expendedor.ClaseLata;

namespace EjercicicioMaquinExpendedora
{
    class Program
    {
        static public ValidacionesClase validaciones;

        static Program( )
        {
            validaciones = new ValidacionesClase();
        }

        static void Main(string[] args)
        {

            EjecuctarOpciones();

            Console.ReadKey();
        }

        static string Menu()
        {
            return "\n 0 Encender Maquina" +
                "\n 1 Latas Disponibles" +
                "\n 2 Insertar Lata" +
                "\n 3 Extraer Lata" +
                "\n 4 Balance" +
                "\n 5 Descripcion y Stock de Latas" +
                "\n 6 Salir";
        }

        static void IngresoDatosExpendedora(ref string IngresoProveedor,ref int CantidadIngreso)
        {
            Console.WriteLine("Ingrese Proveedor");
            validaciones.ValidarString(ref IngresoProveedor);
            Console.WriteLine("Ingrese la cantidad maxima");
            validaciones.ValidarNumeroEntero(ref CantidadIngreso);


        }

        static void EjecuctarOpciones()
        {
            int Opciones = -1;
            bool flag = false;

            string Proveedor = null;
            int Cantidad = -1;

            IngresoDatosExpendedora(ref Proveedor, ref Cantidad);

            Expendedora expen = new Expendedora(Proveedor, Cantidad);

            

            do
            {

                Console.WriteLine(Menu());
                Console.WriteLine("Ingrese su Opcion");
                validaciones.ValidarNumeroEntero(ref Opciones);

                switch (Opciones)
                {
                    case 0:
                        expen.EncenderMaquina();
                        Console.WriteLine("Maquina Encendida");
                        break;
                    case 1:
                        MostrarStock(expen); //Mando el bool para saber si esta encendido la maquina
                        break;
                    case 2:
                        IngresarLata(expen);
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    case 6:
                        flag = true;
                        Console.WriteLine("Hasta Pronto ...");
                        break;
                    default:
                        Console.WriteLine("Ingrese una opcion entre 0 a 6");
                        break;
                }

            } while (flag != true);
        }
        static void IngresarLata(object B)
        {
            Expendedora ingreso = (Expendedora) B;

            bool flag = true;

            flag = validaciones.ValidarEncenderMaquina(ingreso.Encendido);

            if (flag == true) 
            {
                flag = validaciones.ControlDeCapacidad(ingreso.Latas.Count(), ingreso.Capacidad);

                if (flag==true)
                ingreso.AgregarLata();
            }

        }

        static void ExtraerLata(Expendedora Ex) { }

        static void ObtenerBalance(Expendedora Ex) { }

        static void MostrarStock(object B) 
        {
            Expendedora MostrarStockExpendedora = (Expendedora) B;

            bool flag = true;
            List<string> Listar;

            flag = validaciones.ValidarEncenderMaquina(MostrarStockExpendedora.Encendido);

            if (flag == true) 
            {
                validaciones.ValidarLista(MostrarStockExpendedora.MostrarLista());
                Listar = MostrarStockExpendedora.MostrarLista();

                if (Listar.Count()>0) 
                {
                    Console.WriteLine("LISTADO = ");
                    foreach (string Item in Listar)
                    {
                        Console.WriteLine(" " + Item);  //Para mostrar la lista, uno por uno
                    }
                }
               
            }
            

        }

    }
}
