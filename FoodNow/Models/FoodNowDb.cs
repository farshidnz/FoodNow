using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoodNow.Models;

namespace FoodNow.Models
{
    class FoodNowDb : DbContext
    {
        public FoodNowDb() : base("DefaultConnection")
        { }
        public DbSet<Restaurant> Restaurants { get; set; }
    }

}
