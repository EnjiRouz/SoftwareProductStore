using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using SoftwareProductStore.Domain.Core;
using SoftwareProductStore.Domain.Interfaces;

namespace SoftwareProductStore.Infrastructure.Data
{
    public class ProductRepository: IProductRepository
    {
        private OrderContext dataBaseOrderContext;
        
        public ProductRepository()
        {
            this.dataBaseOrderContext = new OrderContext();
        }
 
        public IEnumerable<Product> GetProductList()
        {
            return dataBaseOrderContext.Products.ToList();
        }
 
        public Product GetProductById(int id)
        {
            return dataBaseOrderContext.Products.Find(id);
        }
 
        public void CreateProduct(Product product)
        {
            dataBaseOrderContext.Products.Add(product);
        }
 
        public void UpdateProduct(Product product)
        {
            dataBaseOrderContext.Entry(product).State = EntityState.Modified;
        }
 
        public void DeleteProductWithId(int id)
        {
            Product product = dataBaseOrderContext.Products.Find(id);
            if (product != null)
                dataBaseOrderContext.Products.Remove(product);
        }
 
        public void SaveCurrentProduct()
        {
            dataBaseOrderContext.SaveChanges();
        }
 
        private bool disposed = false;
 
        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    dataBaseOrderContext.Dispose();
                }
            }
            this.disposed = true;
        }
 
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
