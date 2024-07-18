using Microsoft.AspNetCore.OData;
using Microsoft.AspNetCore.OData.Routing;
using Microsoft.OData.Edm;
using Microsoft.OData.ModelBuilder;
using Net1711_231_ASM1_SE160414_HuynhHoangKhoiNguyen_OData.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

IEdmModel GetEdmModel()
{
    var builder = new ODataConventionModelBuilder();
    builder.EntitySet<Category>("Category");
    builder.EntitySet<Product>("Product");
    return builder.GetEdmModel();
}

builder.Services.AddControllers().AddOData(options => options.AddRouteComponents("odata", GetEdmModel())
                                                             .Select()
                                                             .Filter()
                                                             .OrderBy()
                                                             .SetMaxTop(20)
                                                             .Count()
                                                             .Expand());
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseODataBatching();
app.UseRouting();

// Test middleware
app.Use((context, next) =>
{
    var endpoint = context.GetEndpoint();
    if (endpoint is null)
    {
        return next(context);
    }

    IEnumerable<string> templates;
    IODataRoutingMetadata metadata = endpoint.Metadata.GetMetadata<IODataRoutingMetadata>();

    if (metadata is not null)
    {
        templates = metadata.Template.GetTemplates();
    }

    return next(context);
});

app.UseAuthorization();

app.MapControllers();

app.Run();
