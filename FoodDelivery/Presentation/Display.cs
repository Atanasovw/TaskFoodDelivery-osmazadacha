using System;
using FoodDelivery.Data;
using FoodDelivery.Business;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodDelivery.Presentation
{
    public class Display
    {
        private int closeOperationId = 6;
        private DishBusiness dishBusiness = new DishBusiness();
        public Display()
        {
            Input();
        }
        private void ShowMenu()
        {
            Console.WriteLine(new string('-', 40));
            Console.WriteLine(new string(' ', 18) + "MENU" + new string(' ', 18));
            Console.WriteLine(new string('-', 40));
            Console.WriteLine("1. List all entries");
            Console.WriteLine("2. Add new entry");
            Console.WriteLine("3. Update entry");
            Console.WriteLine("4. Fetch entry by ID");
            Console.WriteLine("5. Delete entry by ID");
            Console.WriteLine("6. Exit");
        }
        private void Input()
        {
            var operation = -1;
            do
            {
                ShowMenu();
                operation = int.Parse(Console.ReadLine());
                switch (operation)
                {
                    case 1:
                        ListAll();
                        break;
                    case 2:
                        Add();
                        break;
                    case 3:
                        Update();
                        break;
                    case 4:
                        Fetch();
                        break;
                    case 5:
                        Delete();
                        break;
                    default:
                        break;
                }
            } while (operation != closeOperationId);
        }
        private void PrintDish(Dishes dish)
        {
            Console.WriteLine($" {dish.Id} {dish.Name}--{dish.Description} price: {dish.Price} grammage:{dish.Grammage}; {dish.DishTypeId}");
        }
        private void Delete()
        {
            Console.WriteLine("Enter ID to delete: ");
            int id = int.Parse(Console.ReadLine());
            DishBusiness dishController = new DishBusiness();
            Dishes dish = dishController.Get(id);
            if(dish!=null)
            {
                dishController.Delete(id);
            }
        }

        private void Fetch()
        {
            Console.WriteLine("Enter ID to fetch: ");
            int id = int.Parse(Console.ReadLine());
            DishBusiness dishController = new DishBusiness();
            Dishes dish = dishController.Get(id);
            if (dish != null)
            {
                PrintDish(dish);
            }
        }

        private void Update()
        {
            Console.WriteLine("Enter ID to update: ");
            int id = int.Parse(Console.ReadLine());
            DishBusiness dishController = new DishBusiness();
            Dishes newDish = dishController.Get(id);
            if (newDish == null)
            {
                Console.WriteLine("No searching dish");
                return;
            }
            PrintDish(newDish);
            Console.WriteLine("Enter the new values: ");
            Console.WriteLine("Name: ");
            newDish.Name=Console.ReadLine();
            Console.WriteLine("Description: ");
            newDish.Description=Console.ReadLine();
            Console.WriteLine("Price: ");
            newDish.Price = int.Parse(Console.ReadLine());
            Console.WriteLine("Grammage: ");
            newDish.Grammage=int.Parse(Console.ReadLine());
            DishTypeBusiness dishTypeController = new DishTypeBusiness();
            List<DishTypes> allDishesOfTypes = new List<DishTypes>();
            Console.WriteLine("Types: ");
            Console.WriteLine(new string('-',4));
            foreach(var item in allDishesOfTypes)
            {
                Console.WriteLine(item.Id+". "+item.Name);   
            }
            Console.WriteLine("Choose type: ");
            newDish.DishTypeId = int.Parse(Console.ReadLine());
            DishBusiness dishBusiness = new DishBusiness();
            dishBusiness.Update(id, newDish);
        }

        private void Add()
        {
           Dishes newDish = new Dishes();
            Console.WriteLine("Name: ");
            newDish.Name = Console.ReadLine();
            Console.WriteLine("Description: ");
            newDish.Description = Console.ReadLine();
            Console.WriteLine("Price: ");
            newDish.Price = int.Parse(Console.ReadLine());
            Console.WriteLine("Grammage: ");
            newDish.Grammage = int.Parse(Console.ReadLine());
            List<DishTypes> allDishesOfTypes = new List<DishTypes>();
            Console.WriteLine("Types: ");
            Console.WriteLine(new string('-', 4));
            foreach (var item in allDishesOfTypes)
            {
                Console.WriteLine(item.Id + ". " + item.Name);
            }
            Console.WriteLine("Choose type: ");
            newDish.DishTypeId = int.Parse(Console.ReadLine());
            DishBusiness dishBusiness = new DishBusiness();
            dishBusiness.Create(newDish);
            Console.WriteLine($"{newDish.Id}. {newDish.Name} > {newDish.Description} > {newDish.Price} > {newDish.Grammage} > type:{newDish.DishTypeId}");
        }

        private void ListAll()
        {
            Console.WriteLine(new string('-', 40));
            Console.WriteLine(new string(' ', 16) + "DISHES" + new string(' ', 16));
            Console.WriteLine(new string('-', 40));
            var dishes = dishBusiness.GetAll();
            foreach (var item in dishes)
            {
                Console.WriteLine($" {item.Id}  {item.Name}  {item.Description}  {item.Price}  {item.Grammage} {item.DishTypeId}");
            }
        }

    }
}
