using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    [DataContract]
    public sealed class Prestamo : PrestamoTipo
    {

        private int _plazo;
        private double _monto;
        private string _usuario;
        private double _cuota;


        [DataMember]
        public int Plazo { get => _plazo; set => _plazo = value; }
        [DataMember]
        public double Monto { get => _monto; set => _monto = value; }
        [DataMember]
        public string Usuario { get => _usuario; set => _usuario = value; }
        [DataMember]
        public double Cuota { get => _cuota; set => _cuota = value; }

        public Prestamo() 
        {
        }

        public double CuotaCapital(double Monto, int Plazo)
        {
            return Monto / Plazo;
        }
        public double CuotaInteres(double CuotaCapital, double TNA)
        {
            return CuotaCapital * (TNA / 12 / 100);
        }
        public double CuotaTotal(double CuotaCapital, double CuotaInteres)
        {
            return CuotaCapital + CuotaInteres;
        }

        
    }
}
