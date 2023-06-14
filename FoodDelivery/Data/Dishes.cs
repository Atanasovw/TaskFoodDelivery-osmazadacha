using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodDelivery.Data
{
    public class Dishes
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public double Grammage { get; set; }
        // M:1
        public int DishTypeId { get; set; } // Forein key
        public DishTypes DishTypes { get; set; } // Таблица ,с която се осъществява връзката

    }
}
