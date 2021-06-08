using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Banca.Entidades.Modelos
{
    [DataContract]
    public class TxResult
    {
        [DataMember]
        public bool isOk { get; set; }

        [DataMember]
        public string error { get; set; }

        [DataMember]
        public int id { get; set; }
    }
}
