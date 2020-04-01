using SoftwareProductStore.Domain.Core;
using SoftwareProductStore.Services.Interfaces;

namespace SoftwareProductStore.Infrastructure.Business
{
    public class DeliveryOrder : IOrder
    {
        public void MakeOrder(Product product)
        {
            // код покупки при размещении заказа на доставку
        }
    }
}