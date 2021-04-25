using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryVentaRespuesto;

namespace ProyectoVentaRespuesto
{
    class Program
    {
        private static ValidacionesClase validar = new ValidacionesClase();
        static void Main(string[] args)
        {
            EjecutarOperaciones();
        }

        static string Menu() 
        {
            return "Menu" +
                "\n 1 Agregar Respuesto" +
                "\n 2 Quitar Respuesto" +
                "\n 3 Modificar Precio" +
                "\n 4 Agregar Stock" +
                "\n 4 Quitar Stock" +
                "\n 5 Traer Por Categoria" +
                "\n 6 SALIR";

        }

        static void EjecutarOperaciones()
        {
            string Nombre = "";
            string Direccion = "";
            bool flag = true;
            int Opciones = -1;

            Console.WriteLine("Bienvenido" +
                "\n Ingrese Nombre del Comercio");
            Nombre = validar.ValidarString();

            Console.WriteLine("Ingrese la Direccion del Comercio");
            Direccion = validar.ValidarString();

            CotrolesVentaRes res = new CotrolesVentaRes(Nombre, Direccion);

            do
            {
                Console.WriteLine(Menu());
                Opciones = validar.ValidarNumeroEntero();

                switch (Opciones) 
                {
                    case 1:
                        AgregarRespuesto(res);
                        break;
                    case 2:
                        QuitarRespuestoMenu(res);
                        break;
                    case 3:
                        ModificarPrecioMemu(res);
                        break
                    case 6:
                        flag = false;
                        Console.WriteLine("Hasta Pronto");
                        break;
                    default:
                        Console.WriteLine("Ingrese una opcion Valida") ;
                        break;
                }

            } while (flag == true);
        }

        static void AgregarRespuesto(CotrolesVentaRes Obj) 
        {
            CotrolesVentaRes res = (CotrolesVentaRes)Obj;
            

            int CodigoCat;
            string NombreCaT;
            int CodigoRes;
            string NombreRes;
            double Precio;
            int stock;

            Console.WriteLine("Ingrese Codigo de Categoria del Respuesto");
            CodigoCat = validar.ValidarNumeroEntero();

            Console.WriteLine("Ingrese Nomre de Categoria del Respuesto");
            NombreCaT = validar.ValidarString();

            Console.WriteLine("Ingrese Codigo del Respuesto");
            CodigoRes = validar.ValidarNumeroEntero();

            Console.WriteLine("Ingrese Nombre del Respuesto");
            NombreRes = validar.ValidarString();

            Console.WriteLine("Ingrese Precio");
            Precio = validar.ValidarDouble();

            Console.WriteLine("Stock");
            stock = validar.ValidarNumeroEntero();


            try
            {
                Respuesto Ingreso = new Respuesto(CodigoCat, NombreCaT, CodigoRes, NombreRes, Precio, stock);
                res.AgregarRespuesto(Ingreso);
                Console.WriteLine("Cargado");
            }
            catch (CodigoYaRegistradoExepcion cyex)
            {
                Console.WriteLine(cyex.Message);
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void QuitarRespuestoMenu(CotrolesVentaRes Obj) 
        {
            CotrolesVentaRes res = (CotrolesVentaRes)Obj;

            int Codigo;

            Console.WriteLine("Ingrese el codigo a elimiar");
            Codigo = validar.ValidarNumeroEntero();

            try
            {
                res.QuitarRespuesto(Codigo);
                Console.WriteLine("Eliminado");
            }
            catch (CodigoInexistenteExepcion ciex)
            {
                Console.WriteLine(ciex);
            }
            catch (RespuestoStockExpecion rse) 
            {
                Console.WriteLine(rse.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void ModificarPrecioMemu(CotrolesVentaRes obj) 
        {
            CotrolesVentaRes res = (CotrolesVentaRes)obj;

            int Codigo;
            double Precio;

            Console.WriteLine("Ingrese el codigo del respuesto");
            Codigo = validar.ValidarNumeroEntero();

            Console.WriteLine("Precio nuevo");
            Precio = validar.ValidarDouble();

            try
            {
                res.ModiicarPrecio(Codigo, Precio);
                Console.WriteLine("Precio Modificado");
            }
            catch (CodigoInexistenteExepcion ciex)
            {
                Console.WriteLine(ciex.Message);
            }
            catch (Exception Ex) 
            {
                Console.WriteLine(Ex.Message);
            }

        }
    }
}
