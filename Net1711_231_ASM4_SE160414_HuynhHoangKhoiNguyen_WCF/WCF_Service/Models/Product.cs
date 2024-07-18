using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WCF_Service.Models
{
    public class Product
    {
        [DataMember]
        public int ProductId { get; set; }
        [DataMember]
        public int CategoryId { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public int Price { get; set; }
        [DataMember]
        public int Quantity { get; set; }
        [DataMember]
        public string Description { get; set; } = string.Empty;
        [DataMember]
        public string ImageUrl { get; set; } = string.Empty;
        [DataMember]
        public int TotalRating { get; set; }
        [DataMember]
        public DateTime CreatedAt { get; set; }
        [DataMember]
        public DateTime UpdatedAt { get; set; }
        [DataMember]
        public string Status { get; set; }
    }
}
