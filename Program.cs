using ProductApi.Data;
using ProductApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

var _products = ProductData.GetProducts().ToList();

app.MapGet("/api/products", () =>
{
    return Results.Ok(_products);
});

app.MapGet("/api/products/{id}", (int id) =>
{
    var product = _products.FirstOrDefault(p => p.Id == id);
    if (product == null)
    {
        return Results.NotFound();
    }
    return Results.Ok(product);
});

app.MapPost("/api/products", (Product product) =>
{
    product.Id = _products.Any() ? _products.Max(p => p.Id) + 1 : 1;
    product.ModifiedDate = DateTime.UtcNow;
    _products.Add(product);

    return Results.Created($"/api/products/{product.Id}", product);
});

app.MapPut("/api/products/{id}", (int id, Product product) =>
{
    if (id != product.Id)
    {
        return Results.BadRequest();
    }

    var existingProduct = _products.FirstOrDefault(p => p.Id == id);
    if (existingProduct == null)
    {
        return Results.NotFound();
    }

    existingProduct.Name = product.Name;
    existingProduct.Price = product.Price;
    existingProduct.Description = product.Description;
    existingProduct.ImageUrl = product.ImageUrl;
    existingProduct.Discontinued = product.Discontinued;
    existingProduct.FixedPrice = product.FixedPrice;
    existingProduct.ModifiedDate = DateTime.UtcNow;

    return Results.NoContent();
});

app.MapDelete("/api/products/{id}", (int id) =>
{
    var product = _products.FirstOrDefault(p => p.Id == id);
    if (product == null)
    {
        return Results.NotFound();
    }

    _products.Remove(product);

    return Results.NoContent();
});


app.Run();
