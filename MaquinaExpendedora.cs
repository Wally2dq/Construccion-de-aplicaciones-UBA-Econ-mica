using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Class.Expendedora;
using Class.Validacion;

namespace ProyectoDeMaquina
{
    class Program
    {
        static private Expendedora expen = new Expendedora();
        static private Validaciones validaciones = new Validaciones();
        static void Main(string[] args)
        {
            
        }

        static string Menu() 
        {
            return "Bienvenido sus Opciones son" +
                "\n 0 Encender Maquina" +
                "\n 1 Latas Disponibles" +
                "\n 2 Insertar Lata" +
                "\n 3 Extraer Lata" +
                "\n 4 Balance" +
                "\n 5 Descripcion y Stock de Latas";
        }

        static void EjecuctarOpciones() 
        {
            string Ingreso;
            int Opciones=-1;

            Menu();
            Ingreso = Console.ReadLine();

            validaciones.ValidarNumero(Ingreso,Opciones);

            //switch (Opciones)
        }
        static void IngresarLata(Expendedora Ex) { }

        static void ExtraerLata(Expendedora Ex) { }

        static void ObtenerBalance(Expendedora Ex) { }

        static void MostrarStock(Expendedora Ex) { }

    }
}
