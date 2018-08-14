using System.Collections.Generic;

namespace WebDependencyInjection.Repositories
{
    public interface IProductRepository
    {
        List<Product> GetAllProducts();
    }
}