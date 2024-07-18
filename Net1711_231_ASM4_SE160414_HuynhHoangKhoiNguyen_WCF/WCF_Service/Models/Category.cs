using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WCF_Service.Models
{
    [DataContract]
    public class Category
    {
        [DataMember]
        public int CategoryId { get; set; }

        [DataMember]
        public string Name { get; set; }
    }
}
