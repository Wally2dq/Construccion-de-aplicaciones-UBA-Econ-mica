using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    [DataContract]
    public class Prestamo
    {
        private int _id;
        private string _linea;
        private double _TNA;

        private int _plazo;
        private double _monto;
        private string _usuario;
        private double _cuota;
        private int _tipo;

        

        

        [DataMember]
        public string Linea { get => _linea; set => _linea = value; }
        [DataMember]
        public double TNA { get => _TNA; set => _TNA = value; }
        [DataMember]
        public int id { get => _id; set => _id = value; }

        [DataMember]
        public int Plazo { get => _plazo; set => _plazo = value; }
        [DataMember]
        public double Monto { get => _monto; set => _monto = value; }
        [DataMember]
        public string Usuario { get => _usuario; set => _usuario = value; }
        [DataMember]
        public double Cuota { get => _cuota; set => _cuota = value; }
        [DataMember]
        public int Tipo { get => _tipo; set => _tipo = value; }

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

        public override string ToString()
        {
            return $"id : {id}, Usuario : {Usuario}, Monto : {Monto}, Plazo : {Plazo}";
        }


    }
}
