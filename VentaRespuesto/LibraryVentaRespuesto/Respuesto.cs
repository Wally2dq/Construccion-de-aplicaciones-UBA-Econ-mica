using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryVentaRespuesto
{
    public sealed class Respuesto : Categoria
    {
        Categoria _categoriaRes;

        private int _codigoRespuesto;
        private string _nombreRes;
        private double _precio;
        private int _stock;

        public double Precio { get => this._precio; set => this._precio = value; }
        public int Stock { get => this._stock; set => this._stock = value; }
        public int CodigoRes { get => this._codigoRespuesto;}
        public string NombreRes { get => this._nombreRes;}


        public Respuesto(int CodigoIngCate, string NombreIngCate, int CodigoIng, string NombreIng, double PrecioIng, int StockIng) : base(CodigoIngCate, NombreIngCate)
        {
            _codigoRespuesto = CodigoIng;
            _nombreRes = NombreIng;
            _precio = PrecioIng;
            _stock = StockIng;
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            if (!(obj is Respuesto))
                return false;

            Respuesto Res = (Respuesto)obj;

            if (Res.CodigoRes != this.CodigoRes)
                return false;

            return true;
        }

        public override string ToString()
        {
            return $"Codigo Categorio {_categoriaRes.CodigoCat}, Nombre Categorio {_categoriaRes.NombreCat}" +
                $"\n Respuesto :" +
                $"\n Codigo {CodigoRes}, Nombre {NombreCat}, Precio ${Precio}, Stock {Stock} ";
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
