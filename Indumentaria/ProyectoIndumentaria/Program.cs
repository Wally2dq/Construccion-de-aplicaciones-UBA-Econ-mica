using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibreriaIndumentaria;

namespace ProyectoIndumentaria
{
    class Program
    {
        private static TiendaRopa tienda = new TiendaRopa();
        private static ValidacionesClase validar = new ValidacionesClase();
        static void Main(string[] args)
        {
            EjecutarOperaciones();
        }

        static string Menu() 
        {
            return "Menu" +
               "\n 1 Mostrar Indumentaria" +
               "\n 2 Agregar Indumentaria" +
               "\n 3 Eliminar Indumentaria" +
               "\n 4 " +
               "\n 5 " +
               "\n 6 " +
               "\n 7 " +
               "\n 8  ";
        }

        static void EjecutarOperaciones() 
        {
            int Opciones;
            bool flag = true;

            Indumentaria indu = new Pantalon(123, "m", 22, "d", 33, "Nose", false);
            tienda.AgregarIndumentaria(indu);

            do
            {
                Console.WriteLine(Menu());

                Console.WriteLine("Ingrese su opcion");
                Opciones = validar.ValidarNumeroEntero();


                switch (Opciones) 
                {
                    case 1:
                        try
                        {
                            List<Indumentaria> Mostrar = tienda.Listar();

                            foreach (Indumentaria i in Mostrar) 
                            {
                                Console.WriteLine(i.ToString()) ;
                            }
                        }
                        catch (ListaSinDatosExepcion lsde) 
                        {
                            Console.WriteLine(lsde.Message);
                        }
                        catch (Exception Ex)
                        {
                            Console.WriteLine(Ex.Message);
                        }
                        break;
                    case 2:
                        AgregarIdumentaria();
                        break;
                    case 3:
                        EliminarIndumentaria();
                        break;
                    default:
                        Console.WriteLine("Ingrese una opcion");
                        break;
                }

            } while (flag != false);
        }

        static void AgregarIdumentaria() 
        {
            int Opciones;
            bool flag = true;

            do 
            {
                Console.WriteLine("Que desea Ingresar" +
                "\n1- Camisa" +
                "\n2-Pantalon");
                Opciones = validar.ValidarNumeroEntero();

                switch (Opciones) 
                {
                    case 1:
                        AgregarCamisa();
                        flag = false;
                        break;
                    case 2:
                        AgregarPantalon();
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("Ingrese 1 o 2");
                        flag = true;
                        break;

                }

            } while (flag !=false);
            
        }
        static void AgregarCamisa() 
        {
            Console.WriteLine("Ingrese los datos");
            Console.WriteLine("Origen");
            string Origen = validar.ValidarString();

            Console.WriteLine("Porcentaje de Algodon");
            double algodon = validar.ValidarDouble();

            Console.WriteLine("Codigo");
            int Codigo = validar.ValidarNumeroEntero();

            Console.WriteLine("Talle");
            string Talle = validar.ValidarString();

            Console.WriteLine("Precio");
            double Precio = validar.ValidarDouble();

            Console.WriteLine("Tiene Estampado?");
            bool estan = false;
            bool flag = false;
            do
            {
                flag = true;
                try
                {
                    string Estampado = validar.ValidarString().ToUpper();

                    if (Estampado == "SI")
                    {
                        estan = false;
                        flag= false;
                    }
                    if (Estampado == "NO")
                    {
                        estan = true;
                        flag= false;
                    }
                    else
                    {
                        throw new SioNoException("Ingrese si o no");
                    }
                }
                catch (SioNoException SiNO)
                {
                    Console.WriteLine(SiNO.Message);
                    flag = true;
                }

            } while (flag != false) ;

            Console.WriteLine("Tipo de manga");
            string Manga = validar.ValidarString();

            Indumentaria indu = new Camisa(Codigo,Talle,Precio,Origen,algodon,estan,Manga);

            try
            {
                tienda.AgregarIndumentaria(indu);
            }
            catch (CodigoRegistradoExepcion cre)
            {
                Console.WriteLine(cre.Message);
            }

        }
        static void AgregarPantalon() 
        {
            Console.WriteLine("Ingrese los datos");
            Console.WriteLine("Origen");
            string Origen = validar.ValidarString();

            Console.WriteLine("Porcentaje de Algodon");
            double algodon = validar.ValidarDouble();

            Console.WriteLine("Codigo");
            int Codigo = validar.ValidarNumeroEntero();

            Console.WriteLine("Talle");
            string Talle = validar.ValidarString();

            Console.WriteLine("Precio");
            double Precio = validar.ValidarDouble();

            Console.WriteLine("Tiene Bolsillo?");
            bool Bolsillo = false;
            bool flag = false;
            do
            {
                flag = true;
                try
                {
                    string Estampado = validar.ValidarString().ToUpper();

                    if (Estampado == "SI")
                    {
                        Bolsillo = false;
                        flag = false;
                    }
                    else if (Estampado == "NO")
                    {
                        Bolsillo = true;
                        flag = false;
                    }
                    else
                    {
                        throw new SioNoException("Ingrese si o no");
                    }
                }
                catch (SioNoException SiNO)
                {
                    Console.WriteLine(SiNO.Message);
                    flag = true;
                }

            } while (flag != false);

            Console.WriteLine("Tipo de Material");
            string  material = validar.ValidarString();

            Indumentaria indu = new Pantalon(Codigo, Talle, Precio, Origen, algodon, material, Bolsillo);

            try
            {
                tienda.AgregarIndumentaria(indu);
            }
            catch (CodigoRegistradoExepcion cre)
            {
                Console.WriteLine(cre.Message);
            }
            
            
        }
        static void EliminarIndumentaria() 
        {
            try
            {
                Console.WriteLine("Ingrese el codigo de la indumentaria a eliminar");
                int Codigo = validar.ValidarNumeroEntero();

                Indumentaria borrar = tienda.TraerIndumentaria(Codigo);

                tienda.QuitarIndumentaria(borrar);
            }
            catch (ListaSinDatosExepcion lsde) 
            {
                Console.WriteLine(lsde.Message);
            }
            catch (CodigoNoRegistradoExepcion cnre)
            {
                Console.WriteLine(cnre.Message);
            }

        }
    }
}
