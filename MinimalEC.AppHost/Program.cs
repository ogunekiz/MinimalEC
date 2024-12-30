using Projects;

var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<MinimalEC_Category_WebAPI>("category-webapi");
builder.AddProject<MinimalEC_Product_WebAPI>("product-webapi");
builder.AddProject<MinimalEC_Gateway_WebAPI>("gateway-webapi");

builder.Build().Run();
