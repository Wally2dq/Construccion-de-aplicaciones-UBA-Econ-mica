using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibreriaExpendedora.Expendedor.ClaseLata;

namespace LibreriaExpendedora.Expendedor
{
    public class Expendedora
    {
        List<Lata> _latas; //No debo poner el mismo nombre en la clase que en el using o me salta error
        private string _proveedor;
        private int _capacidad;
        private double _dinero;
        private bool _encendido;

        public string Proveedor { get => this._proveedor; set => this._proveedor = value; }
        public int Capacidad { get => this._capacidad; set => this._capacidad = value; }
        public double Dinero { get => this._dinero; set => this._dinero = value; }
        public bool Encendido { get => this._encendido; set => this._encendido = value; }

        public Expendedora()
        {
            //ConstructorVacio
        }
        public Expendedora(string ProveedorIngreso, int CapacidadIngreso)
        {
            Proveedor = ProveedorIngreso;
            Capacidad = CapacidadIngreso;
            Dinero = 0;
            Encendido = false;
        }

        public void AgregarLata() { }

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
    }
}
