using SoftwareProductStore.Domain.Core;

namespace SoftwareProductStore.Services.Interfaces
{
    public interface IOrder
    {
        void MakeOrder(Product product);
    }
}