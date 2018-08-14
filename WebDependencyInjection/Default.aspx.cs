using System.Collections.Generic;
using System.Web.UI;
using WebDependencyInjection.Repositories;

namespace WebDependencyInjection
{
    public partial class _Default : Page
    {
        private readonly IProductRepository _productRepository;

        public _Default(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public IEnumerable<Product> Select()
        {
            return _productRepository.GetAllProducts();
        }
    }
}