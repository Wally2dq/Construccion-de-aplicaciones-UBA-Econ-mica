using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    [DataContract]
    public class TipoPlazoFijo
    {
        private int _id;
        private double _tasa;
        private string _descripcion;

        [DataMember]
        public int id { get => _id; set => _id = value; }
        [DataMember]
        public double Tasa { get => _tasa; set => _tasa = value; }
        [DataMember]
        public string Descripcion { get => _descripcion; set => _descripcion = value; }

        public override string ToString()
        {
            return $"{id}, {Descripcion} , {Tasa}%";
        }

        public TipoPlazoFijo() { }

        
        
    }
}
