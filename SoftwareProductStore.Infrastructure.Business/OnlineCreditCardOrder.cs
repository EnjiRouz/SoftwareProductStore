using SoftwareProductStore.Domain.Core;
using SoftwareProductStore.Services.Interfaces;

namespace SoftwareProductStore.Infrastructure.Business
{
    public class OnlineCreditCardOrder : IOrder
    {
        public void MakeOrder(Product product)
        {
            // код покупки при оплате по карте на сайте онлайн
        }
    }
}