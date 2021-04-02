using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibreriaBotones;

namespace ProyectoBotones
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = false;
            int Seleccion;

            Controles C = new Controles();

            do
            {
                Console.WriteLine("Seleccione una opcion" +
                    "\n1 - Mostrar Botones" +
                    "\n2 - Agregar Boton" +
                    "\n3 - Eliminar Boton" +
                    "\n4 - Mostrar Descripcion" +
                    "\n5 - Salir");

                Console.WriteLine("\nIngrese su Opcion");
                Seleccion = Convert.ToInt32(Console.ReadLine()); //Hacer un metodo para validarlo

                switch (Seleccion)
                {
                    case 1:
                        {

                        }
                }

            } while (flag != true);
        }
    }
}
