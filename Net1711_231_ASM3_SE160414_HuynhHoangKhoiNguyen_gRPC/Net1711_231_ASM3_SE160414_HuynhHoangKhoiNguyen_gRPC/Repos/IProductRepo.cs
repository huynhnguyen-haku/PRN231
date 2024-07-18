using Net1711_231_ASM3_SE160414_HuynhHoangKhoiNguyen_gRPC.DTO;
using Net1711_231_ASM3_SE160414_HuynhHoangKhoiNguyen_gRPC.Models;
using Net1711_231_ASM3_SE160414_HuynhHoangKhoiNguyen_gRPC.Protos;

namespace Net1711_231_ASM3_SE160414_HuynhHoangKhoiNguyen_gRPC.Repos
{
    public interface IProductRepo
    {
        ProductList GetAllProducts();
        Product GetProductById(int id);
        Product AddProduct(ProductDTO.CreateProductRequest product);
        Product UpdateProduct(ProductDTO.UpdateProductRequest product);
        void DeleteProduct(int id);

    }
}
