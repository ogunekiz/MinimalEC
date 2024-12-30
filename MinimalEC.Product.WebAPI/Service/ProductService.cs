
namespace MinimalEC.Product.WebAPI.Service
{
    public class ProductService
    {
        private readonly List<Models.Product> _products;

        public ProductService()
        {
            _products = new List<Models.Product>
            {
            new() { Id = 1, Name = "Smartphone", Price = 699.99m, Stock = 90, CategoryId = 1 },
            new() { Id = 2, Name = "Laptop", Price = 1299.99m, Stock = 50, CategoryId = 1 },
            new() { Id = 3, Name = "Tablet", Price = 499.99m, Stock = 70, CategoryId = 1 },
            new() { Id = 4, Name = "Smartwatch", Price = 199.99m, Stock = 120, CategoryId = 1 },
            new() { Id = 5, Name = "Bluetooth Speaker", Price = 49.99m, Stock = 200, CategoryId = 1 },

            new() { Id = 6, Name = "Novel", Price = 14.99m, Stock = 150, CategoryId = 2 },
            new() { Id = 7, Name = "1984", Price = 19.99m, Stock = 120, CategoryId = 2 },
            new() { Id = 8, Name = "The Great Gatsby", Price = 12.99m, Stock = 130, CategoryId = 2 },
            new() { Id = 9, Name = "Moby Dick", Price = 18.99m, Stock = 100, CategoryId = 2 },
            new() { Id = 10, Name = "To Kill a Mockingbird", Price = 16.99m, Stock = 140, CategoryId = 2 },

            new() { Id = 11, Name = "T-Shirt", Price = 19.99m, Stock = 100, CategoryId = 3 },
            new() { Id = 12, Name = "Jeans", Price = 49.99m, Stock = 75, CategoryId = 3 },
            new() { Id = 13, Name = "Jacket", Price = 89.99m, Stock = 60, CategoryId = 3 },
            new() { Id = 14, Name = "Sneakers", Price = 69.99m, Stock = 80, CategoryId = 3 },
            new() { Id = 15, Name = "Socks", Price = 4.99m, Stock = 500, CategoryId = 3 },

            new() { Id = 16, Name = "Microwave Oven", Price = 89.99m, Stock = 125, CategoryId = 4 },
            new() { Id = 17, Name = "Blender", Price = 39.99m, Stock = 200, CategoryId = 4 },
            new() { Id = 18, Name = "Vacuum Cleaner", Price = 129.99m, Stock = 85, CategoryId = 4 },
            new() { Id = 19, Name = "Toaster", Price = 24.99m, Stock = 150, CategoryId = 4 },
            new() { Id = 20, Name = "Air Conditioner", Price = 299.99m, Stock = 50, CategoryId = 4 },

            new() { Id = 21, Name = "Lego Set", Price = 59.99m, Stock = 250, CategoryId = 5 },
            new() { Id = 22, Name = "Puzzle", Price = 19.99m, Stock = 300, CategoryId = 5 },
            new() { Id = 23, Name = "Doll", Price = 24.99m, Stock = 180, CategoryId = 5 },
            new() { Id = 24, Name = "Action Figure", Price = 34.99m, Stock = 150, CategoryId = 5 },
            new() { Id = 25, Name = "Toy Car", Price = 14.99m, Stock = 400, CategoryId = 5 }
            };
        }

        public List<Models.Product> GetAllProducts()
        {
            return _products;
        }

        public Models.Product? GetProductById(int id)
        {
            return _products.FirstOrDefault(p => p.Id == id);
        }

    }
}
