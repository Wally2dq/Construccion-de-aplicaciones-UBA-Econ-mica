using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibreriaFacultad;

namespace ProyectoFacultad
{
    class Program
    {
        static private ControlesFacultad facu;
        static private ValidacionesClase validaciones;
        Program() 
        {
            facu = new ControlesFacultad();
            validaciones = new ValidacionesClase();
        }
        static void Main(string[] args)
        {
        }

        static void CargarAlumno() 
        {
            int Codigo ;
            string Nombre;
            string Apellido;

            

            Console.WriteLine("Ingrese" +
                "\nEl codigo del alumno");
            Codigo = validaciones.ValidarNumeroEntero();

            Console.WriteLine("El nombre del alumno");
            Nombre = validaciones.ValidarString();

            Console.WriteLine("El apellido del alumno");
            Apellido= validaciones.ValidarString();

            facu.AgregarAlumno(Codigo,Nombre,Apellido);
        }
    }
}
