using System;
using System.Collections.Generic;
using System.Data.Entity;
using SoftwareProductStore.Domain.Core;

namespace SoftwareProductStore.Infrastructure.Data
{
    public class OrderContext : DbContext
    {
        /// <summary>
        /// Взаимодействие с базой данных
        /// </summary>
        public DbSet<Product> Products { get; set; }
    }
}