using SoftwareProductStore.Domain.Core;
using SoftwareProductStore.Services.Interfaces;

namespace SoftwareProductStore.Infrastructure.Business
{
    public class OnlineCreditCardOrder : IOrder
    {
        /// <summary>
        /// Размещение заказа определенного продукта с возможностью оплаты картой онлайн
        /// </summary>
        /// <param name="product"> выбранный продукт </param>
        public void MakeOrder(Product product)
        {
            // далее должен быть написан код покупки при оплате по карте на сайте онлайн
        }
    }
}