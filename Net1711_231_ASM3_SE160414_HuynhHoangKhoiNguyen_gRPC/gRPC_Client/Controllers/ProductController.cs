using Google.Protobuf.WellKnownTypes;
using Grpc.Net.Client;
using gRPC_Client.Models;
using gRPC_Client.Protos;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace gRPC_Client.Controllers
{
    public class ProductController : Controller
    {
        private readonly ILogger<ProductController> _logger;

        public ProductController(ILogger<ProductController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<ResponseData> Save(RequestData.RequestDataProduct data)
        {
            try
            {
                var httpHandler = new HttpClientHandler();
                httpHandler.ServerCertificateCustomValidationCallback = HttpClientHandler.DangerousAcceptAnyServerCertificateValidator;
                var channel = GrpcChannel.ForAddress("https://localhost:7227", new GrpcChannelOptions { HttpHandler = httpHandler });
                var client = new gRPC_Client.Protos.ProductServiceGRPC.ProductServiceGRPCClient(channel);

                switch (data.httpMethod)
                {
                    case "POST":
                        client.AddProduct(new ProductAddRequest
                        {
                            AccountId = data.AccountId,
                            CategoryId = data.CategoryId,
                            ProductName = data.ProductName,
                            Price = data.Price,
                            QuantityInStock = data.QuantityInStock,
                            Description = data.Description,
                            Status = data.Status,
                            CreatedDate = data.CreatedDate,
                            UpdatedDate = data.UpdatedDate,
                            TotalRating = data.TotalRating
                        });
                        break;
                    case "PUT":
                        client.UpdateProduct(new ProductUpdateRequest
                        {
                            ProductId = data.ProductId,
                            AccountId = data.AccountId,
                            CategoryId = data.CategoryId,
                            ProductName = data.ProductName,
                            Price = data.Price,
                            QuantityInStock = data.QuantityInStock,
                            Description = data.Description,
                            Status = data.Status,
                            CreatedDate = data.CreatedDate,
                            UpdatedDate = data.UpdatedDate,
                            TotalRating = data.TotalRating
                        });
                        break;
                }

                return new ResponseData
                {
                    Message = "Data has been saved",
                    Status = 200
                };
            }
            catch (Exception ex)
            {
                return new ResponseData
                {
                    Message = "Action fail",
                    Status = -1
                };
            }
        }

        [HttpGet]
        public async Task<List<ProductReply>> GetAll()
        {
            var httpHandler = new HttpClientHandler();
            httpHandler.ServerCertificateCustomValidationCallback = HttpClientHandler.DangerousAcceptAnyServerCertificateValidator;
            var channel = GrpcChannel.ForAddress("https://localhost:7227", new GrpcChannelOptions { HttpHandler = httpHandler }); 
             var client = new gRPC_Client.Protos.ProductServiceGRPC.ProductServiceGRPCClient(channel);

            ProductList products = new ProductList();

            try
            {

            products = client.GetAllProducts(new Empty());
            }
            catch(Exception e)
            {
                
            }
            
            List<ProductReply> productList = new List<ProductReply>();
            productList.AddRange(products.Products);

            return productList;
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
            var client = new gRPC_Client.Protos.ProductServiceGRPC.ProductServiceGRPCClient(channel);

            ProductReply product = client.GetProductById(new ProductRequest { ProductId = id });
            return PartialView("Detail", product);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id)
        {
            var httpHandler = new HttpClientHandler();
            httpHandler.ServerCertificateCustomValidationCallback = HttpClientHandler.DangerousAcceptAnyServerCertificateValidator;
            var channel = GrpcChannel.ForAddress("https://localhost:7227", new GrpcChannelOptions { HttpHandler = httpHandler });
            var client = new gRPC_Client.Protos.ProductServiceGRPC.ProductServiceGRPCClient(channel);

            ProductReply product = client.GetProductById(new ProductRequest { ProductId = id });
            return PartialView("Edit", product);
        }

        [HttpDelete]
        public async Task<ResponseData> Delete(int id)
        {
            try
            {
                var httpHandler = new HttpClientHandler();
                httpHandler.ServerCertificateCustomValidationCallback = HttpClientHandler.DangerousAcceptAnyServerCertificateValidator;
                var channel = GrpcChannel.ForAddress("https://localhost:7227", new GrpcChannelOptions { HttpHandler = httpHandler });
                var client = new gRPC_Client.Protos.ProductServiceGRPC.ProductServiceGRPCClient(channel);

                client.DeleteProduct(new ProductRequest { ProductId = id });
                return new ResponseData()
                {
                    Message = "Success",
                    Status = 200
                };
            }
            catch (Exception ex)
            {
                return new ResponseData()
                {
                    Message = "Fail",
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
