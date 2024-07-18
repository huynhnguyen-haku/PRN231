using System.ComponentModel.DataAnnotations;

namespace Net1711_231_ASM2_SE160414_HuynhHoangKhoiNguyen_JWT.DTOs
{
    public class ProductDTO
    {
        [Key]
        public int ProductId { get; set; }
        public int AccountId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public int Price { get; set; }
        public int QuantityInStock { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public int TotalRating { get; set; }
    }
}
