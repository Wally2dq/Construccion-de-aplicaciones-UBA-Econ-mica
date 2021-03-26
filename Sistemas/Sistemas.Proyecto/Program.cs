using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Libreria.Entidades.Veterinaria.Animales;
using Libreria.Entidades.Deportista;
using Libreria.Entidades.Veterinaria;


namespace Sistemas.Proyecto
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal Ani = new Animal();

            Ani.EdadAnimal = "40";

            Console.WriteLine(Ani.EdadAnimal);


            Console.WriteLine("\n Prueba de Veterinaria, y usar los datos de la clase Animal\n");

            Veterinaria Vet = new Veterinaria();

            Vet.SetAnimales("Perro", "Caniche", "2", "Masculino");

            Console.WriteLine(Vet.MostrarAnimales);

            Console.WriteLine("\n Prueba de carga y muestra de datos del Deportista\n");

            Deportista D = new Deportista();

            D.TipoDeporteDeportista = "Taekwondo";
            D.ActividadDeportista = "true";

            Console.WriteLine(D.TipoDeporteDeportista);
            Console.WriteLine(D.ActividadDeportista);

            Console.ReadKey();

            

        }
    }
}
