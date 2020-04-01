using System;
using System.Collections.Generic;
using SoftwareProductStore.Domain.Core;

namespace SoftwareProductStore.Domain.Interfaces
{
    public interface IProductRepository: IDisposable
    {
        IEnumerable<Product> GetProductList();
        Product GetProductById(int id);
        void CreateProduct(Product item);
        void UpdateProduct(Product item);
        void DeleteProductWithId(int id);
        void SaveCurrentProduct();
    }
}