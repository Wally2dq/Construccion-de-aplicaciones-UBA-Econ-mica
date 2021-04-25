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

        public int CodigoCat{ get => this._codigoCat; set => this._codigoCat = value; }
        public string NombreCat { get => this._nombreCat; set => this._nombreCat = value; }
    }
}
