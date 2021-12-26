using FoodDeliveryApp.DomainModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodDeliveryApp.Repository.DishRepository
{
    public interface IDishRepository
    {
        List<Dish> GetDishes();
        Dish GetDish(int id);

        Dish AddDish(Dish dish);
        void DeleteDish(Dish dish);
        void EditDish(Dish dish);

    }
}
