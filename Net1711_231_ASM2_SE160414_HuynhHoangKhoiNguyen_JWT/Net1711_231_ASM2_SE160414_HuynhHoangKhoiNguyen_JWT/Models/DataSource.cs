namespace Net1711_231_ASM2_SE160414_HuynhHoangKhoiNguyen_JWT.Models
{
    public class DataSource
    {
        public static List<Category> Categories = new List<Category>()
        {
            new Category { CategoryId = 1, CategoryName = "Sữa bột" },
            new Category { CategoryId = 2, CategoryName = "Sữa tươi" },
            new Category { CategoryId = 3, CategoryName = "Sữa đặc" }
        };

        public static List<Product> Products = new List<Product>()
        {
            new Product
            {
                ProductId = 1,
                AccountId = 1,
                ProductName = "Sữa bột Bimbosan Stage 3",
                CategoryId = 1,
                Price = 572000,
                QuantityInStock = 10,
                Description = "Sữa bột dành cho trẻ từ 1-12 tháng tuổi",
                Status = "Selling",
                CreatedDate = new DateTime(2023, 5, 10),
                UpdatedDate = new DateTime(2024, 5, 1),
                TotalRating = 0
            },

            new Product
            {
                ProductId = 2,
                AccountId = 1,
                ProductName = "Sữa bột Abbott Ensure Gold ít ngọt Vanilla",
                CategoryId = 1,
                Price = 411000,
                QuantityInStock = 20,
                Description = "Sữa bột dành cho trẻ từ 1-3 tuổi",
                Status = "Selling",
                CreatedDate = new DateTime(2023, 5, 1),
                UpdatedDate = new DateTime(2024, 5, 1),
                TotalRating = 0
            },

            new Product
            {
                ProductId = 3,
                AccountId = 1,
                ProductName = "Sữa bột NAN Expert Pro",
                CategoryId = 1,
                Price = 201000,
                QuantityInStock = 15,
                Description = "Sữa bột dành cho trẻ bị khó ăn, tiêu chảy",
                Status = "Selling",
                CreatedDate = new DateTime(2023, 5, 1),
                UpdatedDate = new DateTime(2024, 5, 1),
                TotalRating = 0
            },

            new Product
            {
                ProductId = 4,
                AccountId = 2,
                ProductName = "Sữa tươi tiệt trùng TH True Milk 1L",
                CategoryId = 2,
                Price = 34000,
                QuantityInStock = 20,
                Description = "Sữa tươi nguyên chất từ TH True Milk, giúp tăng sức đề kháng",
                Status = "Selling",
                CreatedDate = new DateTime(2023, 5, 1),
                UpdatedDate = new DateTime(2024, 5, 1),
                TotalRating = 0
            },

            new Product
            {
                ProductId = 5,
                AccountId = 2,
                ProductName = "Sữa uống NuVi Trái Cây Nhiệt Đới hộp 180ml",
                CategoryId = 2,
                Price = 23000,
                QuantityInStock = 70,
                Description = "Sữa uống hương trái cây dành cho mọi người",
                Status = "Selling",
                CreatedDate = new DateTime(2023, 5, 1),
                UpdatedDate = new DateTime(2024, 5, 1),
                TotalRating = 0
            },

            new Product
            {
                ProductId = 6,
                AccountId = 3,
                ProductName = "Sữa đặc có đường Ông Thọ Đỏ 1284g",
                CategoryId = 3,
                Price = 74000,
                QuantityInStock = 30,
                Description = "Sữa đặc đã có mặt trên thị trường gần 40 năm qua",
                Status = "Selling",
                CreatedDate = new DateTime(2023, 5, 1),
                UpdatedDate = new DateTime(2024, 5, 1),
                TotalRating = 0
            },
        };

        public static List<Account> Accounts = new List<Account>()
        {
            new Account(Guid.Parse("130cc9cd-ee18-492c-b8a2-d0c16ef6a738"), "Admin", "admin@gmail.com", "1234", "Administrator"),
            new Account(Guid.Parse("f7744da2-1817-4539-b682-d55f33e61a90"), "Manager", "manager@gmail.com", "4321", "Manager"),
            new Account(Guid.Parse("8b203a18-63a5-40c9-9409-f8ccb3eba382"), "Staff", "staff@gmail.com", "0000", "Staff"),
            new Account(Guid.Parse("2fc530c2-eb0b-4626-81a8-3903726c8f1d"), "User 1", "user1@gmail.com", "1111", "Customer"),
            new Account(Guid.Parse("824bdc71-4244-4158-aa08-593afc5ac93d"), "User 2", "user2@gmail.com", "2222"  , "Customer"),
        };
    }
}

