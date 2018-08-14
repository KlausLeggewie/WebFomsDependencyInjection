using System.Collections.Generic;

namespace WebDependencyInjection.Repositories
{

    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
    }

    public class ProductRepository : IProductRepository
    {
        public List<Product> GetAllProducts()
        {
            return new List<Product>
            {
                new Product {ProductId = 1, ProductName = "Soap", Price = 1.29m},
                new Product {ProductId = 2, ProductName = "Hoover", Price = 255.00m},
                new Product {ProductId = 3, ProductName = "Pencil Sharpener", Price = 2.49m},
                new Product { ProductId = 4, ProductName = "Electric Shaver", Price = 49.95m},
                new Product { ProductId = 5, ProductName = "LED Flatscreen TV", Price = 249.95m}

            };
        }
    }
}