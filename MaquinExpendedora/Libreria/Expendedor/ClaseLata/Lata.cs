using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaExpendedora.Expendedor.ClaseLata
{
    public class Lata
    {
        private string _codigo;
        private string _nombre;
        private string _sabor;
        private double _precio;
        private double _volumen;
        private int _cantidad;

        public string Codigo { get => _codigo; set => this._codigo = value; }
        public string Nombre { get => _nombre; set => this._nombre = value; }
        public string Sabor { get => _sabor; set => this._sabor = value; }
        public double Precio { get => _precio; set => this._precio = value; }
        public double Volumen { get => _volumen; set => this._volumen = value; }
        public int Cantidad { get => _cantidad; set => this._cantidad = value; }

        public Lata(string CodigoIngreso, string NombreIngreso, string SaborIngreso,double PrecioIngreso,double VolumenIngreso, int CantidadIngreso )
        {
            this.Codigo = CodigoIngreso;
            this.Nombre = NombreIngreso;
            this.Sabor = SaborIngreso;
            this.Precio = PrecioIngreso;
            this.Volumen = VolumenIngreso;
            this.Cantidad = CantidadIngreso;
        }

        private double GetPrecioPorLitro()
        {
            return Volumen / Precio;
        }

        public string ToString()
        {
            throw new NotImplementedException();
        }
    }
}
