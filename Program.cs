using ProductApi.Data;
using ProductApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

// Add CORS
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowLocalhost", policy =>
    {
        //policy.WithOrigins("http://localhost:5173", "http://localhost:3000", "http://localhost:8080")
        policy.AllowAnyOrigin()
              .AllowAnyMethod()
              .AllowAnyHeader();
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

// Use CORS
app.UseCors("AllowLocalhost");

var _products = ProductData.GetProducts().ToList();

app.MapGet("/api/products", (string? sortBy = null, string? order = "asc") =>
{
    var sorted = _products.AsEnumerable();
    var isDescending = order?.ToLower() == "desc";

    // Apply sorting
    if (!string.IsNullOrEmpty(sortBy))
    {
        sorted = sortBy.ToLower() switch
        {
            "name" => isDescending
                ? sorted.OrderByDescending(p => p.Name)
                : sorted.OrderBy(p => p.Name),

            "price" => isDescending
                ? sorted.OrderByDescending(p => p.Price)
                : sorted.OrderBy(p => p.Price),

            "id" => isDescending
                ? sorted.OrderByDescending(p => p.Id)
                : sorted.OrderBy(p => p.Id),

            "modifieddate" => isDescending
                ? sorted.OrderByDescending(p => p.ModifiedDate)
                : sorted.OrderBy(p => p.ModifiedDate),

            _ => sorted
        };
    }

    return Results.Ok(sorted.ToList());
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
