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

        public string Codigo { get => _codigo; }
        public string Nombre { get => _nombre; }
        public string Sabor { get => _sabor; }
        public double Precio { get => _precio; }
        public double Volumen { get => _volumen; }
        public int Cantidad { get => _cantidad; }

        public Lata()
        {
            //Rellenar
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
