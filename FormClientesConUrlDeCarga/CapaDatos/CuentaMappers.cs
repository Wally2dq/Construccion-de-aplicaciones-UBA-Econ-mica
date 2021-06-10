using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClaseEntidades;
using Newtonsoft.Json;

namespace CapaDatos
{
    public class CuentaMappers
    {
        public List<Cuenta> TraerTodasCuentas() 
        {
            string json = WebHelper.Get("cuenta");
            List<Cuenta> _lst = MapperLista(json);
            return _lst;
        }

        private List<Cuenta> MapperLista(string json)
        {
            List<Cuenta> lst = JsonConvert.DeserializeObject<List<Cuenta>>(json);
            return lst;
        }

        public Cuenta TraerPorId(int id) 
        {
            string json = WebHelper.Get("cuenta/" + id.ToString());
            Cuenta lst = MapperCuenta(json);
            return lst;
        }

        private Cuenta MapperCuenta(string json)
        {
            Cuenta lst = JsonConvert.DeserializeObject<Cuenta>(json);
            return lst;
        }

        public TransactionResult Alta(Cuenta cuenta) 
        {
            NameValueCollection obj = ReverseMapperAlta(cuenta);

            string json = WebHelper.Post("cuenta", obj);

            TransactionResult res = JsonConvert.DeserializeObject<TransactionResult>(json);

            return res;
        }

        private NameValueCollection ReverseMapperAlta(Cuenta cuenta)
        {
            NameValueCollection n = new NameValueCollection();
            n.Add("idCliente",cuenta.idCliente.ToString());
            n.Add("Descripcion",cuenta.descripcion);
            n.Add("FechaAapertura",DateTime.Now.ToString());
           

            return n;
        }

        public TransactionResult Actualizar(Cuenta cuenta) 
        {
            NameValueCollection obj = ReverseMapperAct(cuenta);

            string json = WebHelper.Post("cuenta", obj);

            TransactionResult lst = JsonConvert.DeserializeObject<TransactionResult>(json);

            return lst;
        }

        private NameValueCollection ReverseMapperAct(Cuenta cuenta)
        {
            NameValueCollection n = new NameValueCollection();
            n.Add("id", cuenta.id.ToString());
            n.Add("Saldo", cuenta.saldo.ToString("0.00"));
            n.Add("FechaModificacion", DateTime.Now.ToString());
             
            return n;
        }

        
    }
}
