using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeEntidades.Entidades
{
    [DataContract]
    public class TransactionResult
    {
        [DataMember]
        public bool IsOk { get; set; }
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Error { get; set; }
    }
}
