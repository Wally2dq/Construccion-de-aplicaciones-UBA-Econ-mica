using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaIndumentaria
{
    public sealed class Camisa : Indumentaria
    {
        private bool _tieneEstampado;
        private string _tipoManga;

        bool TieneEstampado { get => this._tieneEstampado; }
        string TipoManga { get => this._tipoManga; }

        public Camisa(int Codigo, string talle, double precio, string Origen, double Algodon,bool estanpado,string tipomanga) : base(Codigo,talle,precio,Origen, Algodon)
        {
            _tieneEstampado = estanpado;
            _tipoManga = tipomanga;
        }

        protected override string GetDetalle()
        {
            string salida;
            if (TieneEstampado == false)
            {
                salida = "Si";
            }
            else 
            {
                salida = "No";
            }
            
            return $"Remera, Estanpado {salida}, TipoManga {TipoManga}"+
                $"\n Codigo {Codigo}, Stock {Stock}, Talle {Talle}, Precio {Precio}, Origen{Origen},Porcentaje de algodon %{PorcentajeAlgodon}";
        }
        public override string ToString() 
        {
            return GetDetalle();
        }
    }
}
