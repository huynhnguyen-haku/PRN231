using Google.Protobuf.WellKnownTypes;
using Grpc.Net.Client;
using gRPC_Client.Models;
using gRPC_Client.Protos;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace gRPC_Client.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ILogger<CategoryController> _logger;

        public CategoryController(ILogger<CategoryController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<ResponseData> Save(RequestData.RequestDataCategory data)
        {
            try
            {
                var httpHandler = new HttpClientHandler();
                httpHandler.ServerCertificateCustomValidationCallback = HttpClientHandler.DangerousAcceptAnyServerCertificateValidator;
                var channel = GrpcChannel.ForAddress("https://localhost:7227", new GrpcChannelOptions { HttpHandler = httpHandler });
                var client = new gRPC_Client.Protos.CategoryServiceGRPC.CategoryServiceGRPCClient(channel);

                switch (data.httpMethod)
                {
                    case "POST":
                        client.AddCategory(new CategoryAddRequest
                        {
                            CategoryName = data.CategoryName,
                        });
                        break;

                    case "PUT":
                        client.UpdateCategory(new CategoryUpdateRequest
                        {
                            CategoryId = data.CategoryId,
                            CategoryName = data.CategoryName,
                        });
                        break;
                }

                return new ResponseData()
                {
                    Message = "Sussecc",
                    Status = 200
                };
            }
            catch (Exception ex)
            {
                return new ResponseData()
                {
                    Message = "Action failed",
                    Status = -1
                };
            }
        }

        [HttpGet]
        public async Task<List<CategoryReply>> GetAll()
        {
            var httpHandler = new HttpClientHandler();
            httpHandler.ServerCertificateCustomValidationCallback = HttpClientHandler.DangerousAcceptAnyServerCertificateValidator;
            var channel = GrpcChannel.ForAddress("https://localhost:7227", new GrpcChannelOptions { HttpHandler = httpHandler });
            var client = new gRPC_Client.Protos.CategoryServiceGRPC.CategoryServiceGRPCClient(channel);

            CategoryList categories = client.GetAllCategories(new Empty());

            List<CategoryReply> categoryList = new List<CategoryReply>();
            categoryList.AddRange(categories.Categories);

            return categoryList;
        }

        [HttpGet]
        public IActionResult Add()
        {
            return PartialView("Add");
        }

        [HttpPost]
        public async Task<IActionResult> Detail(int id)
        {
            var httpHandler = new HttpClientHandler();
            httpHandler.ServerCertificateCustomValidationCallback = HttpClientHandler.DangerousAcceptAnyServerCertificateValidator;
            var channel = GrpcChannel.ForAddress("https://localhost:7227", new GrpcChannelOptions { HttpHandler = httpHandler });
            var client = new gRPC_Client.Protos.CategoryServiceGRPC.CategoryServiceGRPCClient(channel);

            CategoryReply category = client.GetCategoryById(new CategoryRequest { CategoryId = id });
            return PartialView("Detail", category);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id)
        {
            var httpHandler = new HttpClientHandler();
            httpHandler.ServerCertificateCustomValidationCallback = HttpClientHandler.DangerousAcceptAnyServerCertificateValidator;
            var channel = GrpcChannel.ForAddress("https://localhost:7227", new GrpcChannelOptions { HttpHandler = httpHandler });
            var client = new gRPC_Client.Protos.CategoryServiceGRPC.CategoryServiceGRPCClient(channel);

            CategoryReply category = client.GetCategoryById(new CategoryRequest { CategoryId = id });
            return PartialView("Edit", category);
        }

        [HttpDelete]
        public async Task<ResponseData> Delete(int id)
        {
            try
            {
                var httpHandler = new HttpClientHandler();
                httpHandler.ServerCertificateCustomValidationCallback = HttpClientHandler.DangerousAcceptAnyServerCertificateValidator;
                var channel = GrpcChannel.ForAddress("https://localhost:7227", new GrpcChannelOptions { HttpHandler = httpHandler });
                var client = new gRPC_Client.Protos.CategoryServiceGRPC.CategoryServiceGRPCClient(channel);

                client.DeleteCategory(new CategoryRequest { CategoryId = id });

                return new ResponseData()
                {
                    Message = "Sussecc",
                    Status = 200
                };
            }
            catch (Exception ex)
            {
                return new ResponseData()
                {
                    Message = "Action failed",
                    Status = -1
                };
            }
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
