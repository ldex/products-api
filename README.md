# Products API

A lightweight ASP.NET Core 10.0 REST API for managing products. Built with minimal APIs and designed for simplicity and performance.

## Features

- ✅ Get all products
- ✅ Get a specific product by ID
- ✅ Create new products
- ✅ Update existing products
- ✅ Delete products
- ✅ Built-in OpenAPI/Swagger documentation

## Prerequisites

- .NET 10.0 SDK or later
- Visual Studio Code or Visual Studio 2026+

## Getting Started

### 1. Clone the Repository

```bash
git clone https://github.com/ldex/products-api.git
cd products-api
```

### 2. Build the Project

```bash
dotnet build
```

### 3. Run the Application

```bash
dotnet run
```

The API will be available at:
- **HTTP**: `http://localhost:5088/api/products`

## API Endpoints

### Get All Products

```http
GET /api/products
```

**Query Parameters**:
- `sortBy` (string, optional) - Sort products by field: `name`, `price`, `id`, or `modifieddate`
- `order` (string, optional) - Sort order: `asc` (default) or `desc`

**Examples**:
```http
# Get all products sorted by name
GET /api/products?sortBy=name

# Get products sorted by price in descending order
GET /api/products?sortBy=price&order=desc

# Get products sorted by modification date (ascending)
GET /api/products?sortBy=modifieddate

# Get products sorted by ID in descending order
GET /api/products?sortBy=id&order=desc
```

**Response**: Returns a list of all products (optionally sorted).

### Get Product by ID

```http
GET /api/products/{id}
```

**Parameters**:
- `id` (integer) - The product ID

**Response**: Returns a single product or 404 Not Found.

### Create a Product

```http
POST /api/products
Content-Type: application/json

{
  "name": "Product Name",
  "price": 29.99,
  "description": "Product description",
  "imageUrl": "https://example.com/image.jpg",
  "discontinued": false,
  "fixedPrice": true
}
```

**Response**: Returns 201 Created with the created product and location header.

### Update a Product

```http
PUT /api/products/{id}
Content-Type: application/json

{
  "id": 1,
  "name": "Updated Product Name",
  "price": 39.99,
  "description": "Updated description",
  "imageUrl": "https://example.com/image.jpg",
  "discontinued": false,
  "fixedPrice": true
}
```

**Response**: Returns 204 No Content on success or 404 Not Found.

### Delete a Product

```http
DELETE /api/products/{id}
```

**Response**: Returns 204 No Content on success or 404 Not Found.

## Product Model

```csharp
{
  "id": 1,
  "name": "Product Name",
  "price": 29.99,
  "description": "Product description",
  "imageUrl": "https://example.com/image.jpg",
  "discontinued": false,
  "fixedPrice": true,
  "modifiedDate": "2025-12-17T10:30:00Z"
}
```

### Properties

| Property | Type | Description |
|----------|------|-------------|
| `id` | integer | Unique product identifier |
| `name` | string | Product name |
| `price` | decimal | Product price |
| `description` | string | Product description |
| `imageUrl` | string | URL to product image |
| `discontinued` | boolean | Whether the product is discontinued |
| `fixedPrice` | boolean | Whether the price is fixed |
| `modifiedDate` | datetime | Last modification timestamp |

## Configuration

### Development Settings

Configuration for development is managed in `appsettings.Development.json`:

```json
{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  }
}
```

### Production Settings

See `appsettings.json` for production configuration.

## OpenAPI/Swagger

When running in development mode, OpenAPI documentation is available at:

```
http://localhost:5088/openapi/v1.json
```

## Project Structure

```
products-api/
├── Models/
│   └── Product.cs           # Product model
├── Data/
│   └── ProductData.cs       # Sample data provider
├── Program.cs               # Application entry point and endpoint configuration
├── ProductApi.csproj        # Project file
├── appsettings.json         # Production settings
├── appsettings.Development.json  # Development settings
├── ProductApi.http          # REST client file (VS Code REST Client)
└── README.md                # This file
```


## SSL Certificate Issues

On first run, you may need to trust the development certificate:

```bash
dotnet dev-certs https --trust
```

## License

This project is licensed under the MIT License.

## Support

For issues and questions, please create an issue in the repository.
