using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Libreria;
using Libreria.Entidades.Veterinaria.Animales;

namespace Sistemas.Proyecto
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal Ani = new Animal();

            Ani.EdadAnimal = "40";

            Console.WriteLine(Ani.EdadAnimal);

            Console.ReadKey();



        }
    }
}
