using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    [DataContract]
    public class PlazoFijo
    {
        private int _id;
        private int _idCliente;
        private int _tipo;
        private double _tasa;
        private int _dias;
        private double _capitalInicial;

        TipoPlazoFijo _tipoPlazoFijo;

        private string _usuario;

        [DataMember]
        public int id { get => _id; set => _id = value; }
        [DataMember]
        public int idCliente { get => _idCliente; set => _idCliente = value; }
        [DataMember]
        public int Tipo { get => _tipo; set => _tipo = value; }
        [DataMember]
        public double Tasa { get => _tasa; set => _tasa = value; }
        [DataMember]
        public int Dias { get => _dias; set => _dias = value; }
        [DataMember]
        public double CapitalInicial { get => _capitalInicial; set => _capitalInicial = value; }

        public double Interes { get => ((Tasa / 365 * Dias) * CapitalInicial) / 100; }
        public double MontoFinal { get => CapitalInicial + Interes; }

        [DataMember]
        public string Usuario { get => _usuario; set => _usuario = value; }

        public TipoPlazoFijo TipoPlazoFijo { get => _tipoPlazoFijo; set => _tipoPlazoFijo = value; }

        public PlazoFijo() { }

        public override string ToString()
        {
           
            return $"{id}) Días {Dias} - ARS {CapitalInicial} ({Interes} %) – tipo {Tipo}()";
        }
    }
}
