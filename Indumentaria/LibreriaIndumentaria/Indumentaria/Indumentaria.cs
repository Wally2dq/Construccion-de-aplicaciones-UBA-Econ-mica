using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaIndumentaria
{
    public abstract class Indumentaria : TipoIndumentaria
    {
        protected int _codigo;
        protected int _stock;
        protected string _talle;
        protected double _precio;

        public int Codigo { get => _codigo ; }
        public int Stock { get => _stock; }
        public string Talle { get => _talle; }
        public double Precio { get => _precio; }

        public Indumentaria(int Codigo,string talle,double precio,string Origen,double Algodon) :base(Origen,Algodon)
        {
            _codigo = Codigo;
            _talle = talle;
            _precio = precio;
            _stock = 3;
        }


        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            if (!(obj is Indumentaria))
                return false;

            Indumentaria ind = (Indumentaria)obj;

            if (ind._codigo != this._codigo)
                return false;

            return true;
        }

        protected abstract string GetDetalle();

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString() 
        {
            return $"Codigo {Codigo}, Stock {Stock}, Talle {Talle}, Precio {Precio}, Origen{Origen},Porcentaje de algodon %{PorcentajeAlgodon}";
        }
    }
}
