using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibreriaExpendedora.Expendedor.ClaseLata;
using LibreriaExpendedora.Validaciones;
using LibreriaExpendedora.Exepciones;

namespace LibreriaExpendedora.Expendedor
{
    public class Expendedora
    {
        List<Lata> _latas; //
        private string _proveedor;
        private int _capacidad;
        private double _dinero;
        private bool _encendido;

        
        public string Proveedor { get => this._proveedor; set => this._proveedor = value; }
        public int Capacidad { get => this._capacidad; set => this._capacidad = value; }
        public double Dinero { get => this._dinero; set => this._dinero = value; }
        public bool Encendido { get => this._encendido; set => this._encendido = value; }

        public List<Lata> Latas { get => this._latas; set => this._latas = value; }

        
        public Expendedora(string ProveedorIngreso, int CapacidadIngreso)
        {
            this._latas = new List<Lata>();
            this.Proveedor = ProveedorIngreso;
            this.Capacidad = CapacidadIngreso;
            this.Dinero = 0;
            this.Encendido = false;

        }


        public void AgregarLata() 
        {
            string Codigo ="";
            string Nombre = "";
            string Sabor = "";
            double Precio = 0;
            double Volumen = 0;
            int Cantidad = 0;

            bool flag = false;

            Console.WriteLine("Ingrese el codigo de la lata");

            ValidacionesClase validaciones = new ValidacionesClase();

            do
            {
                try
                {
                    
                    validaciones.ValidarString(ref Codigo);

                    foreach (Lata i in _latas)
                    {
                        if (Codigo == i.Codigo)
                        {
                            throw new CodigoInvalidoExepcion("Codigo ya registrado");
                        }
                    }
                    flag = true;
                }
                catch (CodigoInvalidoExepcion CodEx)
                {
                    Console.WriteLine(CodEx.Message);
                    flag = false;
                }
                catch (Exception Ex) 
                {
                    Console.WriteLine(Ex.Message);
                    flag = false;
                }
            } while (flag!=true);

            Console.WriteLine("Ingrese el nombre");
            validaciones.ValidarString(ref Nombre);

            Console.WriteLine("Ingrese el sabor");
            validaciones.ValidarString(ref Sabor);

            Console.WriteLine("Ingrese el Precio");
            validaciones.ValidarDouble(ref Precio);

            Console.WriteLine("Ingrese el Volumen");
            validaciones.ValidarDouble(ref Volumen);


            do {
                Console.WriteLine("Ingrese la Cantidad");
                validaciones.ValidarNumeroEntero(ref Cantidad);

                if (Cantidad > Capacidad)
                {
                    Console.WriteLine("No hay mas capacidad en la expendedora" +
                        $"\nLe restan {Capacidad} de espacio");
                    flag = false;
                }
                else 
                {
                    flag = true;
                }

            } while (flag!=true);


            AgregarLataLista(Codigo, Nombre, Sabor, Precio, Volumen, Cantidad);


        }

        private void AgregarLataLista(string CodigoIngreso, string NombreIngreso, string SaborIngreso, double PrecioIngreso, double VolumenIngreso, int CantidadIngreso)
        {
            Lata Lata = new Lata(CodigoIngreso, NombreIngreso, SaborIngreso, PrecioIngreso, VolumenIngreso, CantidadIngreso);
            _latas.Add(Lata);
            Console.WriteLine("Usted cargo la lata con exito");  

            //NO SE CARGAN LOS DATOS A LA LISTA
        }

        public void BuscarCodigo(string Codigo) 
        {
            
        }

        public Lata ExtraerLata(string Codigo, double Dinero)
        {
            throw new NotImplementedException();
        }

        public string GetBalance()
        {
            throw new NotImplementedException();
        }

        public int GetCapacidadRestante()
        {
            throw new NotImplementedException();
        }

        public void EncenderMaquina()
        {
            Encendido = true;
        }

        public bool EstaVacia()
        {
            throw new NotImplementedException();
        }

        public List<string> MostrarLista() 
        {
            List<string> lista = new List<string>();

            if (_latas.Count > 0) 
            {
                foreach (Lata lata in _latas)
                {
                    lista.Add("" + lata.Codigo + ") " + lata.Nombre + " [" + lata.Cantidad + "] ");
                }
            }

            return lista;

            
        }

        
    }
}
