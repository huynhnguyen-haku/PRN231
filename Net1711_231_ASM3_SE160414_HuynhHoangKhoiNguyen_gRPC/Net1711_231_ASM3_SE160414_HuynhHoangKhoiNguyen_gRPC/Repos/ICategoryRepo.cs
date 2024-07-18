using Net1711_231_ASM3_SE160414_HuynhHoangKhoiNguyen_gRPC.DTO;
using Net1711_231_ASM3_SE160414_HuynhHoangKhoiNguyen_gRPC.Models;
using Net1711_231_ASM3_SE160414_HuynhHoangKhoiNguyen_gRPC.Protos;

namespace Net1711_231_ASM3_SE160414_HuynhHoangKhoiNguyen_gRPC.Repos
{
    public interface ICategoryRepo
    {
        CategoryList GetAllCategories();
        Category GetCategoryById(int id);
        Category AddCategory(CategoryDTO.CreateCategoryRequest category);
        Category UpdateCategory(CategoryDTO.UpdateCategoryRequest category);
        void DeleteCategory(int id);
    }
}
