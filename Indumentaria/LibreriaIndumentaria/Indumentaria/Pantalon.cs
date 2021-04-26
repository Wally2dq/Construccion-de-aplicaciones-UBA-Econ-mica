using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaIndumentaria
{
    public sealed class Pantalon : Indumentaria
    {
        private string _material;
        private bool _tieneBolsillos;

        public string Material { get => this._material; }
        public bool TieneBolsillo { get => this._tieneBolsillos; }

        public Pantalon(int Codigo, string talle, double precio, string Origen, double Algodon,string material,bool Bolsillo) : base(Codigo, talle, precio, Origen, Algodon)
        {
            _material = material;
            _tieneBolsillos = Bolsillo;
        }
        protected override string GetDetalle()
        {
            string salida;
            if (TieneBolsillo == false)
            {
                salida = "Si";
            }
            else
            {
                salida = "No";
            }

            return $"Pantalon, Tiene Bolsillo {salida}, Material {Material}" +
                $"\n Codigo {Codigo}, Stock {Stock}, Talle {Talle}, Precio {Precio}, Origen{Origen},Porcentaje de algodon %{PorcentajeAlgodon}";
        }

        public override string ToString()
        {
            return GetDetalle() ;
        }

    }
}
