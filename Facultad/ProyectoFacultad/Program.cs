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
                Alumno cargarAlumno = new Alumno(Codigo, Nombre, Apellido);

                facu.AgregarAlumno(cargarAlumno);
                flag = true;
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

            Console.WriteLine("Ingrese el codigo del alumno");
            Codigo = validaciones.ValidarNumeroEntero();

            try
            {
                Alumno mostar = facu.TraerAlumnoCodigo(Codigo);
                Console.WriteLine(mostar.ToString());
            }
            catch (AlumnoInexistenteExepcion alu)
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
            

            try
            {
                List < Alumno > _aluList = facu.TraerAlumno();

                foreach (Alumno i in _aluList) 
                {
                    Console.WriteLine(i.ToString());
                }
            }
            catch (ListaSinDatosExpecion alu)
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
