using System;
using System.Collections.Generic;
using System.Data.Entity;
using SoftwareProductStore.Domain.Core;

namespace SoftwareProductStore.Infrastructure.Data
{
    public class OrderContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
    }
}