using Flipkart.Models;
namespace Flipkart.Service
{
    public interface IProductService
    {
        List<Product> GetAll();
        Product GetById(int id);
        bool Insert(Product pro);
        bool Update(Product pro);
        bool Delete(int id);
    }
}
