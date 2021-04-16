using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Class.Expendedora;
using Class.Validacion;
using Class.Exepciones;

namespace ProyectoDeMaquina
{
    class Program
    {
        static private Expendedora expen ;
        static private Validaciones validaciones = new Validaciones();
        static void Main(string[] args)
        {
            IngresoDatosExpendedora();
            EjecuctarOpciones();
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

        static void IngresoDatosExpendedora() 
        {
            string Proveedor="";
            int Cantidad =-1;

            Console.WriteLine("Ingrese Proveedor");
            validaciones.ValidarString(ref Proveedor);
            Console.WriteLine("Ingrese la cantidad maxima");
            validaciones.ValidarNumeroEntero(ref Cantidad);

            new Expendedora(Proveedor,Cantidad);
;        }

        static void EjecuctarOpciones() 
        {
            int Opciones=-1;
            bool flag = false;

            do
            {

                Menu();
                Console.WriteLine("Ingrese su Opcion");
                validaciones.ValidarNumeroEntero(ref Opciones);

                switch (Opciones)
                {
                    case 0:
                        expen.EncenderMaquina();
                        break;
                    case 1:
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    case 6:
                        flag = true;
                        break;
                    default:
                        Console.WriteLine("Ingrese una opcion entre 0 a 5");
                        break;
                }

            } while (flag!=true);
        }
        static void IngresarLata(Expendedora Ex) { }

        static void ExtraerLata(Expendedora Ex) { }

        static void ObtenerBalance(Expendedora Ex) { }

        static void MostrarStock(Expendedora Ex) { }

    }
}
