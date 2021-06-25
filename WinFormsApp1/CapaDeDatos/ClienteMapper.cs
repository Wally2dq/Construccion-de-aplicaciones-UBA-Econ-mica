using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDeEntidades.Entidades;
using Newtonsoft.Json;
using CapaDeEntidades;
using System.Collections.Specialized;

namespace CapaDeDatos
{
    public class ClienteMapper
    {
        public List<Cliente> TraerTodosClientes() 
        {
            string json2 = WebHelper.Get("cliente");
            List<Cliente> lst = MapList(json2);
            return lst;
        }

        private List<Cliente> MapList(string json2)
        {
            List<Cliente> lst = JsonConvert.DeserializeObject<List<Cliente>>(json2);
            return lst;
        }

        public Cliente TraerPorCodigo(int Codigo)
        {
            string jsons = WebHelper.Get("cliente/" + Codigo.ToString());
            Cliente cliente = JsonConvert.DeserializeObject<Cliente>(jsons);
            //Cliente cliente = Map(jsons);
            return cliente;
        }

        private Cliente Map(string jsons)
        {
            Cliente cliente = JsonConvert.DeserializeObject<Cliente>(jsons);
            return cliente;
        }

        public TransactionResult Insertar(Cliente cliente) 
        {
            NameValueCollection obj = ReverseMap(cliente);

            string json = WebHelper.Post("cliente",obj);

            TransactionResult lst = JsonConvert.DeserializeObject<TransactionResult>(json);

            return lst;

        }

        private NameValueCollection ReverseMap(Cliente cliente)
        {
            NameValueCollection c = new NameValueCollection();
            c.Add("id", cliente.id.ToString());
            c.Add("nombre", cliente.Nombre);
            c.Add("apellido", cliente.Ape);
            c.Add("direccion", cliente.Direccion);
            c.Add("DNI", cliente.dni);
            c.Add("fechaNacimiento", cliente.fechaNacimiento);
            c.Add("usuario", cliente.usuario);
            c.Add("telefono", cliente.telefono);
            c.Add("email", cliente.email);

            return c;
        }
    }
}
