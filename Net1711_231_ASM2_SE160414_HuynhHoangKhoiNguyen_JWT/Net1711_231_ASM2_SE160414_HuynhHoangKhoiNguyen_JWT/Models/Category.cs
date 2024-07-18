using System.ComponentModel.DataAnnotations;

namespace Net1711_231_ASM2_SE160414_HuynhHoangKhoiNguyen_JWT.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public virtual ICollection<Product> Products { get; set; } = new List<Product>();
    }
}
