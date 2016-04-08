﻿using ConstellationStore.Models;
using System.Data.Entity;

namespace ConstellationStore.Contracts.Data
{
    public class DataContext:DbContext
    {
        public DataContext() : base("constellationDbContext")
        {
            //Configuration.LazyLoadingEnabled = true;
        }

        public DbSet<BasketItem> BasketItems { get; set; }
        public DbSet<Basket> Baskets { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
