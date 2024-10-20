using Flipkart.Models;
using Flipkart.Repositaries;

namespace Flipkart.Service
{
    public class ProductServices : IProductService
    {
       // private DBManager _dbManager;   

        public ProductServices()
        {

        }
        public ProductServices(DBManager dbManager) {  }     
        public bool Delete(int id)
        {
            DBManager _dbManager = new DBManager();
            _dbManager.Delete(id);
            return true;
        }

        public List<Product> GetAll()
        {
            DBManager _dbManager = new DBManager();
            List<Product> products = _dbManager.GetAll();
            return products;
        }

        public Product GetById(int id)
        {
            DBManager _dbManager = new DBManager();
            Product pro= _dbManager.GetById(id);
            return pro;
        }

        public bool Insert(Product pro)
        {
            DBManager _dbManager = new DBManager();
            _dbManager.Insert(pro);
            return true;
        }

        public bool Update(Product pro)
        {
            DBManager _dbManager = new DBManager();
            _dbManager.Update(pro);
            return true;
        }
    }
}
