using ProductApi.Models;

namespace ProductApi.Data
{
    public static class ProductData
    {
        public static List<Product> GetProducts()
        {
            return new List<Product>
            {
                new Product {
                    Id = 1,
                    Name = "Laptop",
                    Price = 1200.50m,
                    Description = "A high-end laptop for all your needs.",
                    ImageUrl = "https://images.unsplash.com/photo-1517336714731-489689fd1ca8?w=500&h=500&fit=crop",
                    Discontinued = false,
                    FixedPrice = false,
                    ModifiedDate = DateTime.UtcNow
                },
                new Product {
                    Id = 2,
                    Name = "Keyboard",
                    Price = 75.00m,
                    Description = "A mechanical keyboard with RGB lighting.",
                    ImageUrl = "https://images.unsplash.com/photo-1587829191301-623ac7e21f5b?w=500&h=500&fit=crop",
                    Discontinued = false,
                    FixedPrice = true,
                    ModifiedDate = DateTime.UtcNow
                },
                new Product {
                    Id = 3,
                    Name = "Mouse",
                    Price = 25.99m,
                    Description = "An ergonomic mouse.",
                    ImageUrl = "https://images.unsplash.com/photo-1527814050087-3793815479db?w=500&h=500&fit=crop",
                    Discontinued = true,
                    FixedPrice = true,
                    ModifiedDate = DateTime.UtcNow.AddDays(-10)
                },
                new Product {
                    Id = 4,
                    Name = "Monitor",
                    Price = 299.99m,
                    Description = "27-inch 4K UHD monitor with HDR support.",
                    ImageUrl = "https://images.unsplash.com/photo-1527721471640-3c679e0aadd3?w=500&h=500&fit=crop",
                    Discontinued = false,
                    FixedPrice = false,
                    ModifiedDate = DateTime.UtcNow
                },
                new Product {
                    Id = 5,
                    Name = "Headphones",
                    Price = 149.99m,
                    Description = "Wireless noise-cancelling headphones with 30-hour battery life.",
                    ImageUrl = "https://images.unsplash.com/photo-1505740420928-5e560c06d30e?w=500&h=500&fit=crop",
                    Discontinued = false,
                    FixedPrice = true,
                    ModifiedDate = DateTime.UtcNow
                },
                new Product {
                    Id = 6,
                    Name = "Webcam",
                    Price = 89.99m,
                    Description = "1080p HD webcam with built-in microphone.",
                    ImageUrl = "https://images.unsplash.com/photo-1587984622291-43ba1818e32f?w=500&h=500&fit=crop",
                    Discontinued = false,
                    FixedPrice = false,
                    ModifiedDate = DateTime.UtcNow.AddDays(-5)
                },
                new Product {
                    Id = 7,
                    Name = "USB Hub",
                    Price = 39.99m,
                    Description = "7-port USB 3.0 hub with individual switches.",
                    ImageUrl = "https://images.unsplash.com/photo-1597872200969-2b65d56bd16b?w=500&h=500&fit=crop",
                    Discontinued = false,
                    FixedPrice = true,
                    ModifiedDate = DateTime.UtcNow.AddDays(-3)
                },
                new Product {
                    Id = 8,
                    Name = "Desk Lamp",
                    Price = 45.00m,
                    Description = "LED desk lamp with adjustable brightness and color temperature.",
                    ImageUrl = "https://images.unsplash.com/photo-1565636192335-14c46fa1120d?w=500&h=500&fit=crop",
                    Discontinued = false,
                    FixedPrice = false,
                    ModifiedDate = DateTime.UtcNow
                },
                new Product {
                    Id = 9,
                    Name = "External SSD",
                    Price = 129.99m,
                    Description = "1TB portable SSD with USB-C connection for fast file transfers.",
                    ImageUrl = "https://images.unsplash.com/photo-1597872200969-2b65d56bd16b?w=500&h=500&fit=crop",
                    Discontinued = false,
                    FixedPrice = true,
                    ModifiedDate = DateTime.UtcNow
                },
                new Product {
                    Id = 10,
                    Name = "Mechanical Switch",
                    Price = 12.99m,
                    Description = "Individual mechanical keyboard switch for replacement.",
                    ImageUrl = "https://images.unsplash.com/photo-1587829191301-623ac7e21f5b?w=500&h=500&fit=crop",
                    Discontinued = false,
                    FixedPrice = true,
                    ModifiedDate = DateTime.UtcNow
                },
                new Product {
                    Id = 11,
                    Name = "Phone Stand",
                    Price = 19.99m,
                    Description = "Adjustable phone stand for desk and streaming.",
                    ImageUrl = "https://images.unsplash.com/photo-1556656793-08538906a9f8?w=500&h=500&fit=crop",
                    Discontinued = false,
                    FixedPrice = false,
                    ModifiedDate = DateTime.UtcNow
                },
                new Product {
                    Id = 12,
                    Name = "Cable Organizer",
                    Price = 14.99m,
                    Description = "Set of 5 silicone cable organizers in various sizes.",
                    ImageUrl = "https://images.unsplash.com/photo-1597872200969-2b65d56bd16b?w=500&h=500&fit=crop",
                    Discontinued = false,
                    FixedPrice = true,
                    ModifiedDate = DateTime.UtcNow
                },
                new Product {
                    Id = 13,
                    Name = "Portable Charger",
                    Price = 59.99m,
                    Description = "20000mAh power bank with dual USB and USB-C ports.",
                    ImageUrl = "https://images.unsplash.com/photo-1609091839311-d5365f9ff1c5?w=500&h=500&fit=crop",
                    Discontinued = false,
                    FixedPrice = false,
                    ModifiedDate = DateTime.UtcNow
                },
                new Product {
                    Id = 14,
                    Name = "Wireless Charger",
                    Price = 34.99m,
                    Description = "Fast wireless charging pad compatible with all Qi devices.",
                    ImageUrl = "https://images.unsplash.com/photo-1609091839311-d5365f9ff1c5?w=500&h=500&fit=crop",
                    Discontinued = false,
                    FixedPrice = true,
                    ModifiedDate = DateTime.UtcNow
                },
                new Product {
                    Id = 15,
                    Name = "Screen Protector",
                    Price = 9.99m,
                    Description = "Tempered glass screen protector for 6-inch smartphones.",
                    ImageUrl = "https://images.unsplash.com/photo-1511707267537-b85faf00021e?w=500&h=500&fit=crop",
                    Discontinued = false,
                    FixedPrice = true,
                    ModifiedDate = DateTime.UtcNow
                },
                new Product {
                    Id = 16,
                    Name = "Phone Case",
                    Price = 24.99m,
                    Description = "Rugged protective phone case with shock absorption.",
                    ImageUrl = "https://images.unsplash.com/photo-1511707267537-b85faf00021e?w=500&h=500&fit=crop",
                    Discontinued = false,
                    FixedPrice = false,
                    ModifiedDate = DateTime.UtcNow
                },
                new Product {
                    Id = 17,
                    Name = "Laptop Stand",
                    Price = 49.99m,
                    Description = "Adjustable aluminum laptop stand for ergonomic viewing.",
                    ImageUrl = "https://images.unsplash.com/photo-1517336714731-489689fd1ca8?w=500&h=500&fit=crop",
                    Discontinued = false,
                    FixedPrice = true,
                    ModifiedDate = DateTime.UtcNow
                },
                new Product {
                    Id = 18,
                    Name = "Wireless Mouse Pad",
                    Price = 79.99m,
                    Description = "Large wireless charging mouse pad that charges your mouse.",
                    ImageUrl = "https://images.unsplash.com/photo-1527814050087-3793815479db?w=500&h=500&fit=crop",
                    Discontinued = false,
                    FixedPrice = false,
                    ModifiedDate = DateTime.UtcNow
                },
                new Product {
                    Id = 19,
                    Name = "Cooling Pad",
                    Price = 44.99m,
                    Description = "Laptop cooling pad with 5 quiet fans and USB power.",
                    ImageUrl = "https://images.unsplash.com/photo-1517336714731-489689fd1ca8?w=500&h=500&fit=crop",
                    Discontinued = false,
                    FixedPrice = true,
                    ModifiedDate = DateTime.UtcNow
                },
                new Product {
                    Id = 20,
                    Name = "Docking Station",
                    Price = 199.99m,
                    Description = "USB-C docking station with dual 4K display support.",
                    ImageUrl = "https://images.unsplash.com/photo-1597872200969-2b65d56bd16b?w=500&h=500&fit=crop",
                    Discontinued = false,
                    FixedPrice = false,
                    ModifiedDate = DateTime.UtcNow
                },
                new Product {
                    Id = 21,
                    Name = "Mechanical Keyboard Pro",
                    Price = 189.99m,
                    Description = "Full-size mechanical keyboard with programmable keys.",
                    ImageUrl = "https://images.unsplash.com/photo-1587829191301-623ac7e21f5b?w=500&h=500&fit=crop",
                    Discontinued = false,
                    FixedPrice = true,
                    ModifiedDate = DateTime.UtcNow
                },
                new Product {
                    Id = 22,
                    Name = "Gaming Mouse",
                    Price = 69.99m,
                    Description = "High-precision gaming mouse with 16000 DPI sensor.",
                    ImageUrl = "https://images.unsplash.com/photo-1527814050087-3793815479db?w=500&h=500&fit=crop",
                    Discontinued = false,
                    FixedPrice = false,
                    ModifiedDate = DateTime.UtcNow
                },
                new Product {
                    Id = 23,
                    Name = "USB-C Cable",
                    Price = 14.99m,
                    Description = "6ft braided USB-C cable with fast charging support.",
                    ImageUrl = "https://images.unsplash.com/photo-1597872200969-2b65d56bd16b?w=500&h=500&fit=crop",
                    Discontinued = false,
                    FixedPrice = true,
                    ModifiedDate = DateTime.UtcNow
                },
                new Product {
                    Id = 24,
                    Name = "HDMI Cable",
                    Price = 9.99m,
                    Description = "4K HDMI 2.1 cable with gold-plated connectors.",
                    ImageUrl = "https://images.unsplash.com/photo-1597872200969-2b65d56bd16b?w=500&h=500&fit=crop",
                    Discontinued = false,
                    FixedPrice = true,
                    ModifiedDate = DateTime.UtcNow
                },
                new Product {
                    Id = 25,
                    Name = "DisplayPort Cable",
                    Price = 12.99m,
                    Description = "8K DisplayPort 1.4 cable for high-resolution displays.",
                    ImageUrl = "https://images.unsplash.com/photo-1597872200969-2b65d56bd16b?w=500&h=500&fit=crop",
                    Discontinued = false,
                    FixedPrice = false,
                    ModifiedDate = DateTime.UtcNow
                },
                new Product {
                    Id = 26,
                    Name = "Power Bank 65W",
                    Price = 99.99m,
                    Description = "Fast-charging 65W power bank with multiple ports.",
                    ImageUrl = "https://images.unsplash.com/photo-1609091839311-d5365f9ff1c5?w=500&h=500&fit=crop",
                    Discontinued = false,
                    FixedPrice = true,
                    ModifiedDate = DateTime.UtcNow
                },
                new Product {
                    Id = 27,
                    Name = "USB Hub Pro",
                    Price = 79.99m,
                    Description = "USB-C hub with 10 ports including Ethernet and SD card reader.",
                    ImageUrl = "https://images.unsplash.com/photo-1597872200969-2b65d56bd16b?w=500&h=500&fit=crop",
                    Discontinued = false,
                    FixedPrice = false,
                    ModifiedDate = DateTime.UtcNow
                },
                new Product {
                    Id = 28,
                    Name = "Microphone Stand",
                    Price = 29.99m,
                    Description = "Adjustable microphone boom arm with shock mount.",
                    ImageUrl = "https://images.unsplash.com/photo-1505740420928-5e560c06d30e?w=500&h=500&fit=crop",
                    Discontinued = false,
                    FixedPrice = true,
                    ModifiedDate = DateTime.UtcNow
                },
                new Product {
                    Id = 29,
                    Name = "Studio Microphone",
                    Price = 249.99m,
                    Description = "Condenser microphone with XLR connector for streaming.",
                    ImageUrl = "https://images.unsplash.com/photo-1505740420928-5e560c06d30e?w=500&h=500&fit=crop",
                    Discontinued = false,
                    FixedPrice = false,
                    ModifiedDate = DateTime.UtcNow
                },
                new Product {
                    Id = 30,
                    Name = "Pop Filter",
                    Price = 19.99m,
                    Description = "Double-layer pop filter for cleaner audio recording.",
                    ImageUrl = "https://images.unsplash.com/photo-1505740420928-5e560c06d30e?w=500&h=500&fit=crop",
                    Discontinued = false,
                    FixedPrice = true,
                    ModifiedDate = DateTime.UtcNow
                },
                new Product {
                    Id = 31,
                    Name = "Webcam 4K",
                    Price = 179.99m,
                    Description = "4K UHD webcam with autofocus and low-light correction.",
                    ImageUrl = "https://images.unsplash.com/photo-1587984622291-43ba1818e32f?w=500&h=500&fit=crop",
                    Discontinued = false,
                    FixedPrice = false,
                    ModifiedDate = DateTime.UtcNow
                },
                new Product {
                    Id = 32,
                    Name = "Ring Light",
                    Price = 59.99m,
                    Description = "10-inch LED ring light with adjustable color temperature.",
                    ImageUrl = "https://images.unsplash.com/photo-1565636192335-14c46fa1120d?w=500&h=500&fit=crop",
                    Discontinued = false,
                    FixedPrice = true,
                    ModifiedDate = DateTime.UtcNow
                },
                new Product {
                    Id = 33,
                    Name = "Monitor Light Bar",
                    Price = 69.99m,
                    Description = "Smart monitor light bar that reduces eye strain.",
                    ImageUrl = "https://images.unsplash.com/photo-1565636192335-14c46fa1120d?w=500&h=500&fit=crop",
                    Discontinued = false,
                    FixedPrice = false,
                    ModifiedDate = DateTime.UtcNow
                },
                new Product {
                    Id = 34,
                    Name = "RGB Hub Controller",
                    Price = 39.99m,
                    Description = "Wireless controller for RGB lighting accessories.",
                    ImageUrl = "https://images.unsplash.com/photo-1587829191301-623ac7e21f5b?w=500&h=500&fit=crop",
                    Discontinued = false,
                    FixedPrice = true,
                    ModifiedDate = DateTime.UtcNow
                },
                new Product {
                    Id = 35,
                    Name = "Desk Mount",
                    Price = 29.99m,
                    Description = "Adjustable dual monitor mount for desk setup.",
                    ImageUrl = "https://images.unsplash.com/photo-1527721471640-3c679e0aadd3?w=500&h=500&fit=crop",
                    Discontinued = false,
                    FixedPrice = false,
                    ModifiedDate = DateTime.UtcNow
                },
                new Product {
                    Id = 36,
                    Name = "Chair Lumbar Support",
                    Price = 44.99m,
                    Description = "Ergonomic lumbar support cushion for office chairs.",
                    ImageUrl = "https://images.unsplash.com/photo-1558618666-fcd25c85cd64?w=500&h=500&fit=crop",
                    Discontinued = false,
                    FixedPrice = true,
                    ModifiedDate = DateTime.UtcNow
                },
                new Product {
                    Id = 37,
                    Name = "Desk Pad",
                    Price = 34.99m,
                    Description = "Large extended mouse pad and desk organizer.",
                    ImageUrl = "https://images.unsplash.com/photo-1527814050087-3793815479db?w=500&h=500&fit=crop",
                    Discontinued = false,
                    FixedPrice = false,
                    ModifiedDate = DateTime.UtcNow
                },
                new Product {
                    Id = 38,
                    Name = "Cable Management Kit",
                    Price = 24.99m,
                    Description = "Complete cable management system for clean desk setup.",
                    ImageUrl = "https://images.unsplash.com/photo-1597872200969-2b65d56bd16b?w=500&h=500&fit=crop",
                    Discontinued = false,
                    FixedPrice = true,
                    ModifiedDate = DateTime.UtcNow
                },
                new Product {
                    Id = 39,
                    Name = "Desk Fan",
                    Price = 39.99m,
                    Description = "Quiet desktop fan with multiple speed settings.",
                    ImageUrl = "https://images.unsplash.com/photo-1545269865-cbf461f8f9d0?w=500&h=500&fit=crop",
                    Discontinued = false,
                    FixedPrice = false,
                    ModifiedDate = DateTime.UtcNow
                },
                new Product {
                    Id = 40,
                    Name = "Humidifier",
                    Price = 49.99m,
                    Description = "Desktop humidifier with ultrasonic technology.",
                    ImageUrl = "https://images.unsplash.com/photo-1589519160732-57fc498494f8?w=500&h=500&fit=crop",
                    Discontinued = false,
                    FixedPrice = true,
                    ModifiedDate = DateTime.UtcNow
                },
                new Product {
                    Id = 41,
                    Name = "Air Purifier",
                    Price = 129.99m,
                    Description = "HEPA air purifier for small rooms and office spaces.",
                    ImageUrl = "https://images.unsplash.com/photo-1545269865-cbf461f8f9d0?w=500&h=500&fit=crop",
                    Discontinued = false,
                    FixedPrice = false,
                    ModifiedDate = DateTime.UtcNow
                },
                new Product {
                    Id = 42,
                    Name = "Smart Outlet",
                    Price = 19.99m,
                    Description = "WiFi-enabled smart power outlet with scheduling.",
                    ImageUrl = "https://images.unsplash.com/photo-1597872200969-2b65d56bd16b?w=500&h=500&fit=crop",
                    Discontinued = false,
                    FixedPrice = true,
                    ModifiedDate = DateTime.UtcNow
                },
                new Product {
                    Id = 43,
                    Name = "Power Strip",
                    Price = 29.99m,
                    Description = "Surge-protected power strip with 6 outlets and USB ports.",
                    ImageUrl = "https://images.unsplash.com/photo-1597872200969-2b65d56bd16b?w=500&h=500&fit=crop",
                    Discontinued = false,
                    FixedPrice = false,
                    ModifiedDate = DateTime.UtcNow
                },
                new Product {
                    Id = 44,
                    Name = "Uninterruptible Power Supply",
                    Price = 199.99m,
                    Description = "UPS backup power system with 8 outlets.",
                    ImageUrl = "https://images.unsplash.com/photo-1597872200969-2b65d56bd16b?w=500&h=500&fit=crop",
                    Discontinued = false,
                    FixedPrice = true,
                    ModifiedDate = DateTime.UtcNow
                },
                new Product {
                    Id = 45,
                    Name = "Laptop Bag",
                    Price = 79.99m,
                    Description = "Water-resistant laptop bag with multiple compartments.",
                    ImageUrl = "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=500&h=500&fit=crop",
                    Discontinued = false,
                    FixedPrice = false,
                    ModifiedDate = DateTime.UtcNow
                },
                new Product {
                    Id = 46,
                    Name = "Backpack",
                    Price = 99.99m,
                    Description = "Professional tech backpack with USB charging port.",
                    ImageUrl = "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=500&h=500&fit=crop",
                    Discontinued = false,
                    FixedPrice = true,
                    ModifiedDate = DateTime.UtcNow
                },
                new Product {
                    Id = 47,
                    Name = "Portable Desk Organizer",
                    Price = 34.99m,
                    Description = "Compact desk organizer with multiple storage slots.",
                    ImageUrl = "https://images.unsplash.com/photo-16115327361c1f8d3e2f1e3d1f1e3d1f?w=500&h=500&fit=crop",
                    Discontinued = false,
                    FixedPrice = false,
                    ModifiedDate = DateTime.UtcNow
                },
                new Product {
                    Id = 48,
                    Name = "File Organizer",
                    Price = 24.99m,
                    Description = "Metal desk file organizer with 3 slots.",
                    ImageUrl = "https://images.unsplash.com/photo-1611532736143-21e3a3f6c1b5?w=500&h=500&fit=crop",
                    Discontinued = false,
                    FixedPrice = true,
                    ModifiedDate = DateTime.UtcNow
                },
                new Product {
                    Id = 49,
                    Name = "Desk Pen Holder",
                    Price = 14.99m,
                    Description = "Rotating pen and pencil holder for desk.",
                    ImageUrl = "https://images.unsplash.com/photo-1611532736121-1e3e7a8b3e1e?w=500&h=500&fit=crop",
                    Discontinued = false,
                    FixedPrice = false,
                    ModifiedDate = DateTime.UtcNow
                },
                new Product {
                    Id = 50,
                    Name = "Document Holder",
                    Price = 19.99m,
                    Description = "Adjustable document holder for ergonomic viewing.",
                    ImageUrl = "https://images.unsplash.com/photo-1611532736987-7f9d4c5de1e2?w=500&h=500&fit=crop",
                    Discontinued = false,
                    FixedPrice = true,
                    ModifiedDate = DateTime.UtcNow
                },
                new Product {
                    Id = 51,
                    Name = "Bookshelf",
                    Price = 149.99m,
                    Description = "5-tier bookshelf with adjustable shelves.",
                    ImageUrl = "https://images.unsplash.com/photo-1546321318-c3a86503cbae?w=500&h=500&fit=crop",
                    Discontinued = false,
                    FixedPrice = false,
                    ModifiedDate = DateTime.UtcNow
                },
                new Product {
                    Id = 52,
                    Name = "Desk Organizer Drawer",
                    Price = 39.99m,
                    Description = "Under-desk organizer drawer with locks.",
                    ImageUrl = "https://images.unsplash.com/photo-1565182999555-2174d92f521e?w=500&h=500&fit=crop",
                    Discontinued = false,
                    FixedPrice = true,
                    ModifiedDate = DateTime.UtcNow
                },
                new Product {
                    Id = 53,
                    Name = "Wall-mounted Shelves",
                    Price = 79.99m,
                    Description = "Set of 3 floating wall-mounted shelves.",
                    ImageUrl = "https://images.unsplash.com/photo-1565182999555-2174d92f521e?w=500&h=500&fit=crop",
                    Discontinued = false,
                    FixedPrice = false,
                    ModifiedDate = DateTime.UtcNow
                },
                new Product {
                    Id = 54,
                    Name = "Corner Desk",
                    Price = 299.99m,
                    Description = "L-shaped corner desk with storage shelves.",
                    ImageUrl = "https://images.unsplash.com/photo-1555041469-a586c61ea9bc?w=500&h=500&fit=crop",
                    Discontinued = false,
                    FixedPrice = true,
                    ModifiedDate = DateTime.UtcNow
                },
                new Product {
                    Id = 55,
                    Name = "Office Chair",
                    Price = 249.99m,
                    Description = "Ergonomic office chair with lumbar support.",
                    ImageUrl = "https://images.unsplash.com/photo-1558618666-fcd25c85cd64?w=500&h=500&fit=crop",
                    Discontinued = false,
                    FixedPrice = false,
                    ModifiedDate = DateTime.UtcNow
                },
                new Product {
                    Id = 56,
                    Name = "Standing Desk Converter",
                    Price = 199.99m,
                    Description = "Adjustable standing desk converter for any desk.",
                    ImageUrl = "https://images.unsplash.com/photo-1555041469-a586c61ea9bc?w=500&h=500&fit=crop",
                    Discontinued = false,
                    FixedPrice = true,
                    ModifiedDate = DateTime.UtcNow
                },
                new Product {
                    Id = 57,
                    Name = "Mouse Pad Wrist Rest",
                    Price = 24.99m,
                    Description = "Ergonomic mouse pad with memory foam wrist rest.",
                    ImageUrl = "https://images.unsplash.com/photo-1527814050087-3793815479db?w=500&h=500&fit=crop",
                    Discontinued = false,
                    FixedPrice = false,
                    ModifiedDate = DateTime.UtcNow
                },
                new Product {
                    Id = 58,
                    Name = "Keyboard Wrist Rest",
                    Price = 29.99m,
                    Description = "Memory foam keyboard wrist rest for comfort.",
                    ImageUrl = "https://images.unsplash.com/photo-1587829191301-623ac7e21f5b?w=500&h=500&fit=crop",
                    Discontinued = false,
                    FixedPrice = true,
                    ModifiedDate = DateTime.UtcNow
                }
            };
        }
    }
}
