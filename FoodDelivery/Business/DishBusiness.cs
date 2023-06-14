using System;
using FoodDelivery.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodDelivery.Business
{
    public class DishBusiness
    {
        private DishesDbContext _dishesDbContext = new DishesDbContext();
        public Dishes Get(int id)
        {
            //Dish findedDish = _dishesDbContext.Dishes.Find(id);
            //if (findedDish == null)
            //{
            //    //_dishesDbContext.Dishes.Include("Dishes").Where(x=> x.DishTypeId==)
            //    _dishesDbContext.Entry(findedDish).Reference(x => x.DishTypes).Load();
            //}
            //return findedDish;
            using (_dishesDbContext = new DishesDbContext())
            {
                Dishes findedDish = _dishesDbContext.Dishes.Find(id);
                return findedDish;
            }
        }
        public List<Dishes> GetAll()
        {
            
            using (_dishesDbContext = new DishesDbContext())
            {
                List<Dishes> listDish = _dishesDbContext.Dishes.ToList();
                return listDish;
            }
        }
        public void Create(Dishes dish)
        {
            using (_dishesDbContext=new DishesDbContext())
            {
                _dishesDbContext.Dishes.Add(dish);
                _dishesDbContext.SaveChanges();
            }
            
        }
        public void Update(int id, Dishes dish) { 
            Dishes findedDish = _dishesDbContext.Dishes.Find(id);
            if (findedDish == null)
            {
                return;
            }
            findedDish.Name=dish.Name;
            findedDish.Description=dish.Description;
            findedDish.Price=dish.Price;
            findedDish.Grammage=dish.Grammage;
            findedDish.DishTypeId=dish.DishTypeId;
            _dishesDbContext.SaveChanges();
        }
        public void Delete(int id)
        {
            Dishes findedDish = _dishesDbContext.Dishes.Find(id);
            _dishesDbContext.Dishes.Remove(findedDish);
            _dishesDbContext.SaveChanges();
        }
    }
}
