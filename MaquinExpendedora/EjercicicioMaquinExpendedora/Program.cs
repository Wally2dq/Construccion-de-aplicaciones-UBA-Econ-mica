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
            string Proveedor = "";
            int Cantidad = -1;

            Console.WriteLine("Ingrese Proveedor");
            validaciones.ValidarString(ref Proveedor);
            Console.WriteLine("Ingrese la cantidad maxima");
            validaciones.ValidarNumeroEntero(ref Cantidad);


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
                        MostrarStock(expen.Encendido); //Mando el bool para saber si esta encendido la maquina
                        break;
                    case 2:
                        IngresarLata(expen.Encendido);
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
        static void IngresarLata(bool Encendido)
        {
            Expendedora IngresarStockExpendedora = new Expendedora();

            bool flag = true;

            flag = validaciones.ValidarEncenderMaquina(Encendido);

            if (flag == true) 
            {
                IngresarStockExpendedora.ControlDeCapacidadYAgregarLata();

                //Me salta el error de que no esta instanciada la clase
            }

        }

        static void ExtraerLata(Expendedora Ex) { }

        static void ObtenerBalance(Expendedora Ex) { }

        static void MostrarStock(bool Encendido) 
        {
            Expendedora MostrarStockExpendedora = new Expendedora();

            bool flag = true;

            flag = validaciones.ValidarEncenderMaquina(Encendido);

            if (flag==true)
            validaciones.ValidarLista(MostrarStockExpendedora.MostrarLista());
        }

    }
}
