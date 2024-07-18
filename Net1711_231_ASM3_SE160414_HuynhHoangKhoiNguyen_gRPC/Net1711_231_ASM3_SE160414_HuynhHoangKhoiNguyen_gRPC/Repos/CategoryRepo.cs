using Net1711_231_ASM3_SE160414_HuynhHoangKhoiNguyen_gRPC.DTO;
using Net1711_231_ASM3_SE160414_HuynhHoangKhoiNguyen_gRPC.Models;
using Net1711_231_ASM3_SE160414_HuynhHoangKhoiNguyen_gRPC.Protos;

namespace Net1711_231_ASM3_SE160414_HuynhHoangKhoiNguyen_gRPC.Repos
{
    public class CategoryRepo : ICategoryRepo
    {
        public Category AddCategory(CategoryDTO.CreateCategoryRequest category)
        {
            int counter = MockDataInit.Categories.Max(o => o.CategoryId);
            Category newCategory = new Category
            {
                CategoryId = ++counter,
                CategoryName = category.CategoryName
            };
            MockDataInit.Categories.Add(newCategory);
            return newCategory;
        }

        public void DeleteCategory(int id)
        {
            var category = GetCategoryById(id);
            MockDataInit.Categories.Remove(category);
        }

        public CategoryList GetAllCategories()
        {
            CategoryList categoryList = new CategoryList();
            var query = MockDataInit.Categories.Select(x => new CategoryReply
            {
                CategoryId = x.CategoryId,
                CategoryName = x.CategoryName
            });
            categoryList.Categories.AddRange(query);
            return categoryList;
        }

        public Category GetCategoryById(int id)
        {
            var category = MockDataInit.Categories.FirstOrDefault(x => x.CategoryId == id);
            if (category == null)
            {
                return null;
            }
            return category;
        }

        public Category UpdateCategory(CategoryDTO.UpdateCategoryRequest category)
        {
            var existingCategory = GetCategoryById(category.CategoryId);
            if (existingCategory == null)
            {
                return null;
            }
            existingCategory.CategoryName = category.CategoryName;
            return existingCategory;
        }
    }
}
