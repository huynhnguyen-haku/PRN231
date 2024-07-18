namespace Net1711_231_ASM3_SE160414_HuynhHoangKhoiNguyen_gRPC.Models
{
    public class MockDataInit
    {
        public static List<Category> Categories = new List<Category>
        {
            new Category
            {
                CategoryId = 1,
                CategoryName = "Sữa bột"
            },
            new Category
            {
                CategoryId = 2,
                CategoryName = "Sữa tươi"
            },
        };

        public static List<Product> Products = new List<Product>
        {
            new Product
            {
                ProductId = 1,
                AccountId = 1,
                CategoryId = 1,
                ProductName = "Sữa bột Bimbosan Stage 3",
                Price = 200000,
                QuantityInStock = 100,
                Description = "Sữa bột dành cho trẻ từ 1-3 tuổi",
                Status = "Selling",
                CreatedDate = "2021-05-01",
                UpdatedDate = "2021-05-01",
                TotalRating = 5
            },

            new Product
            {
                ProductId = 2,
                AccountId = 1,
                CategoryId = 1,
                ProductName = "Sữa bột NAN Expert Pro",
                Price = 300000,
                QuantityInStock = 100,
                Description = "Sữa bột dành cho trẻ từ 4-6 tuổi",
                Status = "Selling",
                CreatedDate = "2021-05-01",
                UpdatedDate = "2021-05-01",
                TotalRating = 5
            },

            new Product
            {
                ProductId = 3,
                AccountId = 2,
                CategoryId = 2,
                ProductName = "Sữa tươi Vinamilk",
                Price = 10000,
                QuantityInStock = 100,
                Description = "Sữa tươi Vinamilk 100% sữa tươi nguyên chất",
                Status = "Selling",
                CreatedDate = "2021-05-01",
                UpdatedDate = "2021-05-01",
                TotalRating = 5
            },

            new Product
            {
                ProductId = 4,
                AccountId = 2,
                CategoryId = 2,
                ProductName = "Sữa tươi TH True Milk",
                Price = 15000,
                QuantityInStock = 100,
                Description = "Sữa tươi TH True Milk 100% sữa tươi nguyên chất",
                Status = "Selling",
                CreatedDate = "2021-05-01",
                UpdatedDate = "2021-05-01",
                TotalRating = 5
            }
        };
    }
}
