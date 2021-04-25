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
                "\n 5 Quitar Stock" +
                "\n 6 Traer Por Categoria" +
                "\n 7 Mostrar Todo" +
                "\n 8 Salir ";

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
                        break;
                    case 4:
                        AgregarStockMenu(res);
                        break;
                    case 5:
                        EliminarStockMenu(res);
                        break;
                    case 6:
                        MostrarlistaMenu(res);
                        break;
                    case 7:
                        MostrarTod(res);
                        break;
                    case 8:
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

        static void AgregarStockMenu(CotrolesVentaRes obj) 
        {
            CotrolesVentaRes res = (CotrolesVentaRes)obj;

            int Codigo;
            int Stock;

            Console.WriteLine("Ingrese el codigo del respuesto");
            Codigo = validar.ValidarNumeroEntero();

            Console.WriteLine("Ingrese el stock a sumar");
            Stock = validar.ValidarNumeroEntero();

            try
            {
                res.AgregarStock(Codigo, Stock);
                Console.WriteLine("Stock Agregado");
            }
            catch (CodigoInexistenteExepcion ciex)
            {
                Console.WriteLine(ciex.Message);
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void EliminarStockMenu(CotrolesVentaRes obj)
        {
            CotrolesVentaRes res = (CotrolesVentaRes)obj;

            int Codigo;
            int Stock;

            Console.WriteLine("Ingrese el codigo del respuesto");
            Codigo = validar.ValidarNumeroEntero();

            Console.WriteLine("Ingrese el stock a eliminar");
            Stock = validar.ValidarNumeroEntero();

            try
            {
                res.QuitarStock(Codigo, Stock);
                Console.WriteLine("Stock Quitado");
            }
            catch (CodigoInexistenteExepcion ciex)
            {
                Console.WriteLine(ciex.Message);
            }
            catch (FaltaStock fex) 
            {
                Console.WriteLine(fex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void MostrarlistaMenu(CotrolesVentaRes obj) 
        {
            CotrolesVentaRes res = (CotrolesVentaRes)obj;

            int codigo;

            Console.WriteLine("Ingrese el codigo de Categoria");
            codigo = validar.ValidarNumeroEntero();

            try
            {
                List<Respuesto> _mostrar = res.TraerPorCategorio(codigo);

                foreach (Respuesto Mo in _mostrar)
                {
                    Console.WriteLine(Mo.ToString());
                }
            }
            catch (CodigoInexistenteExepcion ciex)
            {
                Console.WriteLine(ciex.Message);
            }
            catch (ListaSinDatosExepcion lsdex)
            {
                Console.WriteLine(lsdex.Message);
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void MostrarTod(CotrolesVentaRes obj) 
        {
            CotrolesVentaRes res = (CotrolesVentaRes)obj;

            try
            {
                List<Respuesto> _lista = res.MostrarRespuestos();

                foreach (Respuesto r in _lista)
                {
                    Console.WriteLine(r.ToString());
                }
            }
            catch (ListaSinDatosExepcion lsdex)
            {
                Console.WriteLine(lsdex.Message);
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }
        }

    }
}
