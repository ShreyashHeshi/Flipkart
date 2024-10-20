using Flipkart.Models;
namespace Flipkart.Repositaries
{
    public interface IDBManager
    {
        List<Product> GetAll();
        Product GetById(int id);
        void Insert(Product pro);
        void Update(Product pro);
        void Delete(int id);

    }
}
