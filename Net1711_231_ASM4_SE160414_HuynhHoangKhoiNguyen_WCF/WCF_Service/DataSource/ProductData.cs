using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WCF_Service.Models;

namespace WCF_Service.DataSource
{
    public class ProductData
    {
        public static List<Product> Products = new List<Product>()
        {
            new Product{ProductId = 1, CategoryId = 1, Name = "Sữa bột Ensure Gold", Price = 200000, Quantity = 10, Description = "Sữa bột dinh dưỡng", ImageUrl = " ", TotalRating = 5, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now, Status = "Active"},

            new Product{ProductId = 2, CategoryId = 2, Name = "Sữa tươi Vinamilk", Price = 25000, Quantity = 20, Description = "Sữa tươi nguyên chất từ Vinamilk", ImageUrl = " ", TotalRating = 4, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now, Status = "Active"},
            new Product{ProductId = 3, CategoryId = 2, Name = "Sữa tươi TH True Milk", Price = 27000, Quantity = 30, Description = "Sữa tươi nguyên chất từ TH True Milk", ImageUrl = " ", TotalRating = 5, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now, Status = "Active"},
            new Product{ProductId = 4, CategoryId = 2, Name = "Sữa tươi Mộc Châu", Price = 26000, Quantity = 25, Description = "Sữa tươi nguyên chất từ Mộc Châu", ImageUrl = " ", TotalRating = 4, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now, Status = "Active"},

            new Product{ProductId = 5, CategoryId = 3, Name = "Sữa đặc Alaska", Price = 35000, Quantity = 15, Description = "Sữa đặc nguyên kem từ Alaska", ImageUrl = " ", TotalRating = 3, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now, Status = "Active"},
            new Product{ProductId = 6, CategoryId = 3, Name = "Sữa đặc Ông Thọ", Price = 30000, Quantity = 20, Description = "Sữa đặc Ông Thọ", ImageUrl = " ", TotalRating = 4, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now, Status = "Active"},
            new Product{ProductId = 7, CategoryId = 3, Name = "Sữa đặc Ngôi Sao Phương Nam", Price = 32000, Quantity = 18, Description = "Sữa đặc Ngôi Sao Phương Nam", ImageUrl = " ", TotalRating = 5, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now, Status = "Active"}
        };
    }
}
