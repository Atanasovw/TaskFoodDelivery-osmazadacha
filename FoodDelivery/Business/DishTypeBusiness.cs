using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoodDelivery.Data;

namespace FoodDelivery.Business
{
    public class DishTypeBusiness
    {
        private DishesDbContext _dishesDbContext = new DishesDbContext();
        public List<DishTypes> GetAllDishеsOfTypes()
        {
            return _dishesDbContext.DishTypes.ToList();
        }
        public string GetDishTypeById(int id)
        {
            return _dishesDbContext.DishTypes.Find(id).Name;
        }
    }
}
