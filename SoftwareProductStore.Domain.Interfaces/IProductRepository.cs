using System;
using System.Collections.Generic;
using SoftwareProductStore.Domain.Core;

namespace SoftwareProductStore.Domain.Interfaces
{
    public interface IProductRepository: IDisposable
    {
        /// <summary>
        /// Получение списка доступных к продаже продуктов
        /// </summary>
        /// <returns> список доступных продуктов</returns>
        IEnumerable<Product> GetProductList();
        
        /// <summary>
        /// Получение конкретного продукта по его уникальному идентификатору
        /// </summary>
        /// <param name="id"> идентификатор продукта </param>
        /// <returns> запрашиваемый продукт </returns>
        Product GetProductById(int id);
        
        /// <summary>
        /// Создать новый продукт к продаже
        /// </summary>
        /// <param name="product"> новый продукт </param>
        void CreateProduct(Product product);
        
        /// <summary>
        /// Изменить существующий продукт
        /// </summary>
        /// <param name="product"> изменённый продукт </param>
        void UpdateProduct(Product product);
        
        /// <summary>
        /// Удалить существующий продукт по его уникальному идентификатору
        /// </summary>
        /// <param name="id"> идентификатор продукта </param>
        void DeleteProductWithId(int id);
        
        /// <summary>
        /// Сохранить информацию о текущем редактируемом продукте
        /// </summary>
        void SaveCurrentProduct();
    }
}