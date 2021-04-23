using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaFacultad
{
    public class Salario
    {
        private double _bruto;
        private string _codigoTransferencia;
        private double _descuento;
        private DateTime _fecha;

        public double Bruto { get => this._bruto; set => this._bruto = value; }
        public string CodigoTranferencia { get => this._codigoTransferencia; set => this._codigoTransferencia = value; }
        public double Descuento { get => this._descuento; set => this._descuento = value; }
        public DateTime Fecha { get => this._fecha; set => this._fecha = value; }

        public Salario(double BrutoIngreso, string CodigoDeTransferenciaIngreso, double DescuentoIngreso) 
        {
            this.Bruto = BrutoIngreso;
            this.CodigoTranferencia = CodigoDeTransferenciaIngreso;
            this.Descuento = DescuentoIngreso;
            this.Fecha = DateTime.Today;

        }

        public double GetSalarioNeto() 
        {
            return Bruto - Descuento;
        }

        public double SalarioEmpleado() 
        {
            return Bruto;
        }

        public override string ToString()
        {
            return "Salario Empleado: " + SalarioEmpleado() +
                "\n Salario Neto: " + GetSalarioNeto()+
                $"\n Fecha: {Fecha}";

        }
    }
}
