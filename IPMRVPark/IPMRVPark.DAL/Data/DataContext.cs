using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using IPMRVPark.Models;

namespace IPMRVPark.Contracts.Data
{
    public class DataContext : DbContext
    {
        public DataContext() : base("ipmrvparkDbContext")
        {

        }
        public DbSet<BasketItem> BasketItems { get; set; }
        public DbSet<Basket> Baskets { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
