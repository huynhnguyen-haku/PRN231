namespace Net1711_231_ASM3_SE160414_HuynhHoangKhoiNguyen_gRPC.DTO
{
    public class CategoryDTO
    {
        public class CreateCategoryRequest
        {
           public string CategoryName { get; set; }
        }

        public class UpdateCategoryRequest
        {
            public int CategoryId { get; set; }
            public string CategoryName { get; set; }
        }
    }
}
