using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using Net1711_231_ASM3_SE160414_HuynhHoangKhoiNguyen_gRPC.DTO;
using Net1711_231_ASM3_SE160414_HuynhHoangKhoiNguyen_gRPC.Protos;
using Net1711_231_ASM3_SE160414_HuynhHoangKhoiNguyen_gRPC.Repos;

namespace Net1711_231_ASM3_SE160414_HuynhHoangKhoiNguyen_gRPC.Services
{
    public class ProductService : ProductServiceGRPC.ProductServiceGRPCBase
    {
        private readonly IProductRepo _productRepo;

        public ProductService(IProductRepo productRepo)
        {
            _productRepo = productRepo;
        }

        public override Task<ProductList> GetAllProducts(Empty request, ServerCallContext context)
        {
            var products = _productRepo.GetAllProducts();
            return Task.FromResult(products);
        }

        public override Task<ProductReply> GetProductById(ProductRequest request, ServerCallContext context)
        {
            var product = _productRepo.GetProductById(request.ProductId);
            var reply = new ProductReply();
            if (product != null)
            {
                reply = new ProductReply
                {
                    ProductId = product.ProductId,
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
            }
            return Task.FromResult(reply);
        }

        public override Task<ProductReply> AddProduct(ProductAddRequest request, ServerCallContext context)
        {
            var product = _productRepo.AddProduct(new ProductDTO.CreateProductRequest
            {
                AccountId = request.AccountId,
                CategoryId = request.CategoryId,
                ProductName = request.ProductName,
                Price = request.Price,
                QuantityInStock = request.QuantityInStock,
                Description = request.Description,
                Status = request.Status,
                CreatedDate = request.CreatedDate,
                UpdatedDate = request.UpdatedDate,
                TotalRating = request.TotalRating
            });

            ProductReply reply = new ProductReply();
            if (product != null)
            {
                reply = new ProductReply
                {
                    ProductId = product.ProductId,
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
            }
            return Task.FromResult(reply);
        }

        public override Task<ProductReply> UpdateProduct(ProductUpdateRequest request, ServerCallContext context)
        {
            var product = _productRepo.UpdateProduct(new ProductDTO.UpdateProductRequest
            {
                ProductId = request.ProductId,
                AccountId = request.AccountId,
                CategoryId = request.CategoryId,
                ProductName = request.ProductName,
                Price = request.Price,
                QuantityInStock = request.QuantityInStock,
                Description = request.Description,
                Status = request.Status,
                CreatedDate = request.CreatedDate,
                UpdatedDate = request.UpdatedDate,
                TotalRating = request.TotalRating
            });

            ProductReply reply = new ProductReply();
            if (product != null)
            {
                reply = new ProductReply
                {
                    ProductId = product.ProductId,
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
            }
            return Task.FromResult(reply);
        }

        public override Task<Empty> DeleteProduct(ProductRequest request, ServerCallContext context)
        {
            _productRepo.DeleteProduct(request.ProductId);
            return Task.FromResult(new Empty());
        }
    }
}
