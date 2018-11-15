using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Lab24.Models
{
    public class Items
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public float Price { get; set; }
    }

    public class DBItemContex : DbContext
    {
        public DbSet<Items> Item { get; set; }
    }
}