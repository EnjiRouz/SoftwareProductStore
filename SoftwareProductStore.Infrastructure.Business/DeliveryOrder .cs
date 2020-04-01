using SoftwareProductStore.Domain.Core;
using SoftwareProductStore.Services.Interfaces;

namespace SoftwareProductStore.Infrastructure.Business
{
    public class DeliveryOrder : IOrder
    {
        /// <summary>
        /// Размещение заказа на доставку определенного продукта
        /// </summary>
        /// <param name="product"> выбранный продукт </param>
        public void MakeOrder(Product product)
        {
            // далее должен быть написан код, срабатывающий при размещении заказа на доставку
        }
    }
}