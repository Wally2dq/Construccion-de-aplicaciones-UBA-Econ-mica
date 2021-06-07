using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    [DataContract]
    public class PrestamoTipo
    {
        private string _linea;
        private double _TNA;

        private int _id;

        [DataMember]
        public string Linea { get => _linea; set => _linea = value; }
        [DataMember]
        public double TNA { get => _TNA; set => _TNA = value; }
        [DataMember]
        public int id { get => _id; set => _id = value; }


        /*+ CuotaCapital: Monto/Plazo
+ CuotaInteres: CuotaCapital* (TNA/12/100)
+ Cuota: CuotaCapital + CuotaInteres*/

        public override string ToString()
        {
            return $"id: {id}, Linea: {Linea}, TNA: {TNA}";
        }

    }
}
