using Ninject.Modules;
using SoftwareProductStore.Domain.Interfaces;
using SoftwareProductStore.Infrastructure.Business;
using SoftwareProductStore.Infrastructure.Data;
using SoftwareProductStore.Services.Interfaces;

namespace SoftwareProductStore.WebApplication.Utils
{
    public class NinjectRegistrations : NinjectModule
    {
        public override void Load()
        {
            Bind<IProductRepository>().To<ProductRepository>();
            Bind<IOrder>().To<OnlineCreditCardOrder>();
        }
    }
}