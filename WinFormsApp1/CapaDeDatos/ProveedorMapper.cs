using CapaDeEntidades.Entidades;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeDatos
{
    public class ProveedorMapper
    {
        public List<Proveedor> TraerTodosProveedores()
        {
            string json2 = WebHelperVentaHardware.Get("Proveedores");
            List<Proveedor> lst = MapList(json2);
            return lst;
        }

        private List<Proveedor> MapList(string json2)
        {
            List<Proveedor> lst = JsonConvert.DeserializeObject<List<Proveedor>>(json2);
            return lst;
        }


        public List<Proveedor> TraerPorCodigo(int usuario)
        {
            string jsons = WebHelperVentaHardware.Get("Proveedores/" + usuario.ToString());
            List<Proveedor> prov = JsonConvert.DeserializeObject<List<Proveedor>>(jsons);
            return prov;
        }

        private Proveedor Map(string jsons)
        {
            Proveedor prov = JsonConvert.DeserializeObject<Proveedor>(jsons);
            return prov;
        }

        public TransactionResult Insertar(Proveedor prov)
        {
            NameValueCollection obj = ReverseMap(prov);

            string json = WebHelperVentaHardware.Post("Proveedores", obj);

            TransactionResult lst = JsonConvert.DeserializeObject<TransactionResult>(json);

            return lst;

        }

        private NameValueCollection ReverseMap(Proveedor prov)
        {
            NameValueCollection n = new NameValueCollection();
            
            n.Add("id", 1.ToString());
            n.Add("idProducto", "0");
            n.Add("Activo","true");
            n.Add("FechaAlta", prov.FechaAlta);
            n.Add("Email",prov.Email);
            n.Add("CUIT",prov.Cuit);
            n.Add("Usuario", prov.Usuario.ToString());
            n.Add("Nombre", prov.Nombre);
            n.Add("Apellido", prov.Ape);
            return n;
        }


    }
}
