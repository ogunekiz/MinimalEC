using MinimalEC.Category.WebAPI.Service;

var builder = WebApplication.CreateBuilder(args);

builder.AddServiceDefaults();

builder.Services.AddOpenApi();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.MapDefaultEndpoints();

var categoryService = new CategoryService();

app.MapGet("/categories", () =>
{
    return categoryService.GetAllCategories();
});

app.MapGet("/categories/{id:int}", (int id) =>
{
    var category = categoryService.GetCategoryById(id);
    if (category == null)
    {
        return Results.NotFound(new { Message = $"Category with ID: {id} not found." });
    }
    return Results.Ok(category);
});

app.Run();
