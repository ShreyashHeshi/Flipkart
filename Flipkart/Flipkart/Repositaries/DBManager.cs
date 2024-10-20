using Flipkart.Models;
using Microsoft.AspNetCore.Connections;
using Microsoft.AspNetCore.Identity;

namespace Flipkart.Repositaries
{
    public class DBManager:IDBManager
    {
        public void Delete(int id)
        {
            using (var context = new EStoreCollectionContext())
            {
                
                context.Products.Remove(context.Products.Find(id));
                context.SaveChanges();
            }
        }

        public List<Product> GetAll()
        {
            //Deterministic Finaliation
            using (var context = new EStoreCollectionContext())
            {
                //LINQ
                var products = from pro
                             in context.Products
                               select pro;
                return products.ToList<Product>();
            }
        }

        public Product GetById(int id)
        {
            using (var context = new EStoreCollectionContext())
            {
                var pro = context.Products.Find(id);
                return pro;

                
            }
                
        }

        public void Insert(Product pro)
        {
            using (var context = new EStoreCollectionContext())
            {
                context.Products.Add(pro);
                context.SaveChanges();
            }
        }

        public void Update(Product pro)
        {
            using (var context = new EStoreCollectionContext())
            {
                var Proud = context.Products.Find(pro.Id);
                Proud.Title = pro.Title;
                Proud.Description = pro.Description;
                Proud.UnitPrice = pro.UnitPrice;
                Proud.Imageurl = pro.Imageurl;
                Proud.Quantity = pro.Quantity;
                context.SaveChanges();
            }
        }
    }
}
