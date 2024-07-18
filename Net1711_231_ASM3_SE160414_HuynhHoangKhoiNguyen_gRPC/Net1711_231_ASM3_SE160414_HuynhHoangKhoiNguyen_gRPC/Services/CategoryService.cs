using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using Net1711_231_ASM3_SE160414_HuynhHoangKhoiNguyen_gRPC.DTO;
using Net1711_231_ASM3_SE160414_HuynhHoangKhoiNguyen_gRPC.Protos;
using Net1711_231_ASM3_SE160414_HuynhHoangKhoiNguyen_gRPC.Repos;

namespace Net1711_231_ASM3_SE160414_HuynhHoangKhoiNguyen_gRPC.Services
{
    public class CategoryService : CategoryServiceGRPC.CategoryServiceGRPCBase
    {
        private readonly ICategoryRepo _categoryRepo;
        public CategoryService(ICategoryRepo categoryRepo)
        {
            _categoryRepo = categoryRepo;
        }

        public override Task<Empty> DeleteCategory(CategoryRequest request, ServerCallContext context)
        {
            _categoryRepo.DeleteCategory(request.CategoryId);
            Task<Empty> reply = Task.FromResult(new Empty());
            return reply;
        }

        public override Task<CategoryReply> AddCategory(CategoryAddRequest request, ServerCallContext context)
        {
            var category = _categoryRepo.AddCategory(new CategoryDTO.CreateCategoryRequest
            {
                CategoryName = request.CategoryName
            });

            CategoryReply reply = new CategoryReply();

            if (category != null)
            {
                reply = new CategoryReply
                {
                    CategoryId = category.CategoryId,
                    CategoryName = category.CategoryName
                };
            }

            return Task.FromResult(reply);
        }

        public override Task<CategoryReply> UpdateCategory(CategoryUpdateRequest request, ServerCallContext context)
        {
            var category = _categoryRepo.UpdateCategory(new CategoryDTO.UpdateCategoryRequest
            {
                CategoryId = request.CategoryId,
                CategoryName = request.CategoryName
            });

            CategoryReply reply = new CategoryReply();

            if (category != null)
            {
                reply = new CategoryReply
                {
                    CategoryId = category.CategoryId,
                    CategoryName = category.CategoryName
                };
            }

            return Task.FromResult(reply);
        }

        public override Task<CategoryList> GetAllCategories(Empty request, ServerCallContext context)
        {
            var categories = _categoryRepo.GetAllCategories();
            return Task.FromResult(categories);
        }

        public override Task<CategoryReply> GetCategoryById(CategoryRequest request, ServerCallContext context)
        {
            var category = _categoryRepo.GetCategoryById(request.CategoryId);
            CategoryReply reply = new CategoryReply();

            if (category != null)
            {
                reply = new CategoryReply
                {
                    CategoryId = category.CategoryId,
                    CategoryName = category.CategoryName
                };
            }

            return Task.FromResult(reply);
        }
    }
}
