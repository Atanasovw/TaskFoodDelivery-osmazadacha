    using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace FoodDelivery.Data
{
    public class DishesDbContext: DbContext
    {
        public DishesDbContext() : base("DishesDbContext")
        {

        }
        // Създаване редовете на таблица Dishes
        public DbSet<Dishes> Dishes { get; set; }
        // Създаване редовете на таблица DishTypes
        public DbSet<DishTypes> DishTypes { get; set; } 
    }
}
