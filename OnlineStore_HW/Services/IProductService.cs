using OnlineStore_HW.Models;

namespace OnlineStore_HW.Services
{
    public interface IProductService
    {
        List<Product> GetProducts();
        Product? GetProductById(int productId);
    }
}
