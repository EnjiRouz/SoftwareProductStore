using SoftwareProductStore.Domain.Core;

namespace SoftwareProductStore.Services.Interfaces
{
    public interface IOrder
    {
        /// <summary>
        ///Размещение заказа определенного продукта
        /// </summary>
        /// <param name="product"> выбранный продукт </param>
        void MakeOrder(Product product);
    }
}