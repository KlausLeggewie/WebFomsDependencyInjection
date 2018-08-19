using System.Collections.Generic;
using System.Linq;
using System.Web.UI;
using System.Web.UI.WebControls;
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

        protected void lvProducts_OnItemCommand(object sender, ListViewCommandEventArgs e)
        {

            if (!int.TryParse(e.CommandArgument as string, out int productId))
                return;

            switch (e.CommandName)
            {
                case "Order":
                {
                    var product =
                        _productRepository.GetAllProducts().FirstOrDefault(p => p.ProductId == productId);
                    OrderProduct(product);
                    break;
                }
            }

        }

        private void OrderProduct(Product product)
        {
            if (product != null)
            {
                lbOrderMessage.Text = $"{product.ProductName} ordered";
            }
        }
    }
}