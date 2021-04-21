using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaFacultad
{
    public class Bedel : Empleado
    {
        private string _apodo;

        public string Apodo { get => this._apodo; set => this._apodo = value; }

        public override string GetNombreCompleto()
        {
            return $"Bedel {Apodo}";
        }
    }
}
