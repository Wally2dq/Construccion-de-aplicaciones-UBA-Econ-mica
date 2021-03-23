using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Libreria.Entidades.Veterinaria.Animales;
using Libreria.Entidades.Deportista;


namespace Sistemas.Proyecto
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal Ani = new Animal();

            Ani.EdadAnimal = "40";

            Console.WriteLine(Ani.EdadAnimal);

            Deportista D = new Deportista();

            D.TipoDeporteDeportista = "Taekwondo";
            D.ActividadDeportista = "true";

            Console.WriteLine(D.TipoDeporteDeportista);
            Console.WriteLine(D.ActividadDeportista);

            Console.ReadKey();

            

        }
    }
}
