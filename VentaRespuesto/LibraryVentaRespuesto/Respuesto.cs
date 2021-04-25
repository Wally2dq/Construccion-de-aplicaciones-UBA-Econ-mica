using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryVentaRespuesto
{
    public sealed class Respuesto : Categoria
    {
        private int _codigoRespuesto;
        private string _nombreRes;
        private double _precio;
        private int _stock;

        public double Precio { get => this._precio; set => this._precio = value; }
        public int Stock { get => this._stock; set => this._stock = value; }
        public int CodigoRes { get => this._codigoRespuesto; set => this._codigoRespuesto = value; }
        public string NombreRes { get => this._nombreRes; set => this._nombreRes=value; }


        public Respuesto(int CodigoIngCate, string NombreIngCate, int CodigoIng,string NombreIng,double PrecioIng,int StockIng)
        {
            CodigoCat = CodigoIngCate; //Categorio
            NombreCat = NombreIngCate; //Categoria
            CodigoRes = CodigoIng;
            NombreRes = NombreIng;
            Precio = PrecioIng;
            Stock = StockIng;
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
            return $"Codigo Categorio {CodigoCat}, Nombre Categorio {NombreCat}" +
                $"\n Respuesto :" +
                $"\n Codigo {CodigoRes}, Nombre {NombreCat}, Precio ${Precio}, Stock {Stock} ";
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
