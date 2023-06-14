using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodDelivery.Data
{
    public class DishTypes
    {
        public int Id { get; set; }
        public string Name { get; set; }
        // 1:M
        public ICollection<Dishes> Dishes { get; set; }

    }
}
