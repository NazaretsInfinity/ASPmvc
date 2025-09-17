using OnlineStore_HW.Models.Entities;

namespace OnlineStore_HW.Services.Implementations
{
    public class ProductService : IProductService
    {
        public Product? GetProductById(int productId)
        {
            foreach(Product product in GetProducts())
            {
                if(product.Id == productId)return product;
            }
            return null;
        }

        public List<Product> GetProducts() => new List<Product>()
        {
            new Product(){Id=1,Name="Bread",Price=25},
            new Product(){Id=2,Name="Milk",Description="Cow's juice",Price=30},
            new Product(){Id=3,Name="Tomatoes",Description="Expensive shit",Price=50}
        };
    }
}
