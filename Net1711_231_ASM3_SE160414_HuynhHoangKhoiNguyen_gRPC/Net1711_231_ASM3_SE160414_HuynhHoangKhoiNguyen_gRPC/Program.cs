using Net1711_231_ASM3_SE160414_HuynhHoangKhoiNguyen_gRPC.Repos;
using Net1711_231_ASM3_SE160414_HuynhHoangKhoiNguyen_gRPC.Services;


var builder = WebApplication.CreateBuilder(args);

// Additional configuration is required to successfully run gRPC on macOS.
// For instructions on how to configure Kestrel and gRPC clients on macOS, visit https://go.microsoft.com/fwlink/?linkid=2099682

// Add services to the container.
builder.Services.AddGrpc(o =>
{
    o.EnableDetailedErrors = true;
});
builder.Services.AddSingleton<ICategoryRepo, CategoryRepo>();
builder.Services.AddSingleton<IProductRepo, ProductRepo>();
var app = builder.Build();

// Configure the HTTP request pipeline.
app.MapGrpcService<CategoryService>();
app.MapGrpcService<ProductService>();

app.MapGet("/", () => "Communication with gRPC endpoints must be made through a gRPC client. To learn how to create a client, visit: https://go.microsoft.com/fwlink/?linkid=2086909");

app.Run();
