using System.ComponentModel.DataAnnotations;

namespace Net1711_231_ASM2_SE160414_HuynhHoangKhoiNguyen_JWT.DTOs
{
    public class CategoryDTO
    {
        [Key]
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
