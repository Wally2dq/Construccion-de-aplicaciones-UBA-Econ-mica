using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClaseEntidades;
using Newtonsoft.Json;

namespace CapaDatos
{
    public class CuentaMappers
    {
        public Cuenta Traer(int IdCliente)
        {
            string json2 = WebHelper.Get("cuenta" + IdCliente.ToString()); // trae un texto en formato json de una web
            Cuenta resultado = MapList(json2);
            return resultado;

        }

        private Cuenta MapList(string json2)
        {
            Cuenta cuenta = JsonConvert.DeserializeObject<Cuenta>(json2);
            return cuenta;
            
        }
    }
}
