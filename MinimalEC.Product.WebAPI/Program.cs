using MinimalEC.Product.WebAPI.Service;

var builder = WebApplication.CreateBuilder(args);

builder.AddServiceDefaults();

builder.Services.AddOpenApi();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.MapDefaultEndpoints();

var productService = new ProductService();

app.MapGet("/products", () =>
{
    return productService.GetAllProducts();
});

app.MapGet("/products/{id:int}", (int id) =>
{
    var product = productService.GetProductById(id);
    if (product == null)
    {
        return Results.NotFound(new { Message = $"Product with ID: {id} not found." });
    }
    return Results.Ok(product);
});

app.Run();
