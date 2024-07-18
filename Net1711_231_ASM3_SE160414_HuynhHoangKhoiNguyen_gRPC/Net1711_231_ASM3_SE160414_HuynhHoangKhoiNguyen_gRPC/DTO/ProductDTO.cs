namespace Net1711_231_ASM3_SE160414_HuynhHoangKhoiNguyen_gRPC.DTO
{
    public class ProductDTO
    {
        public class CreateProductRequest
        {
            public int AccountId { get; set; }
            public int CategoryId { get; set; }
            public string ProductName { get; set; }
            public int Price { get; set; }
            public int QuantityInStock { get; set; }
            public string? Description { get; set; }
            public string? Status { get; set; }
            public string CreatedDate { get; set; }
            public string UpdatedDate { get; set; }
            public int TotalRating { get; set; }
        }

        public class UpdateProductRequest
        {
            public int ProductId { get; set; }
            public int AccountId { get; set; }
            public int CategoryId { get; set; }
            public string ProductName { get; set; }
            public int Price { get; set; }
            public int QuantityInStock { get; set; }
            public string? Description { get; set; }
            public string? Status { get; set; }
            public string CreatedDate { get; set; }
            public string UpdatedDate { get; set; }
            public int TotalRating { get; set; }
        }
    }
}
