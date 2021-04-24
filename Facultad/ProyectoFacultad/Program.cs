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
            facu = new ControlesFacultad(5,"Universidad de Buenos Aires");
            validaciones = new ValidacionesClase();
        }
        static void Main(string[] args)
        {
            //https://github.com/Juliparodi/Facultad

        }

        static void CargarAlumno()
        {
            int Codigo;
            string Nombre;
            string Apellido;

            bool flag = true;



            Console.WriteLine("Ingrese" +
                "\nEl codigo del alumno");
            Codigo = validaciones.ValidarNumeroEntero();

            Console.WriteLine("El nombre del alumno");
            Nombre = validaciones.ValidarString();

            Console.WriteLine("El apellido del alumno");
            Apellido = validaciones.ValidarString();

            try
            {
                facu.AgregarAlumno(Codigo, Nombre, Apellido);
            }
            catch (AlumnoExistenteException alu)
            {
                Console.WriteLine(alu.Message);
                flag = false;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                flag = false;
            }

            if (flag == true)
                facu.OperacionExistosa();

        }
        static void EliminarAlumno()
        {
            bool flag = false;
            int Codigo;

            Console.WriteLine("Ingrese el codigo del alumno a eliminar");
            Codigo = validaciones.ValidarNumeroEntero();

            try
            {
                facu.EliminarAlumno(Codigo);
            }
            catch (AlumnoInexistenteExepcion inex)
            {
                Console.WriteLine(inex.Message);
                flag = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                flag = true;
            }

            if (flag == false)
                facu.OperacionExistosa();
        }
        static void MostrarAlumnoEspecifico()
        {
            int Codigo;
            List<string> _alumnoMostrar = new List<string>();

            Console.WriteLine("Ingrese el codigo del alumno");
            Codigo = validaciones.ValidarNumeroEntero();

            try
            {
                _alumnoMostrar = facu.TraerAlumno(Codigo);
                if (_alumnoMostrar.Count == 0)
                    throw new AlumnoInexistenteExepcion("No se encontro el alumno");
                else
                {
                    Console.WriteLine(_alumnoMostrar);
                }
            }
            catch (AlumnoExistenteException alu)
            {
                Console.WriteLine(alu.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        static void MostrarTodosLosAlumnos() 
        {
            List<string> _mostrar = new List<string>();

            try
            {
                _mostrar = facu.TraerAlumno();
                if (_mostrar.Count == 0)
                    throw new AlumnoInexistenteExepcion("No se encontro el alumno");
                else
                {
                    Console.WriteLine(_mostrar);
                }
            }
            catch (AlumnoExistenteException alu)
            {
                Console.WriteLine(alu.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
