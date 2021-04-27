using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryVentaRespuesto
{
    public abstract class Categoria
    {
        protected int _codigoCat;
        protected string _nombreCat;

        public int CodigoCat{ get => this._codigoCat;}
        public string NombreCat { get => this._nombreCat; }

        public Categoria(int Codigo, string Nombre) 
        {
            _codigoCat = Codigo;
            _nombreCat = Nombre;
        }

    }
}
