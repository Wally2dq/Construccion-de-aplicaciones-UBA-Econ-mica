using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibreriaBotones.Controles.Boton;
using LibreriaBotones.Controles.Exepciones;

namespace LibreriaBotones.Controles
{
    public class Controles
    {
        List<Botones> _Botones; //Me salta este error, como los soluciono?

        public Controles()
        {
           _Botones = new List<Botones>();
        }

        public void AgregarBotonEnLista()  //Agrego los botones por medio del menu
        {
            bool flag = false;
            int IngresoBoton = 0;
            string DescripcionBoton="";

            do //BUCLE DE LA ENTRADA DEL CODIGO
            {
                try
                {
                    Console.WriteLine("Ingrese el codigo del Boton");
                    IngresoBoton = Convert.ToInt32(Console.ReadLine());
                    flag = true;
                }
                catch (FormatException ForEx)
                {
                    Console.WriteLine("Ingrese un Numero " + ForEx.Message);
                    flag = false;

                }
                catch (RepetidoExepcion Rex) 
                {
                    Console.WriteLine("Valor Repetido, Ingrese otro "+Rex.Message);
                    flag = false;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ocurrio un error " + ex.Message);
                    flag = false;

                }
            } while (flag!=true);

            do //BUCLE PARA EL INGRESO DE LA DESCRIPCION
            {
                try
                {
                    Console.WriteLine("Ingrese la Descripcion del Boton");
                    DescripcionBoton = Console.ReadLine();
                    flag = true;
                }
                catch (ArgumentNullException ArEx)
                {
                    Console.WriteLine("No debe ser Nula la descripcion "+ArEx.Message);
                    flag = false;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ocurrio un error " + ex.Message);
                    flag = false;

                }
            } while (flag != true);

            AgregarBoton(IngresoBoton,DescripcionBoton);
            //ACA CARGO LOS DATOS LUEGO DE VALIDARLOS

        }

        private void AgregarBoton(int cod, string descripcion)  //Agrego el boton a la lista 
        {
            Botones btn = new Botones(cod, descripcion); //Utilizo el construtor con parametros

            _Botones.Add(btn);
        }
    }
}
