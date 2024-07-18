using Net1711_231_ASM3_SE160414_HuynhHoangKhoiNguyen_gRPC.DTO;
using Net1711_231_ASM3_SE160414_HuynhHoangKhoiNguyen_gRPC.Models;
using Net1711_231_ASM3_SE160414_HuynhHoangKhoiNguyen_gRPC.Protos;

namespace Net1711_231_ASM3_SE160414_HuynhHoangKhoiNguyen_gRPC.Repos
{
    public class ProductRepo : IProductRepo
    {
        public Product AddProduct(ProductDTO.CreateProductRequest product)
        {
            int counter = MockDataInit.Products.Max(od => od.ProductId);
            Product newProduct = new Product
            {
                ProductId = ++counter,
                AccountId = product.AccountId,
                CategoryId = product.CategoryId,
                ProductName = product.ProductName,
                Price = product.Price,
                QuantityInStock = product.QuantityInStock,
                Description = product.Description,
                Status = product.Status,
                CreatedDate = product.CreatedDate,
                UpdatedDate = product.UpdatedDate,
                TotalRating = product.TotalRating
            };
            MockDataInit.Products.Add(newProduct);
            return newProduct;
        }

        public void DeleteProduct(int id)
        {
            var product = GetProductById(id);
            MockDataInit.Products.Remove(product);
        }

        public ProductList GetAllProducts()
        {
            ProductList productList = new ProductList();
            var query = MockDataInit.Products.Select(x => new ProductReply
            {
                ProductId = x.ProductId,
                AccountId = x.AccountId,
                CategoryId = x.CategoryId,
                ProductName = x.ProductName,
                Price = x.Price,
                QuantityInStock = x.QuantityInStock,
                Description = x.Description,
                Status = x.Status,
                CreatedDate = x.CreatedDate,
                UpdatedDate = x.UpdatedDate,
                TotalRating = x.TotalRating
            });
            productList.Products.AddRange(query);
            return productList;
        }

        public Product GetProductById(int id)
        {
            var product = MockDataInit.Products.FirstOrDefault(x => x.ProductId == id);
            if(product == null)
            {
                throw new Exception("Product not found");
            }
            return product;
        }

        public Product UpdateProduct(ProductDTO.UpdateProductRequest product)
        {
            var existingProduct = GetProductById(product.ProductId);
            if(existingProduct == null)
            {
                throw new Exception("Product not found");
            }
            existingProduct.AccountId = product.AccountId;
            existingProduct.CategoryId = product.CategoryId;
            existingProduct.ProductName = product.ProductName;
            existingProduct.Price = product.Price;
            existingProduct.QuantityInStock = product.QuantityInStock;
            existingProduct.Description = product.Description;
            existingProduct.Status = product.Status;
            existingProduct.UpdatedDate = product.UpdatedDate;
            existingProduct.TotalRating = product.TotalRating;
            return existingProduct;
        }
    }
}
