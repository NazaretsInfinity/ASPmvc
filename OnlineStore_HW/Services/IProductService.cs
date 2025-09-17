using OnlineStore_HW.Models.Entities;

namespace OnlineStore_HW.Services
{
    public interface IProductService
    {
        List<Product> GetProducts();
        Product? GetProductById(int productId);
    }
}
